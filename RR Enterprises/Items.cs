using System;
using System.Collections;
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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\RR Database\RREnt.mdf"";Integrated Security=True;Connect Timeout=30");

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Item_ID.Text == "" || Item_Name.Text == "" || Item_Description.Text == "" || Supplier_ID.SelectedItem.ToString() == "" || Quantity.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into ItemTbl values ('" + Item_ID.Text + "', '" + Item_Name.Text + "','" + Item_Description.Text + "', '" + Supplier_ID.SelectedItem.ToString() + "', '" + Quantity.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Record Added Sucessfully");
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
            string query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemData.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Item_ID.Text == "")
            {
                MessageBox.Show("Enter the Item_ID");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from ItemTbl where Item_ID='" + Item_ID.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Details Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ItemData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Item_ID.Text = ItemData.SelectedRows[0].Cells[0].Value.ToString();
            Item_Name.Text = ItemData.SelectedRows[0].Cells[1].Value.ToString();
            Item_Description.Text = ItemData.SelectedRows[0].Cells[2].Value.ToString();
            Supplier_ID.Text = ItemData.SelectedRows[0].Cells[3].Value.ToString();
            Quantity.Text = ItemData.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Item_ID.Text == "" || Item_Name.Text == "" || Item_Description.Text == "" || Supplier_ID.SelectedItem.ToString() == "" || Quantity.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update ItemTbl set Item_ID = '" + Item_ID.Text + "', Item_Name = '" + Item_Name.Text + "', Item_Description = '" + Item_Description.Text + "', Supplier_ID = '" + Supplier_ID.SelectedItem.ToString() + "', Quantity = '" + Quantity.Text + "'  where Item_ID = '"+ Item_ID.Text +"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Record Updated Sucessfully");
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
