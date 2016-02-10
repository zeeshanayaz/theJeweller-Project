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
using System.Data.SqlTypes;


namespace JSMS
{
    public partial class UpdateStatus : Form
    {
        MainClass mc = new MainClass();
        public UpdateStatus()
        {
            InitializeComponent();
        }

        private void UpdateJobButton_Click(object sender, EventArgs e)          //Update Services Status
        {
            mc.OpenConnection();
            try
            {
                if(JobIDBox.Text == "")
                {
                    MessageBox.Show("Please enter Job ID to update status", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (RepairJobRadioButton.Checked)
                    {
                        mc.SqlQuery("Update Services.RepairJob Set Status = '"+StatusBox.Text+"'");
                    }
                    else if (CustomJobRadioButton.Checked)
                    {
                        mc.SqlQuery("Update Services.CustomJob Set Status = '" + StatusBox.Text + "'");
                    }
                    mc.NonQueryExe();
                    MessageBox.Show("Status have been updated successfully", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mc.CloseConnection();
        }
    
    }
}
