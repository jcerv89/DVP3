namespace CervenecJustin_CodeExercise02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ContactList = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textRelation = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactList
            // 
            this.ContactList.Location = new System.Drawing.Point(57, 286);
            this.ContactList.Name = "ContactList";
            this.ContactList.Size = new System.Drawing.Size(552, 355);
            this.ContactList.TabIndex = 0;
            this.ContactList.UseCompatibleStateImageBehavior = false;
            this.ContactList.View = System.Windows.Forms.View.List;
            this.ContactList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ContactList_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(57, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(263, 680);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(228, 31);
            this.textFirstName.TabIndex = 2;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(263, 901);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(228, 31);
            this.textEmail.TabIndex = 3;
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(263, 831);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(228, 31);
            this.textPhoneNumber.TabIndex = 4;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(263, 755);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(228, 31);
            this.textLastName.TabIndex = 5;
            // 
            // textRelation
            // 
            this.textRelation.Location = new System.Drawing.Point(263, 973);
            this.textRelation.Name = "textRelation";
            this.textRelation.Size = new System.Drawing.Size(228, 31);
            this.textRelation.TabIndex = 6;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(132, 683);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(116, 25);
            this.lblFirst.TabIndex = 7;
            this.lblFirst.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 976);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Relation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 904);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 837);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone Number";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(133, 758);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(115, 25);
            this.lblLast.TabIndex = 11;
            this.lblLast.Text = "Last Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 1280);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.textRelation);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ContactList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ContactList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textRelation;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLast;
    }
}

