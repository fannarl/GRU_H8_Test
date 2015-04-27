namespace GRU_H8_Test
{
    partial class Control
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblSearchSSN = new System.Windows.Forms.Label();
            this.txtBoxSearchSSN = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.LblSSN = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblFullName = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtBoxSSN = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxFullName = new System.Windows.Forms.TextBox();
            this.groupBoxAuthority = new System.Windows.Forms.GroupBox();
            this.radioBtnAuthority3 = new System.Windows.Forms.RadioButton();
            this.radioBtnAuthority2 = new System.Windows.Forms.RadioButton();
            this.radioBtnAuthority1 = new System.Windows.Forms.RadioButton();
            this.listViewUsernames = new System.Windows.Forms.ListView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEvntAdd = new System.Windows.Forms.Button();
            this.btnEvntUpdate = new System.Windows.Forms.Button();
            this.btnEvntDelete = new System.Windows.Forms.Button();
            this.btnEvntClear = new System.Windows.Forms.Button();
            this.grbxEvntInformation = new System.Windows.Forms.GroupBox();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtEventLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtEventDate = new System.Windows.Forms.TextBox();
            this.lblEvntDate = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.lblEvntName = new System.Windows.Forms.Label();
            this.btnEventSearch = new System.Windows.Forms.Button();
            this.txtEventSearch = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.listViewEvent = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEventDescription = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.groupBoxInformation.SuspendLayout();
            this.groupBoxAuthority.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grbxEvntInformation.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUsers);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 483);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.BtnAdd);
            this.tabPageUsers.Controls.Add(this.BtnClear);
            this.tabPageUsers.Controls.Add(this.LblSearchSSN);
            this.tabPageUsers.Controls.Add(this.txtBoxSearchSSN);
            this.tabPageUsers.Controls.Add(this.BtnSearch);
            this.tabPageUsers.Controls.Add(this.BtnUpdate);
            this.tabPageUsers.Controls.Add(this.BtnDelete);
            this.tabPageUsers.Controls.Add(this.groupBoxInformation);
            this.tabPageUsers.Controls.Add(this.listViewUsernames);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(841, 457);
            this.tabPageUsers.TabIndex = 0;
            this.tabPageUsers.Text = "Users";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(736, 407);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(63, 31);
            this.BtnAdd.TabIndex = 12;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(448, 407);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(63, 31);
            this.BtnClear.TabIndex = 11;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // LblSearchSSN
            // 
            this.LblSearchSSN.AutoSize = true;
            this.LblSearchSSN.Location = new System.Drawing.Point(495, 42);
            this.LblSearchSSN.Name = "LblSearchSSN";
            this.LblSearchSSN.Size = new System.Drawing.Size(117, 13);
            this.LblSearchSSN.TabIndex = 10;
            this.LblSearchSSN.Text = "Social Security Number";
            // 
            // txtBoxSearchSSN
            // 
            this.txtBoxSearchSSN.Location = new System.Drawing.Point(498, 58);
            this.txtBoxSearchSSN.Name = "txtBoxSearchSSN";
            this.txtBoxSearchSSN.Size = new System.Drawing.Size(134, 20);
            this.txtBoxSearchSSN.TabIndex = 9;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(668, 52);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(77, 31);
            this.BtnSearch.TabIndex = 6;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(640, 407);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(63, 31);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(544, 407);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(63, 31);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(this.LblPassword);
            this.groupBoxInformation.Controls.Add(this.LblUsername);
            this.groupBoxInformation.Controls.Add(this.LblPhoneNumber);
            this.groupBoxInformation.Controls.Add(this.LblSSN);
            this.groupBoxInformation.Controls.Add(this.LblEmail);
            this.groupBoxInformation.Controls.Add(this.LblFullName);
            this.groupBoxInformation.Controls.Add(this.txtBoxPassword);
            this.groupBoxInformation.Controls.Add(this.txtBoxUsername);
            this.groupBoxInformation.Controls.Add(this.txtBoxPhoneNumber);
            this.groupBoxInformation.Controls.Add(this.txtBoxSSN);
            this.groupBoxInformation.Controls.Add(this.txtBoxEmail);
            this.groupBoxInformation.Controls.Add(this.txtBoxFullName);
            this.groupBoxInformation.Controls.Add(this.groupBoxAuthority);
            this.groupBoxInformation.Location = new System.Drawing.Point(467, 99);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(306, 289);
            this.groupBoxInformation.TabIndex = 3;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Information";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(28, 225);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(53, 13);
            this.LblPassword.TabIndex = 12;
            this.LblPassword.Text = "Password";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(28, 186);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(55, 13);
            this.LblUsername.TabIndex = 11;
            this.LblUsername.Text = "Username";
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.Location = new System.Drawing.Point(28, 147);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(76, 13);
            this.LblPhoneNumber.TabIndex = 10;
            this.LblPhoneNumber.Text = "Phone number";
            // 
            // LblSSN
            // 
            this.LblSSN.AutoSize = true;
            this.LblSSN.Location = new System.Drawing.Point(28, 108);
            this.LblSSN.Name = "LblSSN";
            this.LblSSN.Size = new System.Drawing.Size(117, 13);
            this.LblSSN.TabIndex = 9;
            this.LblSSN.Text = "Social Security Number";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(28, 69);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(35, 13);
            this.LblEmail.TabIndex = 8;
            this.LblEmail.Text = "E-mail";
            // 
            // LblFullName
            // 
            this.LblFullName.AutoSize = true;
            this.LblFullName.Location = new System.Drawing.Point(28, 30);
            this.LblFullName.Name = "LblFullName";
            this.LblFullName.Size = new System.Drawing.Size(52, 13);
            this.LblFullName.TabIndex = 7;
            this.LblFullName.Text = "Full name";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(31, 241);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(134, 20);
            this.txtBoxPassword.TabIndex = 6;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(31, 202);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(134, 20);
            this.txtBoxUsername.TabIndex = 5;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(31, 163);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(134, 20);
            this.txtBoxPhoneNumber.TabIndex = 4;
            // 
            // txtBoxSSN
            // 
            this.txtBoxSSN.Location = new System.Drawing.Point(31, 124);
            this.txtBoxSSN.Name = "txtBoxSSN";
            this.txtBoxSSN.Size = new System.Drawing.Size(134, 20);
            this.txtBoxSSN.TabIndex = 3;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(31, 85);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(247, 20);
            this.txtBoxEmail.TabIndex = 2;
            // 
            // txtBoxFullName
            // 
            this.txtBoxFullName.Location = new System.Drawing.Point(31, 46);
            this.txtBoxFullName.Name = "txtBoxFullName";
            this.txtBoxFullName.Size = new System.Drawing.Size(247, 20);
            this.txtBoxFullName.TabIndex = 1;
            // 
            // groupBoxAuthority
            // 
            this.groupBoxAuthority.Controls.Add(this.radioBtnAuthority3);
            this.groupBoxAuthority.Controls.Add(this.radioBtnAuthority2);
            this.groupBoxAuthority.Controls.Add(this.radioBtnAuthority1);
            this.groupBoxAuthority.Location = new System.Drawing.Point(198, 138);
            this.groupBoxAuthority.Name = "groupBoxAuthority";
            this.groupBoxAuthority.Size = new System.Drawing.Size(80, 109);
            this.groupBoxAuthority.TabIndex = 0;
            this.groupBoxAuthority.TabStop = false;
            this.groupBoxAuthority.Text = "Authority";
            // 
            // radioBtnAuthority3
            // 
            this.radioBtnAuthority3.AutoSize = true;
            this.radioBtnAuthority3.Location = new System.Drawing.Point(25, 74);
            this.radioBtnAuthority3.Name = "radioBtnAuthority3";
            this.radioBtnAuthority3.Size = new System.Drawing.Size(31, 17);
            this.radioBtnAuthority3.TabIndex = 2;
            this.radioBtnAuthority3.TabStop = true;
            this.radioBtnAuthority3.Text = "3";
            this.radioBtnAuthority3.UseVisualStyleBackColor = true;
            // 
            // radioBtnAuthority2
            // 
            this.radioBtnAuthority2.AutoSize = true;
            this.radioBtnAuthority2.Location = new System.Drawing.Point(25, 51);
            this.radioBtnAuthority2.Name = "radioBtnAuthority2";
            this.radioBtnAuthority2.Size = new System.Drawing.Size(31, 17);
            this.radioBtnAuthority2.TabIndex = 1;
            this.radioBtnAuthority2.TabStop = true;
            this.radioBtnAuthority2.Text = "2";
            this.radioBtnAuthority2.UseVisualStyleBackColor = true;
            // 
            // radioBtnAuthority1
            // 
            this.radioBtnAuthority1.AutoSize = true;
            this.radioBtnAuthority1.Location = new System.Drawing.Point(25, 28);
            this.radioBtnAuthority1.Name = "radioBtnAuthority1";
            this.radioBtnAuthority1.Size = new System.Drawing.Size(31, 17);
            this.radioBtnAuthority1.TabIndex = 0;
            this.radioBtnAuthority1.TabStop = true;
            this.radioBtnAuthority1.Text = "1";
            this.radioBtnAuthority1.UseVisualStyleBackColor = true;
            // 
            // listViewUsernames
            // 
            this.listViewUsernames.FullRowSelect = true;
            this.listViewUsernames.GridLines = true;
            this.listViewUsernames.Location = new System.Drawing.Point(25, 42);
            this.listViewUsernames.Name = "listViewUsernames";
            this.listViewUsernames.Size = new System.Drawing.Size(403, 384);
            this.listViewUsernames.TabIndex = 2;
            this.listViewUsernames.UseCompatibleStateImageBehavior = false;
            this.listViewUsernames.View = System.Windows.Forms.View.Details;
            this.listViewUsernames.SelectedIndexChanged += new System.EventHandler(this.listViewUsernames_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEvntAdd);
            this.tabPage1.Controls.Add(this.btnEvntUpdate);
            this.tabPage1.Controls.Add(this.btnEvntDelete);
            this.tabPage1.Controls.Add(this.btnEvntClear);
            this.tabPage1.Controls.Add(this.grbxEvntInformation);
            this.tabPage1.Controls.Add(this.btnEventSearch);
            this.tabPage1.Controls.Add(this.txtEventSearch);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.listViewEvent);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(841, 457);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Events";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEvntAdd
            // 
            this.btnEvntAdd.Location = new System.Drawing.Point(745, 410);
            this.btnEvntAdd.Name = "btnEvntAdd";
            this.btnEvntAdd.Size = new System.Drawing.Size(75, 23);
            this.btnEvntAdd.TabIndex = 8;
            this.btnEvntAdd.Text = "Add";
            this.btnEvntAdd.UseVisualStyleBackColor = true;
            this.btnEvntAdd.Click += new System.EventHandler(this.btnEvntAdd_Click);
            // 
            // btnEvntUpdate
            // 
            this.btnEvntUpdate.Location = new System.Drawing.Point(653, 410);
            this.btnEvntUpdate.Name = "btnEvntUpdate";
            this.btnEvntUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnEvntUpdate.TabIndex = 7;
            this.btnEvntUpdate.Text = "Update";
            this.btnEvntUpdate.UseVisualStyleBackColor = true;
            this.btnEvntUpdate.Click += new System.EventHandler(this.btnEvntUpdate_Click);
            // 
            // btnEvntDelete
            // 
            this.btnEvntDelete.Location = new System.Drawing.Point(559, 410);
            this.btnEvntDelete.Name = "btnEvntDelete";
            this.btnEvntDelete.Size = new System.Drawing.Size(75, 23);
            this.btnEvntDelete.TabIndex = 6;
            this.btnEvntDelete.Text = "Delete";
            this.btnEvntDelete.UseVisualStyleBackColor = true;
            this.btnEvntDelete.Click += new System.EventHandler(this.btnEvntDelete_Click);
            // 
            // btnEvntClear
            // 
            this.btnEvntClear.Location = new System.Drawing.Point(457, 410);
            this.btnEvntClear.Name = "btnEvntClear";
            this.btnEvntClear.Size = new System.Drawing.Size(75, 23);
            this.btnEvntClear.TabIndex = 5;
            this.btnEvntClear.Text = "Clear";
            this.btnEvntClear.UseVisualStyleBackColor = true;
            this.btnEvntClear.Click += new System.EventHandler(this.btnEvntClear_Click);
            // 
            // grbxEvntInformation
            // 
            this.grbxEvntInformation.Controls.Add(this.txtEventDescription);
            this.grbxEvntInformation.Controls.Add(this.label4);
            this.grbxEvntInformation.Controls.Add(this.txtEventID);
            this.grbxEvntInformation.Controls.Add(this.lblID);
            this.grbxEvntInformation.Controls.Add(this.txtEventLocation);
            this.grbxEvntInformation.Controls.Add(this.lblLocation);
            this.grbxEvntInformation.Controls.Add(this.txtEventDate);
            this.grbxEvntInformation.Controls.Add(this.lblEvntDate);
            this.grbxEvntInformation.Controls.Add(this.txtEventName);
            this.grbxEvntInformation.Controls.Add(this.lblEvntName);
            this.grbxEvntInformation.Location = new System.Drawing.Point(487, 98);
            this.grbxEvntInformation.Name = "grbxEvntInformation";
            this.grbxEvntInformation.Size = new System.Drawing.Size(281, 274);
            this.grbxEvntInformation.TabIndex = 4;
            this.grbxEvntInformation.TabStop = false;
            this.grbxEvntInformation.Text = "Information";
            // 
            // txtEventID
            // 
            this.txtEventID.Location = new System.Drawing.Point(29, 41);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.Size = new System.Drawing.Size(100, 20);
            this.txtEventID.TabIndex = 7;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(26, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID";
            // 
            // txtEventLocation
            // 
            this.txtEventLocation.Location = new System.Drawing.Point(152, 86);
            this.txtEventLocation.Name = "txtEventLocation";
            this.txtEventLocation.Size = new System.Drawing.Size(100, 20);
            this.txtEventLocation.TabIndex = 5;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(149, 70);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Location";
            // 
            // txtEventDate
            // 
            this.txtEventDate.Location = new System.Drawing.Point(29, 86);
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.Size = new System.Drawing.Size(100, 20);
            this.txtEventDate.TabIndex = 3;
            // 
            // lblEvntDate
            // 
            this.lblEvntDate.AutoSize = true;
            this.lblEvntDate.Location = new System.Drawing.Point(26, 70);
            this.lblEvntDate.Name = "lblEvntDate";
            this.lblEvntDate.Size = new System.Drawing.Size(30, 13);
            this.lblEvntDate.TabIndex = 2;
            this.lblEvntDate.Text = "Date";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(152, 41);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(100, 20);
            this.txtEventName.TabIndex = 1;
            // 
            // lblEvntName
            // 
            this.lblEvntName.AutoSize = true;
            this.lblEvntName.Location = new System.Drawing.Point(149, 25);
            this.lblEvntName.Name = "lblEvntName";
            this.lblEvntName.Size = new System.Drawing.Size(66, 13);
            this.lblEvntName.TabIndex = 0;
            this.lblEvntName.Text = "Event Name";
            // 
            // btnEventSearch
            // 
            this.btnEventSearch.Location = new System.Drawing.Point(673, 55);
            this.btnEventSearch.Name = "btnEventSearch";
            this.btnEventSearch.Size = new System.Drawing.Size(75, 23);
            this.btnEventSearch.TabIndex = 3;
            this.btnEventSearch.Text = "Search";
            this.btnEventSearch.UseVisualStyleBackColor = true;
            this.btnEventSearch.Click += new System.EventHandler(this.btnEventSearch_Click);
            // 
            // txtEventSearch
            // 
            this.txtEventSearch.Location = new System.Drawing.Point(500, 58);
            this.txtEventSearch.Name = "txtEventSearch";
            this.txtEventSearch.Size = new System.Drawing.Size(134, 20);
            this.txtEventSearch.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(497, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // listViewEvent
            // 
            this.listViewEvent.FullRowSelect = true;
            this.listViewEvent.GridLines = true;
            this.listViewEvent.Location = new System.Drawing.Point(25, 42);
            this.listViewEvent.Name = "listViewEvent";
            this.listViewEvent.Size = new System.Drawing.Size(403, 384);
            this.listViewEvent.TabIndex = 0;
            this.listViewEvent.UseCompatibleStateImageBehavior = false;
            this.listViewEvent.View = System.Windows.Forms.View.Details;
            this.listViewEvent.SelectedIndexChanged += new System.EventHandler(this.listViewEvent_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtSubject);
            this.tabPage2.Controls.Add(this.txtText);
            this.tabPage2.Controls.Add(this.btnSend);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(841, 457);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Email";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(212, 48);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(384, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(212, 100);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(384, 20);
            this.txtSubject.TabIndex = 2;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(212, 160);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(384, 217);
            this.txtText.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(344, 383);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(108, 46);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description";
            // 
            // txtEventDescription
            // 
            this.txtEventDescription.Location = new System.Drawing.Point(29, 135);
            this.txtEventDescription.Multiline = true;
            this.txtEventDescription.Name = "txtEventDescription";
            this.txtEventDescription.Size = new System.Drawing.Size(223, 111);
            this.txtEventDescription.TabIndex = 9;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(847, 509);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Control";
            this.ShowIcon = false;
            this.Text = "Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Control_FormClosed);
            this.Load += new System.EventHandler(this.Control_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageUsers.PerformLayout();
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.groupBoxAuthority.ResumeLayout(false);
            this.groupBoxAuthority.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grbxEvntInformation.ResumeLayout(false);
            this.grbxEvntInformation.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.GroupBox groupBoxAuthority;
        private System.Windows.Forms.RadioButton radioBtnAuthority3;
        private System.Windows.Forms.RadioButton radioBtnAuthority2;
        private System.Windows.Forms.RadioButton radioBtnAuthority1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listViewUsernames;
        private System.Windows.Forms.Label LblSearchSSN;
        private System.Windows.Forms.TextBox txtBoxSearchSSN;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPhoneNumber;
        private System.Windows.Forms.Label LblSSN;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblFullName;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.TextBox txtBoxSSN;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxFullName;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListView listViewEvent;
        private System.Windows.Forms.GroupBox grbxEvntInformation;
        private System.Windows.Forms.Label lblEvntName;
        private System.Windows.Forms.Button btnEventSearch;
        private System.Windows.Forms.TextBox txtEventSearch;
        private System.Windows.Forms.TextBox txtEventLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtEventDate;
        private System.Windows.Forms.Label lblEvntDate;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnEvntAdd;
        private System.Windows.Forms.Button btnEvntUpdate;
        private System.Windows.Forms.Button btnEvntDelete;
        private System.Windows.Forms.Button btnEvntClear;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEventDescription;
        private System.Windows.Forms.Label label4;

    }
}