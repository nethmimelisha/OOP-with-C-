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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\RR Database\RREnt.mdf"";Integrated Security=True;Connect Timeout=30");

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ObjLogin = new Login();
            ObjLogin.Show();
        }

        private void pichome_Click(object sender, EventArgs e)
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewInvoice ObjInv = new ViewInvoice();
            ObjInv.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Purchase_ID.Text == "" || Customer_Name.Text == "" || Item_Code.Text == "" || Quantity.Text == "" || Billing_Address.Text == "" || Total_Amount.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into PurchaseTbl values ('" + Purchase_ID.Text + "', '" + Customer_Name.Text + "','" + Item_Code.Text + "', '" + Quantity.Text + "', '" + Billing_Address.Text + "', '" + Purchase_Date.Value.Date + "' , '" + Total_Amount.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Purchased Record Added Sucessfully");
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
            string query = "select * from PurchaseTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PurchaseData.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void Invoice_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Purchase_ID.Text == "")
            {
                MessageBox.Show("Enter the Purchase_ID");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from PurchaseTbl where Purchase_ID='" + Purchase_ID.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Purchased Details Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PurchaseData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Purchase_ID.Text = PurchaseData.SelectedRows[0].Cells[0].Value.ToString();
            Customer_Name.Text = PurchaseData.SelectedRows[0].Cells[1].Value.ToString();
            Item_Code.Text = PurchaseData.SelectedRows[0].Cells[2].Value.ToString();
            Quantity.Text = PurchaseData.SelectedRows[0].Cells[3].Value.ToString();
            Billing_Address.Text = PurchaseData.SelectedRows[0].Cells[4].Value.ToString();
            Purchase_Date.Text = PurchaseData.SelectedRows[0].Cells[5].Value.ToString();
            Total_Amount.Text = PurchaseData.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Purchase_ID.Text == "" || Customer_Name.Text == "" || Item_Code.Text == "" || Quantity.Text == "" || Billing_Address.Text == "" || Total_Amount.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update PurchaseTbl set Purchase_ID = '" + Purchase_ID.Text + "', Customer_Name = '" + Customer_Name.Text + "', Item_Code = '" + Item_Code.Text + "', Quantity = '" + Quantity.Text + "', Billing_Address = '" + Billing_Address.Text + "', Purchase_Date = '" + Purchase_Date.Value.Date + "' , Total_Amount = '" + Total_Amount.Text + "' where Purchase_ID = '"+ Purchase_ID.Text +"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Purchased Record Updated Sucessfully");
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
