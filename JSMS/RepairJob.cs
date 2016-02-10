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
using System.Data.SqlClient;

namespace JSMS
{
    public partial class RepairJob : Form
    {
        MainClass mc = new MainClass();
        public RepairJob()
        {
            InitializeComponent();
        }
   
        private void RepairJob_Load(object sender, EventArgs e)
        {
            IssueDate.Format = DateTimePickerFormat.Custom;
            IssueDate.CustomFormat = "mm/dd/yyyy";                                  //set format according to your needs
        }

        private void SubmitJobButton_Click(object sender, EventArgs e)              //Submit Button
        {
            mc.OpenConnection();
            if (MaterialList.SelectedItem != null && JewelleryTypeList.SelectedItem != null)
            {
                try
                {
                    string Query = "INSERT INTO Services.RepairJob(Material,Weight,Size,Type,IssueDate,PromiseDate,Requirement,Status) VALUES('" + MaterialList.SelectedItem + "'," + WeightBox.Text + "," + SizeBox.Text + ",'" + JewelleryTypeList.SelectedItem + "'," + IssueDate.Value.ToShortDateString() + "," + PromiseDate.Value.ToShortDateString() + ",'" + Requirements.Text + "','"+StatusBox.Text+"')";
                    mc.SqlQuery(Query);
                    mc.NonQueryExe();
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

        public void txtBoxClear()                                                   //Clear Text Boxes function
        {
            JobIDBox.Clear();
            MaterialList.SelectedItem = null;
            WeightBox.Clear();
            SizeBox.Clear();
            StatusBox.Clear();
            JewelleryTypeList.SelectedItem = null;
            Requirements.Clear();
        }
    }
}
