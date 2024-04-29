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
    public partial class ViewInvoice : Form
    {
        public ViewInvoice()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\RR Database\RREnt.mdf"";Integrated Security=True;Connect Timeout=30");
        
        private void fetchInvoiceData()
        {
            Con.Open();
            string query = " select * from PurchaseTbl where Purchase_ID = '" + Purchase_ID.Text + "' ";
            SqlCommand cmd = new SqlCommand (query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill (dt);
            foreach (DataRow dr in dt.Rows) 
            {
               PurchaseID.Text = dr["Purchase_ID"].ToString();
               CustomerName.Text = dr["Customer_Name"].ToString();
               ItemCode.Text = dr["Item_Code"].ToString();
               Quantitiy.Text = dr["Quantity"].ToString();
               BillingAddress.Text = dr["Billing_Address"].ToString();
               PurchaseDate.Text = dr["Purchase_Date"].ToString();
               TotalAmount.Text = dr["Total_Amount"].ToString();

                PurchaseID.Visible = true;
                CustomerName.Visible = true;
                ItemCode.Visible = true;
                Quantitiy.Visible = true;
                BillingAddress.Visible = true;
                PurchaseDate.Visible = true;
                TotalAmount.Visible = true;

            }
            Con.Close();
        }
        private void gunaPictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home ObjHM = new Home();
            ObjHM.Show();
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void ViewInvoice_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
           fetchInvoiceData();
        }

        private void PurchaseID_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) 
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Customer Purchased Invoice", new Font("Calibri", 20, FontStyle.Bold), Brushes.Black, new Point(250));

            e.Graphics.DrawString("Purchased ID  :   " + PurchaseID.Text, new Font("Calibri", 16, FontStyle.Bold), Brushes.Navy, new Point(100,110));
            e.Graphics.DrawString("Customer Name  :   " + CustomerName.Text, new Font("Calibri", 16, FontStyle.Bold), Brushes.Navy, new Point(100, 150));
            e.Graphics.DrawString("Item Code  :   " + ItemCode.Text, new Font("Calibri", 16, FontStyle.Bold), Brushes.Navy, new Point(100, 190));
            e.Graphics.DrawString("Quantity  :   " + Quantitiy.Text, new Font("Calibri", 16, FontStyle.Bold), Brushes.Navy, new Point(100, 230));
            e.Graphics.DrawString("Billing Address  :   " + BillingAddress.Text, new Font("Calibri", 16, FontStyle.Bold), Brushes.Navy, new Point(100, 270));
            e.Graphics.DrawString("Purchased Date  :   " + PurchaseDate.Text, new Font("Calibri", 16, FontStyle.Bold), Brushes.Navy, new Point(100, 310));
            e.Graphics.DrawString("Total Amount  :   " + TotalAmount.Text, new Font("Calibri", 16, FontStyle.Bold), Brushes.Navy, new Point(100, 350));

            e.Graphics.DrawString("@Copyrights 2023. All rights Reserved by RR Enterprises", new Font("Calibri", 14, FontStyle.Regular), Brushes.Black, new Point(180,410));
        }
    }
}
