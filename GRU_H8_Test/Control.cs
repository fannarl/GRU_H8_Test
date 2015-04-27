using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace GRU_H8_Test
{
    public partial class Control : Form
    {
        Database database = new Database();
        int ID = 0;

        public Control()
        {
            InitializeComponent();

            try
            {
                database.DbCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Visible = true;
            this.Visible = false;
            form.Focus();
        }

        private void Control_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void refresh()
        {
            listViewUsernames.Clear();
            listViewUsernames.Columns.Add("ID", 40);
            listViewUsernames.Columns.Add("Social security number", 120);
            listViewUsernames.Columns.Add("Name", 180);
            listViewUsernames.Columns.Add("Email", 180);
            listViewUsernames.Columns.Add("Phone", 80);
            listViewUsernames.Columns.Add("Authority", 60);
            listViewUsernames.Columns.Add("Username", 100);
            listViewUsernames.Columns.Add("Password", 100);
            List<string> lines = new List<string>();
            string[] arr = new string[8];
            ListViewItem itm;

            try
            {
                lines = database.ReadSQLUserTable();

                foreach (string line in lines)
                {
                    string[] lineFromList = line.Split('╪');
                    string ID = lineFromList[0];
                    string SSN = lineFromList[1];
                    string name = lineFromList[2];
                    string email = lineFromList[3];
                    string phone = lineFromList[4];
                    string authority = lineFromList[5];
                    string user = lineFromList[6];
                    string pass = lineFromList[7];
                    arr[0] = ID;
                    arr[1] = SSN;
                    arr[2] = name;
                    arr[3] = email;
                    arr[4] = phone;
                    arr[5] = authority;
                    arr[6] = user;
                    arr[7] = pass;
                    itm = new ListViewItem(arr);
                    listViewUsernames.Items.Add(itm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void EventRefresh()
        {
            listViewEvent.Clear();
            listViewEvent.Columns.Add("ID", 40);
            listViewEvent.Columns.Add("Name", 180);
            listViewEvent.Columns.Add("Date", 80);
            listViewEvent.Columns.Add("Location", 100);
            listViewEvent.Columns.Add("Description", 200);
            List<string> lines = new List<string>();
            string[] arr = new string[6];
            ListViewItem itm;

            try
            {
                lines = database.ReadSQLEventTable();

                foreach (string line in lines)
                {
                    string[] lineFromList = line.Split('╪');
                    string ID = lineFromList[0];
                    string name = lineFromList[1];
                    string date = lineFromList[2];
                    string location = lineFromList[3];
                    string description = lineFromList[4];
                    arr[0] = ID;
                    arr[1] = name;
                    arr[2] = date;
                    arr[3] = location;
                    arr[4] = description;
                    itm = new ListViewItem(arr);
                    listViewEvent.Items.Add(itm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //`Social_security_number`, `Name`, `Email`, `Phone`, `Authority`, `Username`, `Password`
            refresh();
            txtBoxEmail.Clear();
            txtBoxFullName.Clear();
            txtBoxPassword.Clear();
            txtBoxPhoneNumber.Clear();
            txtBoxSearchSSN.Clear();
            txtBoxSSN.Clear();
            txtBoxUsername.Clear();
            radioBtnAuthority1.Checked = true;
        }

        private void Control_Load(object sender, EventArgs e)
        {
            refresh();
            EventRefresh();
        }

        private void listViewUsernames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUsernames.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intSelectIndex = listViewUsernames.SelectedIndices[0];
            if (intSelectIndex >= 0)
            {
                ID = Convert.ToInt32(listViewUsernames.SelectedItems[0].SubItems[0].Text);
                string SSN = listViewUsernames.SelectedItems[0].SubItems[1].Text;
                string name = listViewUsernames.SelectedItems[0].SubItems[2].Text;
                string email = listViewUsernames.SelectedItems[0].SubItems[3].Text;
                string phone = listViewUsernames.SelectedItems[0].SubItems[4].Text;
                string authority = listViewUsernames.SelectedItems[0].SubItems[5].Text;
                string user = listViewUsernames.SelectedItems[0].SubItems[6].Text;
                string pass = listViewUsernames.SelectedItems[0].SubItems[7].Text;
                txtBoxSSN.Text = SSN;
                txtBoxFullName.Text = name;
                txtBoxEmail.Text = email;
                txtBoxPhoneNumber.Text = phone;
                txtBoxUsername.Text = user;
                txtBoxPassword.Text = pass;
                int SecurityClearance = Convert.ToInt32(authority);
                if (SecurityClearance == 1)
                {
                    radioBtnAuthority1.Checked = true;
                }
                else if (SecurityClearance == 2)
                {
                    radioBtnAuthority2.Checked = true;
                }
                else if (SecurityClearance == 3)
                {
                    radioBtnAuthority3.Checked = true;
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string ssn = txtBoxSearchSSN.Text;
            string[] SecurityNumber = database.FindUser(ssn);
            ID = Convert.ToInt32(SecurityNumber[0]);
            string SSN = SecurityNumber[1];
            string name = SecurityNumber[2];
            string email = SecurityNumber[3];
            string phone = SecurityNumber[4];
            int authority = Convert.ToInt32(SecurityNumber[5]);
            string user = SecurityNumber[6];
            string pass = SecurityNumber[7];
            txtBoxSSN.Text = SSN;
            txtBoxFullName.Text = name;
            txtBoxEmail.Text = email;
            txtBoxPhoneNumber.Text = phone;
            txtBoxUsername.Text = user;
            txtBoxPassword.Text = pass;
            if (authority == 1)
            {
                radioBtnAuthority1.Checked = true;
            }
            else if (authority == 2)
            {
                radioBtnAuthority2.Checked = true;
            }
            else if (authority == 3)
            {
                radioBtnAuthority3.Checked = true;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            if (txtBoxSSN.TextLength == 10)
            {
                string ssn = txtBoxSSN.Text;
                string name = txtBoxFullName.Text;
                string email = txtBoxEmail.Text;
                string phone = txtBoxPhoneNumber.Text;
                int authority = 0;
                string user = txtBoxUsername.Text;
                string pass = txtBoxPassword.Text;
                if (radioBtnAuthority1.Checked == true)
                {
                    authority = 1;
                }
                else if (radioBtnAuthority2.Checked == true)
                {
                    authority = 2;
                }
                else if (radioBtnAuthority3.Checked == true)
                {
                    authority = 3;
                }
                database.PutIntoSQLUserTable(ssn, name, email, phone, authority, user, pass);
            }
            refresh();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                string ssn = txtBoxSSN.Text;
                string name = txtBoxFullName.Text;
                string email = txtBoxEmail.Text;
                string phone = txtBoxPhoneNumber.Text;
                int authority = 0;
                string user = txtBoxUsername.Text;
                string pass = txtBoxPassword.Text;
                if (radioBtnAuthority1.Checked == true)
                {
                    authority = 1;
                }
                else if (radioBtnAuthority2.Checked == true)
                {
                    authority = 2;
                }
                else if (radioBtnAuthority3.Checked == true)
                {
                    authority = 3;
                }
                if (name.Length > 0)
                {
                    if (email.Length > 0)
                    {
                        if (user.Length > 0)
                        {
                            if (pass.Length > 0)
                            {
                                database.UpdateUser(ID, ssn, name, email, phone, authority, user, pass);
                            }
                        }
                    }
                }
            }
            refresh();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string ssn = txtBoxSSN.Text;
            database.DeleteUser(ssn);
            refresh();
        }

        private void listViewEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEvent.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intSelectIndex = listViewEvent.SelectedIndices[0];
            if (intSelectIndex >= 0)
            {
                string ID = listViewEvent.SelectedItems[0].SubItems[0].Text;
                string name = listViewEvent.SelectedItems[0].SubItems[1].Text;
                string date = listViewEvent.SelectedItems[0].SubItems[2].Text;
                string location = listViewEvent.SelectedItems[0].SubItems[3].Text;
                string description = listViewEvent.SelectedItems[0].SubItems[4].Text;
                txtEventName.Text = name;
                txtEventDate.Text = date;
                txtEventLocation.Text = location;
                txtEventID.Text = ID;
                txtEventDescription.Text = description;
            }
        }

        private void btnEventSearch_Click(object sender, EventArgs e)
        {
            string name = txtEventSearch.Text;
            string[] EventName = database.FindEvent(name);
            string ID = EventName[0];
            string Name = EventName[1];
            string date = EventName[2];
            string location = EventName[3];
            txtEventName.Text = name;
            txtEventDate.Text = date;
            txtEventLocation.Text = location;
            txtEventID.Text = ID;

        }

        private void btnEvntAdd_Click(object sender, EventArgs e)
        {
            string name = txtEventName.Text;
            string date = txtEventDate.Text;
            string location = txtEventLocation.Text;
            string description = txtEventDescription.Text;

            database.PutIntoSQLEventTable(name, date, location, description);
            
            EventRefresh();
        }

        private void btnEvntUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtEventID.Text);
            if (id > 0)
            {                
                string name = txtEventName.Text;
                string date = txtEventDate.Text;
                string location = txtEventLocation.Text;
                string description = txtEventDescription.Text;
                if (name.Length > 0)
                {
                    if (date.Length > 0)
                    {
                        if (location.Length > 0)
                        {
                            if (description.Length > 0)
                            {
                                database.UpdateEvent(id, name, date, location, description);   
                            }
                        }
                    }
                }
            }
            EventRefresh();
        }

        private void btnEvntDelete_Click(object sender, EventArgs e)
        {
            string id = txtEventID.Text;
            database.DeleteEvent(id);
            EventRefresh();
        }

        private void btnEvntClear_Click(object sender, EventArgs e)
        {
            EventRefresh();
            txtEventName.Clear();
            txtEventDate.Clear();
            txtEventLocation.Clear();
            txtEventID.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient("webmail.gmail.com");
            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("andri.lorenz@gmail.com");
            String Mailbox = txtEmail.Text.Trim();
            Message.To.Add(Mailbox);
            Message.Body = txtText.Text;
            Message.Subject = txtSubject.Text;
            client.Credentials = new System.Net.NetworkCredential("andri.lorenz@gmail.com", "mammamin1");
            client.Port = System.Convert.ToInt32(15);

            client.Send(Message);


        }
    }
}
