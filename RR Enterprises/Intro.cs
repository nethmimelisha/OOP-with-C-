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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void btncontinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
}
