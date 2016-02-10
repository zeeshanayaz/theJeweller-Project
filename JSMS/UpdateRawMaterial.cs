using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;


namespace JSMS
{
    public partial class UpdateRawMaterial : Form
    {
        MainClass mc = new MainClass();
        public UpdateRawMaterial()
        {
            InitializeComponent();
        }

        private void UpdateItemButton_Click(object sender, EventArgs e)            //Update Raw Material
        {
            mc.OpenConnection();
            try
            {
                if (ItemBox.Text == "")
                    {
                        MessageBox.Show("Please enter some ITEM # to Update Raw Material","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                else
                    {
                    mc.SqlQuery("Select * from Product.RawMaterialDetail Where ITEM# = " + ItemBox.Text);
                    mc.DtAdapter = new SqlDataAdapter(mc.DbCommand);
                    mc.SqlTable = new DataTable();
                    mc.DtAdapter.Fill(mc.SqlTable);
                    if(mc.SqlTable.Rows.Count > 0)
                        {
                            double priceOFEach = Convert.ToDouble(ItemPriceBox.Text) / Convert.ToDouble(ItemQuantityBox.Text);
                            string UpdateQuery = "UPDATE Product.RawMaterialDetail SET NAME = '" + ItemNameBox.Text + "',TYPE = '" + ItemTypeBox.Text + "',MATERIAL = '" + ItemMaterialBox.Text + "',VendorID = " + VendorIDBox.Text + ",QUANTITY = " + ItemQuantityBox.Text + ",PriceOfEach = " + priceOFEach + ",Price = " + ItemPriceBox.Text + ", OtherInfo = '" + ItemOtherInfoBox.Text + "' Where ITEM# = " + ItemBox.Text;
                            mc.SqlQuery(UpdateQuery);
                            mc.NonQueryExe();
                            MessageBox.Show("Details has been updated successfully", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    else
                        {
                        MessageBox.Show("Raw material with item # "+ItemBox.Text+" Does not exist","Sorry",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        }
                    TextBoxesClear();
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            mc.CloseConnection();
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)             //Delete Raw Material
        {
            mc.OpenConnection();
            string DeleteQuery = "DELETE FROM Product.RawMaterialDetail WHERE ITEM# = "+ItemBox.Text;
            try
            {
                if (ItemBox.Text == "")
                {
                    MessageBox.Show("Please enter some id # to delete Raw Material","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    mc.SqlQuery(DeleteQuery);
                    mc.NonQueryExe();
                    MessageBox.Show("Raw Material with Item # " + ItemBox.Text + " has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ItemBox.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mc.CloseConnection();
        }

        public void TextBoxesClear()                        //Clear text box Function
        {
            ItemBox.Clear();
            ItemNameBox.Clear();
            ItemTypeBox.Clear();
            ItemMaterialBox.Clear();
            VendorIDBox.Clear();
            ItemQuantityBox.Clear();
            ItemPriceBox.Clear();
        }
    }
}
