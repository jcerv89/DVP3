using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace CervenecJustin_CodeExercise02
{
    public partial class Form1 : Form
    {

        DataTable theData = new DataTable();
        MySqlConnection conn = new MySqlConnection();
        int currentRow = 0;//Variable for cycling through LV
        //List to hold DB info
        List<ContactInfo> contactList = new List<ContactInfo>();

        int phoneNumber;//Variable for phone# validation
        public Form1()
        {
            InitializeComponent();

            HandleClientWindowSize();

            string connString = DbUtilities.BuildConnection();

            conn = DbUtilities.Connect(connString);

            GetData();

            //Adds Image Icon to contacts in the list view
            for (int x = 0; x < theData.Select().Length; x++)
            {
                ContactList.View = View.List;
                ContactList.SmallImageList = imageList1;
                ContactList.Items[x].ImageIndex = 0;
            }
        }
        //Call this method AFTER InitializeComponent() inside the form's constructor.
        void HandleClientWindowSize()
        {
            //Modify ONLY these float values
            float HeightValueToChange = 1.4f;
            float WidthValueToChange = 6.0f;

            //DO NOT MODIFY THIS CODE
            int height = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Height / HeightValueToChange);
            int width = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Width / WidthValueToChange);
            if (height < Size.Height)
                height = Size.Height;
            if (width < Size.Width)
                width = Size.Width;
            this.Size = new Size(width, height);
            this.Size = new Size(376, 720);
        }

        private bool GetData()
        {
            //Pulls data from database to put into list and display in the listview
            string sql = "SELECT FirstName, LastName, PhoneNumber, Email, Relation FROM MyContacts LIMIT 10;";


            //create data adapter
            MySqlDataAdapter adr = new MySqlDataAdapter(sql, conn);
            //mysqldat convet = new MySqlDataAdapter(convertYear, conn);

            //set type for select command

            adr.SelectCommand.CommandType = CommandType.Text;
            //fill method to add rows 
            adr.Fill(theData);

           
            for (int i = 0; i < theData.Rows.Count; i++)
            {

                DataRow dr = theData.Rows[i];
                ContactInfo contacts = new ContactInfo();
                //Adds DB data to the List
                contacts.FirstName = (dr["FirstName"].ToString());
                contacts.LastName = (dr["LastName"].ToString());
                contacts.PhoneNumber = (dr["PhoneNumber"].ToString());
                contacts.Email = (dr["Email"].ToString());
                contacts.Relation = (dr["Relation"].ToString());
                contactList.Add(contacts);

            }

            foreach (ContactInfo contact in contactList)//Adds list items to listview with contact image icon
            {
                ContactInfo c = contact;
                ListViewItem lvi = new ListViewItem();
                lvi.Text = c.ToString();
                lvi.ImageIndex = 0;
                lvi.Tag = c;
                ContactList.Items.Add(lvi);
            }






            conn.Close();
            return true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ContactList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Populates controls on Form with current selcted item in listview
            if (ContactList.SelectedIndices.Count > 0)
            {

                ListViewItem item = ContactList.SelectedItems[0];

            }
            for (int i = 0; i < ContactList.Items.Count; i++)
            {
                if (ContactList.Items[i].Selected)
                {//Populate each control
                    ContactInfo selectedContact = ContactList.SelectedItems[0].Tag as ContactInfo;
                    textFirstName.Text = selectedContact.FirstName;
                    textLastName.Text = selectedContact.LastName;
                    textPhoneNumber.Text = selectedContact.PhoneNumber;
                    textEmail.Text = selectedContact.Email;
                    textRelation.Text = selectedContact.Relation;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //increments forward through the data
            if (currentRow < theData.Select().Length - 1)
            {
                currentRow++;
                textFirstName.Text = theData.Rows[currentRow]["FirstName"].ToString();
                textLastName.Text = theData.Rows[currentRow]["LastName"].ToString();
               
                textPhoneNumber.Text = theData.Rows[currentRow]["PhoneNumber"].ToString();
                textEmail.Text = theData.Rows[currentRow]["Email"].ToString();
                textRelation.Text = theData.Rows[currentRow]["Relation"].ToString();

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentRow > 0)
            {   //Cycles through the list view backwards
                currentRow--;
                textFirstName.Text = theData.Rows[currentRow]["FirstName"].ToString();
                textLastName.Text = theData.Rows[currentRow]["LastName"].ToString();

                textPhoneNumber.Text = theData.Rows[currentRow]["PhoneNumber"].ToString();
                textEmail.Text = theData.Rows[currentRow]["Email"].ToString();
                textRelation.Text = theData.Rows[currentRow]["Relation"].ToString();




            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (ContactList.SelectedItems.Count > 0)
            {
                //Get data associated with name in listview
                ContactInfo contactSelected = ContactList.SelectedItems[0].Tag as ContactInfo;

                //If info is changed in the form controls, this will update list and listview
                ContactInfo contactUpdate = new ContactInfo();
                contactUpdate.FirstName = textFirstName.Text;
                contactUpdate.LastName = textLastName.Text;
                
                contactUpdate.PhoneNumber = textPhoneNumber.Text;
                contactUpdate.Email = textEmail.Text;
                contactUpdate.Relation = textRelation.Text;

               

                ContactList.SelectedItems[0].Text = contactUpdate.ToString();
                ContactList.SelectedItems[0].Tag = contactUpdate;

                ContactList.Refresh();
                string originalPhoneNumber = contactSelected.PhoneNumber;

                UpdateDB(contactUpdate, contactSelected);//Call SQL Update method
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Select item to update.");
            }
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            //Get data associated with name in listview

            if (textFirstName.Text!="" && textPhoneNumber.Text!=""&& textLastName.Text!=""&& textEmail.Text!=""&& textRelation.Text!="")
            {


                //If info is changed in the form controls, this will update list and
                ContactInfo contactAdd = new ContactInfo();

                contactAdd.FirstName = textFirstName.Text;
                contactAdd.LastName = textLastName.Text;
                contactAdd.PhoneNumber = textPhoneNumber.Text;
                contactAdd.Email = textEmail.Text;
                contactAdd.Relation = textRelation.Text;


                //Add new item to Listview with image from imageList
                ContactInfo c = contactAdd;
                ListViewItem lvi = new ListViewItem();
                lvi.Text = c.ToString();
                lvi.ImageIndex = 0;
                lvi.Tag = c;
                ContactList.Items.Add(lvi);



             
                AddContact(contactAdd);//Adds new contact to database
                ContactList.Refresh();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Enter Contact information before clicking the add button.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ContactList.SelectedItems.Count > 0)
            {
                //Get data associated with name in listview
                ContactInfo contactSelected = ContactList.SelectedItems[0].Tag as ContactInfo;

                //If info is changed in the form controls, this will update list and listview
                ContactInfo contactdelete = new ContactInfo();
                contactdelete.FirstName = textFirstName.Text;
                contactdelete.LastName = textLastName.Text;
                contactdelete.PhoneNumber = textPhoneNumber.Text;
                contactdelete.Email = textEmail.Text;
                contactdelete.Relation = textRelation.Text;

                ContactList.SelectedItems[0].Remove();
                //ContactList.SelectedItems[0].Tag = contactUpdate;

                ContactList.Refresh();
                string originalPhoneNumber = contactSelected.PhoneNumber;

                DeleteContact(contactdelete);//Call SQL Update method
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Select contact to delete.");
            }
        }

        private void UpdateDB(ContactInfo updateContact, ContactInfo oldContact)
        {
            //Method to update the database with any changed information
            ContactInfo contactUpdate = updateContact;
            ContactInfo contactCheck = oldContact;

            try
            {

                conn.Open();

                //Query to update information when user chooses to do so
                string updateSql = $"UPDATE MyContacts SET FirstName = '{contactUpdate.FirstName}', LastName = '{contactUpdate.LastName}', PhoneNumber = '{contactUpdate.PhoneNumber}', Email = '{contactUpdate.Email}', Relation = '{contactUpdate.Relation}' where PhoneNumber = '{contactCheck.PhoneNumber}';";


                MySqlCommand updatecmd = new MySqlCommand(updateSql, conn);
                MySqlDataReader reader1;

                reader1 = updatecmd.ExecuteReader();

                conn.Close();

            }
            catch (MySqlException e)

            {
                MessageBox.Show($"No connection\n\n {e}");
            }

        }

        private void AddContact(ContactInfo add)
        {
            //Method to update the database with any changed information
            ContactInfo addContact = add;

           try
            {

                conn.Open();

                //Query to add new contact information when user clicks add button
                string updateSql = $"INSERT INTO MyContacts (FirstName, LastName, PhoneNumber, Email, Relation) values('{addContact.FirstName}', '{addContact.LastName}', '{addContact.PhoneNumber}', '{addContact.Email}', '{addContact.Relation}')";


                MySqlCommand updatecmd = new MySqlCommand(updateSql, conn);
                MySqlDataReader reader1;

                reader1 = updatecmd.ExecuteReader();

                conn.Close();

            }
            catch (MySqlException e)

            {
                MessageBox.Show($"No connection\n\n {e}");
            }

        }

        private void DeleteContact(ContactInfo delete)
        {
            //Method to update the database with any changed information
            ContactInfo contactDelete = delete;

            try
            {

                conn.Open();

                //Query to update information when user chooses to do so
                string updateSql = $"DELETE FROM MyContacts WHERE PhoneNumber = '{contactDelete.PhoneNumber}'";


                MySqlCommand updatecmd = new MySqlCommand(updateSql, conn);
                MySqlDataReader reader1;

                reader1 = updatecmd.ExecuteReader();

                conn.Close();

            }
            catch (MySqlException e)

            {
                MessageBox.Show($"No connection\n\n {e}");
            }
        }

        private void ClearInputs()
        {
            textFirstName.Clear();
            textLastName.Clear();
            textPhoneNumber.Clear();
            textEmail.Clear();
            textRelation.Clear();

        }

        private void CheckInputs()
        {
            //Check Phone number input
            if (!int.TryParse(textPhoneNumber.Text, out phoneNumber)&&textPhoneNumber.Text.Length!=10)
            {
                textPhoneNumber.Clear();
                MessageBox.Show("Enter only numbers for phone number, and make sure the phone number is 10 digits.");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Code to Save to a txt file of users location choice
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

           

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {


                // Stream to write info to text file
                StreamWriter write = new StreamWriter(saveFileDialog1.FileName);
                foreach (ListViewItem item in ContactList.Items)
                {
                    write.WriteLine(item.SubItems[0].Text);
                }

                write.Close();



            }
        }

        private void btnFirstRecod_Click(object sender, EventArgs e)
        {

            currentRow = 0;


            //Jumps to first record pulled from the database
            textFirstName.Text = theData.Rows[currentRow]["FirstName"].ToString();
            textLastName.Text = theData.Rows[currentRow]["LastName"].ToString();
          
            textPhoneNumber.Text = theData.Rows[currentRow]["PhoneNumber"].ToString();
            textEmail.Text = theData.Rows[currentRow]["Email"].ToString();
            textRelation.Text = theData.Rows[currentRow]["Relation"].ToString();
        }

        private void btnLastRecord_Click(object sender, EventArgs e)
        {
            currentRow = theData.Select().Count() - 1;
            //Jumps to last record pulled from the database
            textFirstName.Text = theData.Rows[currentRow]["FirstName"].ToString();
            textLastName.Text = theData.Rows[currentRow]["LastName"].ToString(); 
       
            textPhoneNumber.Text = theData.Rows[currentRow]["PhoneNumber"].ToString();
            textEmail.Text = theData.Rows[currentRow]["Email"].ToString();
            textRelation.Text = theData.Rows[currentRow]["Relation"].ToString();
        }
    }
}
