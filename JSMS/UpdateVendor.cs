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
    public partial class UpdateVendor : Form
    {
        MainClass mc = new MainClass();
        string imgloc;
        public UpdateVendor()
        {
            InitializeComponent();
        }

        private void UploadPicButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                    VendorPicBox.ImageLocation = imgloc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            mc.OpenConnection();

            string UpdateByNo = "Update Vendor.VendorDetail SET VendorName = '" + VendorNameBox.Text + "',Email = '" + VendorEmailbox.Text + "',VendorType = '" + VendorTypeBox.Text + "',OtherInfo = '" + VendorOtherInfoBox.Text + "', VendorImage = @img Where ContactNo = "+VendorContactBox.Text;
            string UpdateByID = "Update Vendor.VendorDetail SET VendorName = '" + VendorNameBox.Text + "', ContactNo = "+VendorContactBox.Text+",Email = '" + VendorEmailbox.Text + "',VendorType = '" + VendorTypeBox.Text + "',OtherInfo = '" + VendorOtherInfoBox.Text + "', VendorImage = @img Where VendorID = " + VendorIdbox.Text;
            if (VendorSearchByList.SelectedItem == null)
            {
                MessageBox.Show("Select atleast one from Search by list to update Vendor Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                if (VendorSearchByList.SelectedItem == "Contact Number")
                {
                    mc.SqlQuery(UpdateByNo);
                }
                else if (VendorSearchByList.SelectedItem == "ID")
                {
                    mc.SqlQuery(UpdateByID);
                }
                mc.DbCommand.Parameters.Add(new SqlParameter("@img", img));
                mc.NonQueryExe();
                MessageBox.Show("Details has been updated successfully", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxClear();
            }

            mc.CloseConnection();
        }

        private void ClearAllButton_Click(object sender, EventArgs e)           //Text Box Clear Button
        {
            txtBoxClear();
        }
        public void txtBoxClear()                                               //Text Box Clear Function
        {
            VendorSearchByList = null;
            VendorIdbox.Clear();
            VendorNameBox.Clear();
            VendorContactBox.Clear();
            VendorEmailbox.Clear();
            VendorTypeBox.Clear();
            VendorOtherInfoBox.Clear();
            VendorPicBox.Image = null;
        }
    }
}
