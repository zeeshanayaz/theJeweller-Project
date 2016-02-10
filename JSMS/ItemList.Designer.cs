namespace JSMS
{
    partial class ItemList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InvoiceTable = new System.Windows.Forms.DataGridView();
            this.SelectedItemlabel = new System.Windows.Forms.Label();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BorderT_L = new System.Windows.Forms.PictureBox();
            this.SideBarPic = new System.Windows.Forms.PictureBox();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.BorderT_R = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBarPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_R)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoiceTable
            // 
            this.InvoiceTable.BackgroundColor = System.Drawing.Color.White;
            this.InvoiceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceTable.GridColor = System.Drawing.Color.PowderBlue;
            this.InvoiceTable.Location = new System.Drawing.Point(30, 214);
            this.InvoiceTable.Name = "InvoiceTable";
            this.InvoiceTable.Size = new System.Drawing.Size(473, 224);
            this.InvoiceTable.TabIndex = 92;
            // 
            // SelectedItemlabel
            // 
            this.SelectedItemlabel.AutoSize = true;
            this.SelectedItemlabel.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedItemlabel.Location = new System.Drawing.Point(160, 168);
            this.SelectedItemlabel.Name = "SelectedItemlabel";
            this.SelectedItemlabel.Size = new System.Drawing.Size(194, 43);
            this.SelectedItemlabel.TabIndex = 91;
            this.SelectedItemlabel.Text = "Selected Items";
            // 
            // ContinueButton
            // 
            this.ContinueButton.BackColor = System.Drawing.Color.PowderBlue;
            this.ContinueButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueButton.Location = new System.Drawing.Point(196, 444);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(155, 38);
            this.ContinueButton.TabIndex = 90;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = false;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Image = global::JSMS.Properties.Resources.no;
            this.CloseButton.Location = new System.Drawing.Point(467, 19);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(21, 22);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 89;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::JSMS.Properties.Resources.Border_D_L;
            this.pictureBox2.Location = new System.Drawing.Point(30, 430);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JSMS.Properties.Resources.Border_D_R;
            this.pictureBox1.Location = new System.Drawing.Point(435, 430);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // BorderT_L
            // 
            this.BorderT_L.Image = global::JSMS.Properties.Resources.Border_T_L;
            this.BorderT_L.Location = new System.Drawing.Point(30, 0);
            this.BorderT_L.Name = "BorderT_L";
            this.BorderT_L.Size = new System.Drawing.Size(68, 66);
            this.BorderT_L.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BorderT_L.TabIndex = 86;
            this.BorderT_L.TabStop = false;
            // 
            // SideBarPic
            // 
            this.SideBarPic.Image = global::JSMS.Properties.Resources.BlueSideBar;
            this.SideBarPic.Location = new System.Drawing.Point(-1, -7);
            this.SideBarPic.Name = "SideBarPic";
            this.SideBarPic.Size = new System.Drawing.Size(33, 513);
            this.SideBarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SideBarPic.TabIndex = 84;
            this.SideBarPic.TabStop = false;
            // 
            // LogoPic
            // 
            this.LogoPic.Image = global::JSMS.Properties.Resources.Logo;
            this.LogoPic.Location = new System.Drawing.Point(146, 0);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(248, 165);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPic.TabIndex = 83;
            this.LogoPic.TabStop = false;
            // 
            // BorderT_R
            // 
            this.BorderT_R.Image = global::JSMS.Properties.Resources.Border_T_R;
            this.BorderT_R.Location = new System.Drawing.Point(438, -1);
            this.BorderT_R.Name = "BorderT_R";
            this.BorderT_R.Size = new System.Drawing.Size(68, 66);
            this.BorderT_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BorderT_R.TabIndex = 85;
            this.BorderT_R.TabStop = false;
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 496);
            this.Controls.Add(this.InvoiceTable);
            this.Controls.Add(this.SelectedItemlabel);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BorderT_L);
            this.Controls.Add(this.SideBarPic);
            this.Controls.Add(this.LogoPic);
            this.Controls.Add(this.BorderT_R);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemList";
            this.Load += new System.EventHandler(this.ItemList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBarPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_R)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InvoiceTable;
        private System.Windows.Forms.Label SelectedItemlabel;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BorderT_L;
        private System.Windows.Forms.PictureBox SideBarPic;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.PictureBox BorderT_R;
    }
}