namespace JSMS
{
    partial class JwellerySearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JwellerySearchForm));
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.JewelleryTypeLabel = new System.Windows.Forms.Label();
            this.ItemLable = new System.Windows.Forms.Label();
            this.ItemBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaterialList = new System.Windows.Forms.ComboBox();
            this.JewelleryTypeList = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.BackColor = System.Drawing.Color.Transparent;
            this.MaterialLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialLabel.Location = new System.Drawing.Point(87, 261);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(93, 28);
            this.MaterialLabel.TabIndex = 1;
            this.MaterialLabel.Text = "Material:";
            // 
            // JewelleryTypeLabel
            // 
            this.JewelleryTypeLabel.AutoSize = true;
            this.JewelleryTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.JewelleryTypeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JewelleryTypeLabel.Location = new System.Drawing.Point(87, 225);
            this.JewelleryTypeLabel.Name = "JewelleryTypeLabel";
            this.JewelleryTypeLabel.Size = new System.Drawing.Size(144, 28);
            this.JewelleryTypeLabel.TabIndex = 2;
            this.JewelleryTypeLabel.Text = "Jewellery Type:";
            // 
            // ItemLable
            // 
            this.ItemLable.AutoSize = true;
            this.ItemLable.BackColor = System.Drawing.Color.Transparent;
            this.ItemLable.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLable.Location = new System.Drawing.Point(87, 190);
            this.ItemLable.Name = "ItemLable";
            this.ItemLable.Size = new System.Drawing.Size(79, 28);
            this.ItemLable.TabIndex = 3;
            this.ItemLable.Text = "Item #:";
            // 
            // ItemBox
            // 
            this.ItemBox.BackColor = System.Drawing.Color.PowderBlue;
            this.ItemBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ItemBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBox.Location = new System.Drawing.Point(301, 192);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(146, 29);
            this.ItemBox.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.PowderBlue;
            this.SearchButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(197, 309);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(122, 32);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jewellery Selection";
            // 
            // MaterialList
            // 
            this.MaterialList.BackColor = System.Drawing.Color.White;
            this.MaterialList.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaterialList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialList.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialList.ForeColor = System.Drawing.Color.Black;
            this.MaterialList.Items.AddRange(new object[] {
            "",
            "Gold",
            "Silver",
            "Other"});
            this.MaterialList.Location = new System.Drawing.Point(301, 263);
            this.MaterialList.Name = "MaterialList";
            this.MaterialList.Size = new System.Drawing.Size(146, 30);
            this.MaterialList.TabIndex = 1;
            // 
            // JewelleryTypeList
            // 
            this.JewelleryTypeList.BackColor = System.Drawing.Color.White;
            this.JewelleryTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JewelleryTypeList.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JewelleryTypeList.ForeColor = System.Drawing.Color.Black;
            this.JewelleryTypeList.FormattingEnabled = true;
            this.JewelleryTypeList.Items.AddRange(new object[] {
            "CompleteSet",
            "Bracelets",
            "Rings",
            "Necklace",
            "Bangles",
            "Earrings ",
            "MenWatches",
            "FemaleWatches"});
            this.JewelleryTypeList.Location = new System.Drawing.Point(301, 227);
            this.JewelleryTypeList.Name = "JewelleryTypeList";
            this.JewelleryTypeList.Size = new System.Drawing.Size(146, 30);
            this.JewelleryTypeList.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JSMS.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(49, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::JSMS.Properties.Resources.Border_T_R;
            this.pictureBox4.Location = new System.Drawing.Point(472, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::JSMS.Properties.Resources.Border_T_L;
            this.pictureBox5.Location = new System.Drawing.Point(26, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::JSMS.Properties.Resources.BlueSideBar;
            this.pictureBox6.Location = new System.Drawing.Point(-17, -4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(46, 371);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(59, 197);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(29, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // JwellerySearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::JSMS.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 353);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.JewelleryTypeList);
            this.Controls.Add(this.MaterialList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ItemBox);
            this.Controls.Add(this.ItemLable);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.JewelleryTypeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JwellerySearchForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.Label JewelleryTypeLabel;
        private System.Windows.Forms.Label ItemLable;
        private System.Windows.Forms.TextBox ItemBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MaterialList;
        private System.Windows.Forms.ComboBox JewelleryTypeList;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}