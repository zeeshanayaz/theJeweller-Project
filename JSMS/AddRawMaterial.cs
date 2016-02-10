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
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;


namespace JSMS
{
    public partial class AddRawMaterial : Form
    {
        MainClass mc = new MainClass();
        public AddRawMaterial()
        {
            InitializeComponent();
        }
        private void AddItemButton_Click(object sender, EventArgs e)                               //Add Raw Material
        {
            mc.OpenConnection();
            if (ItemNameBox.Text != "" && ItemTypeBox.Text != "" && ItemMaterialBox.Text !="")
            {
                try
                {
                double priceOFEach = Convert.ToDouble(ItemPriceBox.Text)/Convert.ToDouble(ItemQuantityBox.Text);

                mc.SqlQuery("INSERT into Product.RawMaterialDetail(NAME,TYPE,MATERIAL,VendorID,QUANTITY,PriceOfEach,PRICE,OTHERINFO) values('" + ItemNameBox.Text + "','" + ItemTypeBox.Text + "','" + ItemMaterialBox.Text + "'," + VendorIDBox.Text + ","+ItemQuantityBox.Text+","+priceOFEach+"," + ItemPriceBox.Text + ",'" + ItemOtherInfoBox.Text + "')");
                mc.NonQueryExe();
                MessageBox.Show(ItemNameBox.Text + " Has been added in your Inventory as a Raw Material", "Congratulations");
                }
            catch(Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
                txtBoxClear();
            }
            else
            {
                MessageBox.Show("Please fill all the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mc.CloseConnection();
        }

        private void txtBoxClear()                                                                 //textbox Clear
        {
            ItemNameBox.Clear();
            ItemTypeBox.Clear();
            ItemMaterialBox.Clear();
            VendorIDBox.Clear();
            ItemQuantityBox.Clear();
            ItemPriceBox.Clear();
            ItemOtherInfoBox.Clear();
        }
    }
}
