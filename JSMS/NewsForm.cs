using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSMS
{
    public partial class NewsForm : Form
    {
        public NewsForm()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Reloadbtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Searchbar.Text);
        }
    }
}
