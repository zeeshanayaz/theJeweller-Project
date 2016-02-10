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
using System.IO;

namespace JSMS
{
    public partial class POS : Form
    {
        MainClass mc = new MainClass();
        int ItemNumber = 0;
        public POS()
        {
            InitializeComponent();
        }
        public void RefreshData()
        {
            if (MainClass.Flag == 1)
            {
                ItemBox.Text = Convert.ToString(MainClass.Item);
                StockBox.Text = Convert.ToString(MainClass.Quantity);
                JewelryTypeBox.Text = MainClass.Type;
                MaterialBox.Text = MainClass.Material;
                WeightBox.Text = Convert.ToString(MainClass.Weight);
                ColourBox.Text = MainClass.Colour;
                SizeBox.Text = Convert.ToString(MainClass.Size);
                PriceBox.Text = Convert.ToString(MainClass.Price);
                MemoryStream ms = new MemoryStream(MainClass.Img);
                PhotoBox.Image = Image.FromStream(ms);
                MainClass.Flag = 0;
                //MainClass.Images = null;
                //MainClass.item = null;
                //MainClass.quantity = null;
                //MainClass.type = null;
                //MainClass.weight = null;
                //MainClass.colour = null;
                //MainClass.price = null;
                //MainClass.size = null;
            }
        }                                                //Refreshing Entire Form

        private void SearchgainLabel_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)  //Jewellery Search Event
        {
            new JwellerySearchForm().ShowDialog();
            this.RefreshData();
            if (MainClass.checkForPOS == 1)
            {
                new ItemsDisplayList().ShowDialog();
                this.RefreshData();
            }
        }

        
        
        
        private void customJobToolStripMenuItem_Click(object sender, EventArgs e)       //Custom Job
        {
            new CustomJob().Show();
        }

        private void repairJobToolStripMenuItem_Click(object sender, EventArgs e)       //Repair Job
        {
            new RepairJob().Show();
        }

        private void checkInventoryToolStripMenuItem_Click(object sender, EventArgs e)      //Check Inventory
        {
            new CheckInventory().Show();
        }
                
        private void addToolStripMenuItem_Click(object sender, EventArgs e)     //Add Raw material
        {
            new AddRawMaterial().Show();
        }
        
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)        //Check Customer
        {
            new CheckCustomer().Show();
        }

        private void checkVendorToolStripMenuItem_Click(object sender, EventArgs e)     //Check Vendor
        {
            new CheckVendor().Show();
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)       //Check Status
        {
            new CheckStatus().Show();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)     //Update Status
        {
            new UpdateStatus().Show();
        }

        private void addVendorToolStripMenuItem_Click(object sender, EventArgs e)       //Add Vendor
        {
            new AddVendor().Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)         //update Vendor
        {
            new UpdateVendor().Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)          //Update Raw Material
        {
            new UpdateRawMaterial().Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)     //Exit Application
        {
            Application.Exit();
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)     //SignOut
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void addToolStripMenuItem1_Click_1(object sender, EventArgs e)      //Add Jewellery List
        {
            new AddJewellery().Show();
        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)     //Update Jewellery List
        {
            new UpdateJewellery().Show();
        }

        private void NextPicButton_Click(object sender, EventArgs e)            //Next Button
        {
            try
            {
                do
                {
                    mc.OpenConnection();
                    ItemNumber = Convert.ToInt32(ItemBox.Text);
                    ++ItemNumber;
                    mc.SqlQuery("Select * From Product." + JewelryTypeBox.Text + " where Item# = " + ItemNumber + "");
                    SqlDataReader sr = mc.DbCommand.ExecuteReader();
                    sr.Read();
                    if (sr.HasRows)
                    {
                        ItemBox.Text = Convert.ToString(sr[0].ToString());
                        StockBox.Text = Convert.ToString(sr[1].ToString());
                        JewelryTypeBox.Text = sr[2].ToString();
                        MaterialBox.Text = sr[3].ToString();
                        WeightBox.Text = Convert.ToString(sr[4].ToString());
                        ColourBox.Text = sr[5].ToString();
                        SizeBox.Text = Convert.ToString(sr[6].ToString());
                        MemoryStream ms = new MemoryStream((byte[])(sr[7]));
                        PhotoBox.Image = Image.FromStream(ms);
                        PriceBox.Text = Convert.ToString(sr[8].ToString());
                        mc.CloseConnection();
                        sr.Close();
                    }
                    else
                    {
                        mc.CloseConnection();
                        MessageBox.Show("Reached End OF List!");
                    }
                } while (ItemNumber == (ItemNumber + 1));
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void BackPicButton_Click(object sender, EventArgs e)        //Back Button
        {
            try
            {
                if (ItemNumber > 0)
                {
                    do
                    {
                        mc.OpenConnection();
                        ItemNumber = Convert.ToInt32(ItemBox.Text);
                        --ItemNumber;
                        mc.SqlQuery("Select * From Product." + JewelryTypeBox.Text + " where Item# = " + ItemNumber + "");
                        SqlDataReader sr = mc.DbCommand.ExecuteReader();
                        sr.Read();
                        if (sr.HasRows)
                        {
                            ItemBox.Text = Convert.ToString(sr[0].ToString());
                            StockBox.Text = Convert.ToString(sr[1].ToString());
                            JewelryTypeBox.Text = sr[2].ToString();
                            MaterialBox.Text = sr[3].ToString();
                            WeightBox.Text = Convert.ToString(sr[4].ToString());
                            ColourBox.Text = sr[5].ToString();
                            SizeBox.Text = Convert.ToString(sr[6].ToString());
                            MemoryStream ms = new MemoryStream((byte[])(sr[7]));
                            PhotoBox.Image = Image.FromStream(ms);
                            PriceBox.Text = Convert.ToString(sr[8].ToString());
                            mc.CloseConnection();
                            sr.Close();
                        }
                        else
                        {
                            mc.CloseConnection();
                            MessageBox.Show("Reached Top OF List!");
                        }
                    } while (ItemNumber == (ItemNumber - 1));
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void AddToInvoiceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                mc.OpenConnection();
                if (AddToInvoiceCheckBox.Checked == true)
                {


                    byte[] img = MainClass.Img;


                    string invoicequery = "Insert Into Customer.Temp_Invoice (Item#,Type,Material,Weight,Colour,Size,Price,Picture) Values(" + ItemBox.Text + ",'" + JewelryTypeBox.Text + "','" + MaterialBox.Text + "'," + WeightBox.Text + ",'" + ColourBox.Text + "'," + SizeBox.Text + "," + PriceBox.Text + ",@img)";
                    mc.SqlQuery(invoicequery);
                    mc.DbCommand.Parameters.Add(new SqlParameter("@img", img));
                    mc.NonQueryExe();
                    MessageBox.Show("Item Successfully Added To Invoice List.","Invoice INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    AddToInvoiceCheckBox.Checked = false;
                    mc.CloseConnection();
                }
            }
            catch (Exception exp)
            {
                mc.CloseConnection();
                MessageBox.Show(exp.Message);
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            new ItemList().Show();
        }

        private void newsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewsForm().Show();
        }

        private void developersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Developor().Show();
        }

        private void aboutTheJewellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutTheJeweller().Show();
        }

    }
}
