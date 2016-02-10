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
    public partial class JwellerySearchForm : Form
    {
        public JwellerySearchForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)             //Search Button
        {
            {
                MainClass mc = new MainClass();
                mc.OpenConnection();
                try
                {
                    if (JewelleryTypeList.SelectedItem != null && MaterialList.SelectedItem != null && ItemBox.Text != "")
                    {
                        MessageBox.Show("Please Select Only Two Fields At Once!");
                    }
                    else if (JewelleryTypeList.SelectedItem != null && MaterialList.SelectedItem != null && ItemBox.Text == "")
                    {
                        mc.SqlQuery("Select * From Product." + JewelleryTypeList.SelectedItem + " where Material = '" + MaterialList.SelectedItem + "'");
                        SqlDataReader sdr = mc.DbCommand.ExecuteReader();
                        while (sdr.Read())
                        {
                            MainClass.item.Add(Convert.ToInt32(sdr[0].ToString()));
                            MainClass.quantity.Add(Convert.ToInt32(sdr[1].ToString()));
                            MainClass.type.Add(sdr[2].ToString());
                            MainClass.material.Add(sdr[3].ToString());
                            MainClass.weight.Add(Convert.ToDecimal(sdr[4].ToString()));
                            MainClass.colour.Add(sdr[5].ToString());
                            MainClass.size.Add(Convert.ToDecimal(sdr[6].ToString()));
                            MainClass.price.Add(Convert.ToDecimal(sdr[8].ToString()));
                            MainClass.Img = (byte[])(sdr[7]);
                            MainClass.Images.Add(MainClass.Img);
                            ++MainClass.Flag;
                        }
                        MainClass.checkForPOS = 1;
                        this.Hide();
                        mc.CloseConnection();
                        sdr.Close();
                    }
                    else if (JewelleryTypeList.SelectedItem != null && ItemBox.Text != null)
                    {
                        try
                        {
                            mc.SqlQuery("Select * From Product." + JewelleryTypeList.SelectedItem + " where Item# = " + ItemBox.Text + "");
                            SqlDataReader sr = mc.DbCommand.ExecuteReader();
                            sr.Read();
                            if (sr.HasRows)
                            {
                                MainClass.Item = Convert.ToInt32(sr[0].ToString());
                                MainClass.Quantity = Convert.ToInt32(sr[1].ToString());
                                MainClass.Type = sr[2].ToString();
                                MainClass.Material = sr[3].ToString();
                                MainClass.Weight = Convert.ToDecimal(sr[4].ToString());
                                MainClass.Colour = sr[5].ToString();
                                MainClass.Size = Convert.ToDecimal(sr[6].ToString());
                                MainClass.Img = (byte[])(sr[7]);
                                MainClass.Price = Convert.ToDecimal(sr[8].ToString());
                                MainClass.Flag = 1;
                                mc.CloseConnection();
                                sr.Close();
                                this.Close();
                            }
                            else
                            {
                                mc.CloseConnection();
                                MessageBox.Show("This item does not exit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please insert data to search!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mc.CloseConnection();
                    }
                }
                catch (Exception exp)
                {
                    mc.CloseConnection();
                    MessageBox.Show(exp.Message);
                }
            }
        }
    }
}
