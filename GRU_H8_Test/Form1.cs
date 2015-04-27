using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRU_H8_Test
{
    public partial class Login : Form
    {
        Database database = new Database();

        public Login()
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

        string username = null, password = null;

        private void BtnLogLogin_Click(object sender, EventArgs e)
        {
            username = txtBoxLogName.Text;
            password = txtBoxLogPass.Text;
            try
            {
                if (database.AdminLogin(username, password) == true)
                {
                    Control control = new Control();
                    control.Visible = true;
                    this.Visible = false;
                    control.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBoxLogName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxLogPass.Focus();
            }
        }

        private void txtBoxLogPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                username = txtBoxLogName.Text;
                password = txtBoxLogPass.Text;
                try
                {
                    if (database.AdminLogin(username, password) == true)
                    {
                        Control control = new Control();
                        control.Visible = true;
                        this.Visible = false;
                        control.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
