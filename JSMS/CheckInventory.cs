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

namespace JSMS
{
    public partial class CheckInventory : Form
    {
        MainClass mc = new MainClass();
        public CheckInventory()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)                          //Check Inventory Button
        {
            mc.OpenConnection();
            try
            {
                if (JewelleryTypeList.SelectedItem == null)
                {
                    MessageBox.Show("Please select a keyword to search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (JewelleryTypeList.SelectedItem == "All")
                    {
                        string allquery = "Select * from Product.CompleteSet union All Select * from Product.Earings Union All Select * from Product.MenWatches Union All Select * from Product.Necklace Union All Select * from Product.Rings Union All Select * from Product.FemaleWatches Union All Select * from Product.Bangles Union All Select * from Product.Bracelets Order By Material";
                        mc.SqlQuery(allquery);
                        DataTable dt = new DataTable();
                        SqlDataAdapter adp = new SqlDataAdapter(mc.DbCommand);
                        adp.Fill(dt);
                        InventoryTable.DataSource = dt;
                    }
                    else
                    {
                        mc.SqlQuery("SELECT * FROM Product." + JewelleryTypeList.SelectedItem);
                        DataTable dt = new DataTable();
                        SqlDataAdapter adp = new SqlDataAdapter(mc.DbCommand);
                        adp.Fill(dt);
                        InventoryTable.DataSource = dt;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mc.CloseConnection();
        }
    
    }
}
