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
using System.Data.Sql;
using System.Data.SqlClient;


namespace JSMS
{
    public partial class CustomJob : Form
    {
        MainClass mc = new MainClass();
        string imgloc;
        public CustomJob()
        {
            InitializeComponent();
        }

        private void UploadPicButton_Click(object sender, EventArgs e)              //Upload Picture
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Jewellery Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                    ItemPicBox.ImageLocation = imgloc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SubmitJobButton_Click(object sender, EventArgs e)              //Submit Button
        {
            mc.OpenConnection();
            if (MaterialList.SelectedItem != null && ItemPicBox.Image != null && JewelleryTypeList.SelectedItem != null)
            {
                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);

                    string Query = "INSERT INTO Services.CustomJob(Material,Weight,Size,Type,Status,Requirement,Image) VALUES('" + MaterialList.SelectedItem + "'," + WeightBox.Text + "," + SizeBox.Text + ",'" + JewelleryTypeList.SelectedItem + "','"+StatusBox.Text+"','" + Requirements.Text + "',@img)";
                    mc.SqlQuery(Query);
                    mc.DbCommand.Parameters.Add(new SqlParameter("@img", img));
                    mc.NonQueryExe();
                    MessageBox.Show("New Job has been added successfully", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
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

        private void ClearAllButton_Click(object sender, EventArgs e)               //Text Boxes Clear Buttton
        {
            txtBoxClear();
        }
        
        public void txtBoxClear()                                                   //Clear Text Boxes function
        {
            JobIDBox.Clear();
            MaterialList.SelectedItem = null;
            WeightBox.Clear();
            SizeBox.Clear();
            JewelleryTypeList.SelectedItem = null;
            StatusBox.Clear();
            Requirements.Clear();
            ItemPicBox.Image = null;
        }
    }
}
