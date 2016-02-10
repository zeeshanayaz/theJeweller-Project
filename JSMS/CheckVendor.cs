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
    public partial class CheckVendor : Form
    {
        MainClass mc = new MainClass();
        public CheckVendor()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)                                      //Check Vendor
        {
            mc.OpenConnection();
            try
            {
                if (VendorSearchByList.SelectedItem == "All")
                {
                    mc.SqlQuery("SELECT * FROM Vendor.VendorDetail");
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(mc.DbCommand);
                    adp.Fill(dt);
                    VendorTable.DataSource = dt;

                }
                else if (VendorSearchByList.SelectedItem == "Name")
                {
                    mc.SqlQuery("SELECT * FROM Vendor.VendorDetail where VendorName = '" + SearchInputBox.Text + "'");
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(mc.DbCommand);
                    adp.Fill(dt);
                    VendorTable.DataSource = dt;
                }
                else if (VendorSearchByList.SelectedItem == "Contact Number")
                {
                    mc.SqlQuery("SELECT * FROM Vendor.VendorDetail where ContactNo = '" + SearchInputBox.Text + "'");
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(mc.DbCommand);
                    adp.Fill(dt);
                    VendorTable.DataSource = dt;
                }
                else if (VendorSearchByList.SelectedItem == "ID")
                {
                    mc.SqlQuery("SELECT * FROM Vendor.VendorDetail where VendorID = '" + SearchInputBox.Text + "'");
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(mc.DbCommand);
                    adp.Fill(dt);
                    VendorTable.DataSource = dt;
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
