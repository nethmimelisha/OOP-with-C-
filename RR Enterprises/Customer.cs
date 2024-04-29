using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RR_Enterprises
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\RR Database\RREnt.mdf"";Integrated Security=True;Connect Timeout=30");

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ObjLogin = new Login();
            ObjLogin.Show();
        }

        private void CustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel12_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel11_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Customer_ID.Text == "" || Customer_Name.Text == "" || Customer_PhoneNumber.Text == "" || Customer_Address.Text == "" || Customer_Payment.SelectedItem.ToString() ==  "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into CustomerTbl values ('" + Customer_ID.Text + "', '" + Customer_Name.Text + "','" + Customer_PhoneNumber.Text + "', '" + Customer_Address.Text + "', '" + Customer_Payment.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Record Added Sucessfully");
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
            string query = "select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomerData.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Customer_ID.Text == "")
            {
                MessageBox.Show("Enter the Customer_ID");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CustomerTbl where Customer_ID='" + Customer_ID.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Details Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CustomerData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer_ID.Text = CustomerData.SelectedRows[0].Cells[0].Value.ToString();
            Customer_Name.Text = CustomerData.SelectedRows[0].Cells[1].Value.ToString();
            Customer_PhoneNumber.Text = CustomerData.SelectedRows[0].Cells[2].Value.ToString();
            Customer_Address.Text = CustomerData.SelectedRows[0].Cells[3].Value.ToString();
            Customer_Payment.Text = CustomerData.SelectedRows[0].Cells[4].Value.ToString();    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Customer_ID.Text == "" || Customer_Name.Text == "" || Customer_PhoneNumber.Text == "" || Customer_Address.Text == "" || Customer_Payment.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update CustomerTbl set Customer_ID = '" + Customer_ID.Text + "', Customer_Name = '" + Customer_Name.Text + "', Customer_PhoneNumber = '" + Customer_PhoneNumber.Text + "', Customer_Address = '" + Customer_Address.Text + "', Customer_Payment = '" + Customer_Payment.SelectedItem.ToString() + "' where Customer_ID = '"+ Customer_ID.Text +"' ;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Record Updated Sucessfully");
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
