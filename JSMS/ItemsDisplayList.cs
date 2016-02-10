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

namespace JSMS
{
    public partial class ItemsDisplayList : Form
    {
        public int MyFlag = 0;
        public ItemsDisplayList()
        {
            InitializeComponent();
        }

        private void DisplayList_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < MainClass.Images.Count; i++)
            {
                MemoryStream ms = new MemoryStream((byte[])MainClass.Images[i]);
                ++MyFlag;
                if (MyFlag == 1)
                {
                    pb1.Image = Image.FromStream(ms);
                }
                else if (MyFlag == 2)
                {
                    pb1.Image = Image.FromStream(ms);
                    pb2.Image = Image.FromStream(ms);
                }
                else if (MyFlag == 3)
                {
                    pb1.Image = Image.FromStream(ms);
                    pb3.Image = Image.FromStream(ms);
                }
                else if (MyFlag == 4)
                {
                    pb1.Image = Image.FromStream(ms);
                    pb4.Image = Image.FromStream(ms);
                }
                else if (MyFlag == 5)
                {
                    pb1.Image = Image.FromStream(ms);
                    pb5.Image = Image.FromStream(ms);
                }
                else if (MyFlag == 6)
                {
                    pb1.Image = Image.FromStream(ms);
                    pb6.Image = Image.FromStream(ms);
                }
                else if (MyFlag == 7)
                {
                    pb1.Image = Image.FromStream(ms);
                    pb7.Image = Image.FromStream(ms);
                }
                else if (MyFlag == 8)
                {
                    pb1.Image = Image.FromStream(ms);
                    pb8.Image = Image.FromStream(ms);
                    MyFlag = 9;
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainClass.Item = MainClass.item[0];
            MainClass.Quantity = MainClass.quantity[0];
            MainClass.Type = MainClass.type[0];
            MainClass.Material = MainClass.material[0];
            MainClass.Colour = MainClass.colour[0];
            MainClass.Weight = MainClass.weight[0];
            MainClass.Size = MainClass.size[0];
            MainClass.Price = MainClass.price[0];
            MainClass.Img = (byte[])MainClass.Images[0];
            MainClass.Flag = 1;
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainClass.Item = MainClass.item[1];
            MainClass.Material = MainClass.material[0];
            MainClass.Quantity = MainClass.quantity[1];
            MainClass.Type = MainClass.type[1];
            MainClass.Colour = MainClass.colour[1];
            MainClass.Weight = MainClass.weight[1];
            MainClass.Size = MainClass.size[1];
            MainClass.Price = MainClass.price[1];
            MainClass.Img = (byte[])MainClass.Images[1];
            MainClass.Flag = 1;
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            this.Close();
            MainClass.Item = MainClass.item[2];
            MainClass.Quantity = MainClass.quantity[2];
            MainClass.Type = MainClass.type[2];
            MainClass.Colour = MainClass.colour[2];
            MainClass.Material = MainClass.material[0];
            MainClass.Weight = MainClass.weight[2];
            MainClass.Size = MainClass.size[2];
            MainClass.Price = MainClass.price[2];
            MainClass.Img = (byte[])MainClass.Images[2];
            MainClass.Flag = 1;
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            this.Close();
            MainClass.Item = MainClass.item[3];
            MainClass.Material = MainClass.material[0];
            MainClass.Quantity = MainClass.quantity[3];
            MainClass.Type = MainClass.type[3];
            MainClass.Colour = MainClass.colour[3];
            MainClass.Weight = MainClass.weight[3];
            MainClass.Size = MainClass.size[3];
            MainClass.Price = MainClass.price[3];
            MainClass.Img = (byte[])MainClass.Images[3];
            MainClass.Flag = 1;
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            this.Close();
            MainClass.Item = MainClass.item[7];
            MainClass.Quantity = MainClass.quantity[7];
            MainClass.Type = MainClass.type[7];
            MainClass.Colour = MainClass.colour[7];
            MainClass.Material = MainClass.material[0];
            MainClass.Weight = MainClass.weight[7];
            MainClass.Size = MainClass.size[7];
            MainClass.Price = MainClass.price[7];
            MainClass.Img = (byte[])MainClass.Images[7];
            MainClass.Flag = 1;
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            this.Close();
            MainClass.Item = MainClass.item[6];
            MainClass.Quantity = MainClass.quantity[6];
            MainClass.Type = MainClass.type[6];
            MainClass.Material = MainClass.material[0];
            MainClass.Colour = MainClass.colour[6];
            MainClass.Weight = MainClass.weight[6];
            MainClass.Size = MainClass.size[6];
            MainClass.Material = MainClass.material[0];
            MainClass.Price = MainClass.price[6];
            MainClass.Img = (byte[])MainClass.Images[6];
            MainClass.Flag = 1;
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            this.Close();
            MainClass.Item = MainClass.item[5];
            MainClass.Quantity = MainClass.quantity[5];
            MainClass.Type = MainClass.type[5];
            MainClass.Colour = MainClass.colour[5];
            MainClass.Material = MainClass.material[0];
            MainClass.Weight = MainClass.weight[5];
            MainClass.Size = MainClass.size[5];
            MainClass.Price = MainClass.price[5];
            MainClass.Img = (byte[])MainClass.Images[5];
            MainClass.Flag = 1;
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            this.Close();
            MainClass.Item = MainClass.item[4];
            MainClass.Material = MainClass.material[0];
            MainClass.Quantity = MainClass.quantity[4];
            MainClass.Type = MainClass.type[4];
            MainClass.Colour = MainClass.colour[4];
            MainClass.Weight = MainClass.weight[4];
            MainClass.Size = MainClass.size[4];
            MainClass.Price = MainClass.price[4];
            MainClass.Material = MainClass.material[0];
            MainClass.Img = (byte[])MainClass.Images[4];
            MainClass.Flag = 1;
        }
    }
}