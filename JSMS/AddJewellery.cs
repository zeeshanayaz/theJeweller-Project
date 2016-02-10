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
    public partial class AddJewellery : Form
    {
        MainClass mc = new MainClass();
        string imgloc;

        public AddJewellery()
        {
            InitializeComponent();
        }

        private void ClearAllButton_Click(object sender, EventArgs e)           //Clear Text Box Button
        {
            txtBoxClear();
        }

        private void SubmitButton_Click(object sender, EventArgs e)             //Submit Button
        {
            mc.OpenConnection();
            if (ItemStockBox.Text != "" && JewelleryTypeList.SelectedItem != null && ItemMaterialList.SelectedItem != null && JewelleryPIcBox.Image !=null)
            { 
                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);

                    string Query = "INSERT INTO Product." + JewelleryTypeList.SelectedItem + "(StockQuantity,Type,Material,Weight,Colour,Size,Picture,Price) VALUES(" + ItemStockBox.Text + ",'" + JewelleryTypeList.SelectedItem + "','" + ItemMaterialList.SelectedItem + "'," + ItemWeightBox.Text + ",'" + ItemColourBox.Text + "'," + ItemSizeBox.Text + ",@img," + ItemPriceBox.Text + ")";
                    mc.SqlQuery(Query);
                    mc.DbCommand.Parameters.Add(new SqlParameter("@img", img));
                    mc.NonQueryExe();
                    MessageBox.Show("New Jewellery Item has been added successfully", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void UploadPicButton_Click(object sender, EventArgs e)          //Uplaod Picture Button
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
       
        public void txtBoxClear()                                               //Clear Text Boxes Function
        {
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
