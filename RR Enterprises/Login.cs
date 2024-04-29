using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RR_Enterprises
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            {
                string username = txtun.Text;
                string password = txtpw.Text;
                if (username == "Admin" && password == "admin123")
                {
                    Home objhm = new Home();
                    this.Hide();
                    objhm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
