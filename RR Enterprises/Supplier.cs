using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RR_Enterprises
{
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\RR Database\RREnt.mdf"";Integrated Security=True;Connect Timeout=30");

        private void gunaLabel13_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ObjLogin = new Login();
            ObjLogin.Show();
        }

        private void gunaPictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home ObjHome = new Home();
            ObjHome.Show();
        }

        private void piccustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer ObjCustomer = new Customer();
            ObjCustomer.Show();
        }

        private void picitems_Click(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Supplier_ID.Text == "" || Supplier_Name.Text == "" || Supplier_PhoneNumber.Text == "" || Supplier_Address.Text == "" || Supplier_Payment.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into SupplierTbl values ('" + Supplier_ID.Text + "', '" + Supplier_Name.Text + "','" + Supplier_PhoneNumber.Text + "', '" + Supplier_Address.Text + "', '" + Supplier_Payment.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Supplier Record Added Sucessfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from SupplierTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SupplierData.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Supplier_ID.Text == "")
            {
                MessageBox.Show("Enter the Supplier_ID");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from SupplierTbl where Supplier_ID='" + Supplier_ID.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Supplier Details Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void SupplierData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Supplier_ID.Text = SupplierData.SelectedRows[0].Cells[0].Value.ToString();
            Supplier_Name.Text = SupplierData.SelectedRows[0].Cells[1].Value.ToString();
            Supplier_PhoneNumber.Text = SupplierData.SelectedRows[0].Cells[2].Value.ToString();
            Supplier_Address.Text = SupplierData.SelectedRows[0].Cells[3].Value.ToString();
            Supplier_Payment.Text = SupplierData.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Supplier_ID.Text == "" || Supplier_Name.Text == "" || Supplier_PhoneNumber.Text == "" || Supplier_Address.Text == "" || Supplier_Payment.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update SupplierTbl set Supplier_ID = '" + Supplier_ID.Text + "', Supplier_Name = '" + Supplier_Name.Text + "', Supplier_PhoneNumber = '" + Supplier_PhoneNumber.Text + "', Supplier_Address = '" + Supplier_Address.Text + "', Supplier_Payment = '" + Supplier_Payment.SelectedItem.ToString() + "' where Supplier_ID = '" + Supplier_ID.Text + "' ;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Supplier Record Updated Sucessfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
    }
}
