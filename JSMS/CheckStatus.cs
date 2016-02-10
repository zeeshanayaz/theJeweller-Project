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
    public partial class CheckStatus : Form
    {
        MainClass mc = new MainClass();
        public CheckStatus()
        {
            InitializeComponent();
        }

        private void SearchJobButton_Click(object sender, EventArgs e)              //Check status of Services
        {
            mc.OpenConnection();
            try
            {
                if (JobIDBox.Text == "")
                {
                    MessageBox.Show("Please Enter Job ID #","Instruction",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    if (CustomJobRadioButton.Checked)
                    {
                        mc.SqlQuery("Select * From Services.CustomJob Where JobID = " + JobIDBox.Text);
                        DataTable dt = new DataTable();
                        SqlDataAdapter adp = new SqlDataAdapter(mc.DbCommand);
                        adp.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            StatusBox.Text = dt.Rows[0]["Status"].ToString();
                        }
                        else
                        { MessageBox.Show("Please check the Job ID # again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                    }
                    else if (RepairJobRadioButton.Checked)
                    {
                        mc.SqlQuery("Select * From Services.RepairJob Where JobID = " + JobIDBox.Text);
                        DataTable dt = new DataTable();
                        SqlDataAdapter adp = new SqlDataAdapter(mc.DbCommand);
                        adp.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            StatusBox.Text = dt.Rows[0]["Status"].ToString();
                        }
                        else
                        { MessageBox.Show("Please check the Job ID # again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                    }
                    else
                    {
                        MessageBox.Show("Please Select any one to Check Status!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            mc.CloseConnection();
        }

        private void ClearButton_Click(object sender, EventArgs e)                  //Clear all boxes
        {
            StatusBox.Clear();
            JobIDBox.Clear();
        }
   
    }
}
