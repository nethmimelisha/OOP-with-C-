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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void piccustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer ObjCust = new Customer();
            ObjCust.Show();
        }

        private void picitem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Items ObjItem = new Items();
            ObjItem.Show();
        }

        private void picsupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier ObjSup = new Supplier();
            ObjSup.Show();
        }

        private void picemployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee ObjEmp = new Employee();
            ObjEmp.Show();
        }

        private void picinvoice_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invoice ObjInvoice = new Invoice();
            ObjInvoice.Show();
        }

        private void picreport_Click(object sender, EventArgs e)
        {
                    }
    }
}
