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
using System.Data.Sql;


namespace JSMS
{
    public partial class CheckCustomer : Form
    {
        MainClass mc = new MainClass();
        public CheckCustomer()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)          //Check Customer Details
        {
            mc.OpenConnection();
            try
            {
                if (CustomerSearchList.SelectedItem == "All")
                {
                    mc.SqlQuery("SELECT * FROM Customer.CustomerDetail");
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(mc.DbCommand);
                    adp.Fill(dt);
                    CustomerTable.DataSource = dt;
                }
                else if (CustomerSearchList.SelectedItem == "Name")
                {
                    mc.SqlQuery("SELECT * FROM Customer.CustomerDetail where CustomerName = '" + SearchInputBox.Text + "'");
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(mc.DbCommand);
                    adp.Fill(dt);
                    CustomerTable.DataSource = dt;
                }
                else if (CustomerSearchList.SelectedItem == "Contact #")
                {
                    mc.SqlQuery("SELECT * FROM Customer.CustomerDetail where ContactNo = " + SearchInputBox.Text );
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(mc.DbCommand);
                    adp.Fill(dt);
                    CustomerTable.DataSource = dt;
                }
                else if (CustomerSearchList.SelectedItem == "Invoice #")
                {
                    mc.SqlQuery("SELECT * FROM Customer.CustomerDetail where InvoiceNo = " + SearchInputBox.Text);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(mc.DbCommand);
                    adp.Fill(dt);
                    CustomerTable.DataSource = dt;
                }
                SearchInputBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mc.CloseConnection();
        }
    }
}
