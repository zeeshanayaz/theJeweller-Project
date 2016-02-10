using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;


namespace JSMS
{
    public partial class UpdateJewellery : Form
    {
        MainClass mc = new MainClass();
        string imgloc;

        public UpdateJewellery()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)                 //Update Jewellery Item
        {
            mc.OpenConnection();
            try 
            {
                if (ItemNoBox.Text == "")
                {
                    MessageBox.Show("Please Enter Jewellery item # to update the details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ItemNoBox.Text != "" && JewelleryPIcBox.Image == null)
                {
                    string updateQuery = "Update Product." + JewelleryTypeList.SelectedItem + " Set StockQuantity = " + ItemStockBox.Text + ", Type = '" + JewelleryTypeList.SelectedItem + "', Material = '" + ItemMaterialList.SelectedItem + "', Weight = " + ItemWeightBox.Text + ", Colour = '" + ItemColourBox.Text + "',Size = " + ItemSizeBox.Text + ", Price = " + ItemPriceBox.Text + " where Item# = "+ItemNoBox.Text;
                    mc.SqlQuery(updateQuery);
                }
                else if (ItemNoBox.Text != "" && JewelleryPIcBox.Image != null)
                {
                    string updateQuery = "Update Product." + JewelleryTypeList.SelectedItem + " Set StockQuantity = " + ItemStockBox.Text + ", Type = '" + JewelleryTypeList.SelectedItem + "', Material = '" + ItemMaterialList.SelectedItem + "', Weight = " + ItemWeightBox.Text + ", Colour = '" + ItemColourBox.Text + "',Size = " + ItemSizeBox.Text + ", Price = " + ItemPriceBox.Text + ", Picture = @img Where Item# = "+ItemNoBox.Text;
                    byte[] img = null;
                    FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    
                    mc.SqlQuery(updateQuery);
                    mc.DbCommand.Parameters.Add(new SqlParameter("@img", img));
                }
                mc.NonQueryExe();
                MessageBox.Show("Details has been updated successfully", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mc.CloseConnection();
        }

        private void UploadPicButton_Click(object sender, EventArgs e)              //Upload Picture Button
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                    JewelleryPIcBox.ImageLocation = imgloc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearAllButton_Click(object sender, EventArgs e)               //Clear all Text Box Button
        {
            txtBoxClear();
        }

        public void txtBoxClear()                                                   //Clear Text Boxes Function
        {
            ItemNoBox.Clear();
            ItemStockBox.Clear();
            JewelleryTypeList.SelectedItem = null;
            ItemMaterialList.SelectedItem = null;
            ItemWeightBox.Clear();
            ItemSizeBox.Clear();
            ItemColourBox.Clear();
            ItemPriceBox.Clear();
            JewelleryPIcBox.Image = null;
        }
    }
}
