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
    public partial class Employee : Form
    {
        public Employee()
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

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

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

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (Employee_ID.Text == "" || Employee_Name.Text == "" || Employee_PhoneNumber.Text == "" || Employee_Address.Text == "" || Employee_Salary.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into EmployeeTbl values ('" + Employee_ID.Text + "', '" + Employee_Name.Text + "','" + Employee_PhoneNumber.Text + "', '" + Employee_Address.Text + "', '" + Employee_JoinDate.Value.Date + "' , '" + Employee_Salary.Text +"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Record Added Sucessfully");
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
            string query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmployeeData.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (Employee_ID.Text == "")
            {
                MessageBox.Show("Enter the Employee_ID");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from EmployeeTbl where Employee_ID='" + Employee_ID.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Details Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EmployeeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee_ID.Text = EmployeeData.SelectedRows[0].Cells[0].Value.ToString();
            Employee_Name.Text = EmployeeData.SelectedRows[0].Cells[1].Value.ToString();
            Employee_PhoneNumber.Text = EmployeeData.SelectedRows[0].Cells[2].Value.ToString();
            Employee_Address.Text = EmployeeData.SelectedRows[0].Cells[3].Value.ToString();
            Employee_JoinDate.Text = EmployeeData.SelectedRows[0].Cells[4].Value.ToString();
            Employee_Salary.Text = EmployeeData.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (Employee_ID.Text == "" || Employee_Name.Text == "" || Employee_PhoneNumber.Text == "" || Employee_Address.Text == "" || Employee_Salary.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update EmployeeTbl set Employee_ID = '" + Employee_ID.Text + "', Employee_Name = '" + Employee_Name.Text + "', Employee_PhoneNumber = '" + Employee_PhoneNumber.Text + "', Employee_Address = '" + Employee_Address.Text + "', Employee_JoinDate = '" + Employee_JoinDate.Value.Date + "' , Employee_Salary = '" + Employee_Salary.Text + "' where Employee_ID = '"+ Employee_ID.Text +"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Record Updated Sucessfully");
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
