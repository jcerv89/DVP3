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
        public Form1()
        {
            InitializeComponent();

            HandleClientWindowSize();

            string connString = DbUtilities.BuildConnection();

            conn = DbUtilities.Connect(connString);

            GetData();
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
            //this.Size = new Size(376, 720);
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

            //List to hold DB info
            List<ContactInfo> dvdlist = new List<ContactInfo>();
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
                dvdlist.Add(contacts);

            }

            foreach (ContactInfo dvd in dvdlist)//Adds list items to listview
            {
                ContactInfo d = dvd;
                ListViewItem lvi = new ListViewItem();
                lvi.Text = d.ToString();
                lvi.ImageIndex = 0;
                lvi.Tag = d;
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
    }
}
