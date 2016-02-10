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
    public partial class AddVendor : Form
    {
        MainClass mc = new MainClass();
        string imgloc;
        public AddVendor()
        {
            InitializeComponent();
        }
        
        private void UploadPicButton_Click(object sender, EventArgs e)                          //Upload Picture Button
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Vendor Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                    VendorPIcBox.ImageLocation = imgloc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void ClearAllButton_Click(object sender, EventArgs e)                           //To clear All Text Box 
        {
            VendorNameBox.Clear();
            VendorContactBox.Clear();
            VendorEmailbox.Clear();
            VendorTypeBox.Clear();
            VendorOtherInfoBox.Clear();
            VendorPIcBox.Image = null;
        }
        
        private void SubmitButton_Click_1(object sender, EventArgs e)                           //Create a New Vendor
        {
            mc.OpenConnection();
            if (VendorNameBox.Text != "" && VendorContactBox.Text != "" && VendorEmailbox.Text!="" && VendorTypeBox.Text!="")
            {
                try
                {
                byte[] img = null;
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                mc.SqlQuery("Insert into Vendor.VendorDetail(VendorName,ContactNo,Email,VendorType,OtherInfo,VendorImage) Values('" + VendorNameBox.Text + "'," + VendorContactBox.Text + ",'" + VendorEmailbox.Text + "','" + VendorTypeBox.Text + "','" + VendorOtherInfoBox.Text + "',@img)");

                mc.DbCommand.Parameters.Add(new SqlParameter("@img", img));
                mc.NonQueryExe();
                MessageBox.Show("New Vendor has been created successfully", "Congratulation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the details","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            mc.CloseConnection();
        }

    }
}
