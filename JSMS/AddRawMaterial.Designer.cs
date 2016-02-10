namespace JSMS
{
    partial class AddRawMaterial
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
            this.SideBar = new System.Windows.Forms.PictureBox();
            this.AddRawMaterialLabel = new System.Windows.Forms.Label();
            this.ItemBox = new System.Windows.Forms.TextBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemNameBox = new System.Windows.Forms.TextBox();
            this.ItemTypeBox = new System.Windows.Forms.TextBox();
            this.ItemTypeLabel = new System.Windows.Forms.Label();
            this.ItemMaterialBox = new System.Windows.Forms.TextBox();
            this.ItemMaterialLabel = new System.Windows.Forms.Label();
            this.VendorIDLabel = new System.Windows.Forms.Label();
            this.VendorIDBox = new System.Windows.Forms.TextBox();
            this.ItemQuantityLabel = new System.Windows.Forms.Label();
            this.ItemQuantityBox = new System.Windows.Forms.TextBox();
            this.ItemPriceLabel = new System.Windows.Forms.Label();
            this.ItemPriceBox = new System.Windows.Forms.TextBox();
            this.ItemOtherInfoBox = new System.Windows.Forms.RichTextBox();
            this.ItemOtherInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.Image = global::JSMS.Properties.Resources.BlueSideBar;
            this.SideBar.Location = new System.Drawing.Point(-3, -5);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(34, 496);
            this.SideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SideBar.TabIndex = 0;
            this.SideBar.TabStop = false;
            // 
            // AddRawMaterialLabel
            // 
            this.AddRawMaterialLabel.AutoSize = true;
            this.AddRawMaterialLabel.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRawMaterialLabel.Location = new System.Drawing.Point(298, 77);
            this.AddRawMaterialLabel.Name = "AddRawMaterialLabel";
            this.AddRawMaterialLabel.Size = new System.Drawing.Size(255, 43);
            this.AddRawMaterialLabel.TabIndex = 1;
            this.AddRawMaterialLabel.Text = "Add Raw Material";
            // 
            // ItemBox
            // 
            this.ItemBox.BackColor = System.Drawing.Color.PowderBlue;
            this.ItemBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBox.Location = new System.Drawing.Point(170, 189);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.ReadOnly = true;
            this.ItemBox.Size = new System.Drawing.Size(148, 29);
            this.ItemBox.TabIndex = 234;
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.Color.PowderBlue;
            this.AddItemButton.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemButton.Location = new System.Drawing.Point(384, 426);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(132, 38);
            this.AddItemButton.TabIndex = 8;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // logo
            // 
            this.logo.Image = global::JSMS.Properties.Resources.Logo;
            this.logo.Location = new System.Drawing.Point(12, -5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(258, 160);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel.Location = new System.Drawing.Point(37, 185);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(78, 33);
            this.ItemLabel.TabIndex = 5;
            this.ItemLabel.Text = "Item#";
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameLabel.Location = new System.Drawing.Point(37, 220);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(78, 33);
            this.ItemNameLabel.TabIndex = 6;
            this.ItemNameLabel.Text = "Name:";
            // 
            // ItemNameBox
            // 
            this.ItemNameBox.BackColor = System.Drawing.Color.PowderBlue;
            this.ItemNameBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameBox.Location = new System.Drawing.Point(170, 224);
            this.ItemNameBox.Name = "ItemNameBox";
            this.ItemNameBox.Size = new System.Drawing.Size(148, 29);
            this.ItemNameBox.TabIndex = 1;
            // 
            // ItemTypeBox
            // 
            this.ItemTypeBox.BackColor = System.Drawing.Color.PowderBlue;
            this.ItemTypeBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemTypeBox.Location = new System.Drawing.Point(170, 259);
            this.ItemTypeBox.Name = "ItemTypeBox";
            this.ItemTypeBox.Size = new System.Drawing.Size(148, 29);
            this.ItemTypeBox.TabIndex = 2;
            // 
            // ItemTypeLabel
            // 
            this.ItemTypeLabel.AutoSize = true;
            this.ItemTypeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemTypeLabel.Location = new System.Drawing.Point(37, 255);
            this.ItemTypeLabel.Name = "ItemTypeLabel";
            this.ItemTypeLabel.Size = new System.Drawing.Size(68, 33);
            this.ItemTypeLabel.TabIndex = 9;
            this.ItemTypeLabel.Text = "Type:";
            // 
            // ItemMaterialBox
            // 
            this.ItemMaterialBox.BackColor = System.Drawing.Color.PowderBlue;
            this.ItemMaterialBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemMaterialBox.Location = new System.Drawing.Point(170, 294);
            this.ItemMaterialBox.Name = "ItemMaterialBox";
            this.ItemMaterialBox.Size = new System.Drawing.Size(148, 29);
            this.ItemMaterialBox.TabIndex = 3;
            // 
            // ItemMaterialLabel
            // 
            this.ItemMaterialLabel.AutoSize = true;
            this.ItemMaterialLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemMaterialLabel.Location = new System.Drawing.Point(37, 289);
            this.ItemMaterialLabel.Name = "ItemMaterialLabel";
            this.ItemMaterialLabel.Size = new System.Drawing.Size(106, 33);
            this.ItemMaterialLabel.TabIndex = 11;
            this.ItemMaterialLabel.Text = "Material:";
            // 
            // VendorIDLabel
            // 
            this.VendorIDLabel.AutoSize = true;
            this.VendorIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.VendorIDLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorIDLabel.Location = new System.Drawing.Point(37, 324);
            this.VendorIDLabel.Name = "VendorIDLabel";
            this.VendorIDLabel.Size = new System.Drawing.Size(126, 33);
            this.VendorIDLabel.TabIndex = 12;
            this.VendorIDLabel.Text = "Vendor ID:";
            // 
            // VendorIDBox
            // 
            this.VendorIDBox.BackColor = System.Drawing.Color.PowderBlue;
            this.VendorIDBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorIDBox.Location = new System.Drawing.Point(170, 329);
            this.VendorIDBox.Name = "VendorIDBox";
            this.VendorIDBox.Size = new System.Drawing.Size(148, 29);
            this.VendorIDBox.TabIndex = 4;
            // 
            // ItemQuantityLabel
            // 
            this.ItemQuantityLabel.AutoSize = true;
            this.ItemQuantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.ItemQuantityLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQuantityLabel.Location = new System.Drawing.Point(37, 359);
            this.ItemQuantityLabel.Name = "ItemQuantityLabel";
            this.ItemQuantityLabel.Size = new System.Drawing.Size(109, 33);
            this.ItemQuantityLabel.TabIndex = 14;
            this.ItemQuantityLabel.Text = "Quantity:";
            // 
            // ItemQuantityBox
            // 
            this.ItemQuantityBox.BackColor = System.Drawing.Color.PowderBlue;
            this.ItemQuantityBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQuantityBox.Location = new System.Drawing.Point(170, 364);
            this.ItemQuantityBox.Name = "ItemQuantityBox";
            this.ItemQuantityBox.Size = new System.Drawing.Size(148, 29);
            this.ItemQuantityBox.TabIndex = 5;
            // 
            // ItemPriceLabel
            // 
            this.ItemPriceLabel.AutoSize = true;
            this.ItemPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.ItemPriceLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPriceLabel.Location = new System.Drawing.Point(37, 394);
            this.ItemPriceLabel.Name = "ItemPriceLabel";
            this.ItemPriceLabel.Size = new System.Drawing.Size(70, 33);
            this.ItemPriceLabel.TabIndex = 16;
            this.ItemPriceLabel.Text = "Price:";
            // 
            // ItemPriceBox
            // 
            this.ItemPriceBox.BackColor = System.Drawing.Color.PowderBlue;
            this.ItemPriceBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPriceBox.Location = new System.Drawing.Point(170, 399);
            this.ItemPriceBox.Name = "ItemPriceBox";
            this.ItemPriceBox.Size = new System.Drawing.Size(148, 29);
            this.ItemPriceBox.TabIndex = 6;
            // 
            // ItemOtherInfoBox
            // 
            this.ItemOtherInfoBox.BackColor = System.Drawing.Color.PowderBlue;
            this.ItemOtherInfoBox.Location = new System.Drawing.Point(346, 225);
            this.ItemOtherInfoBox.Name = "ItemOtherInfoBox";
            this.ItemOtherInfoBox.Size = new System.Drawing.Size(222, 168);
            this.ItemOtherInfoBox.TabIndex = 7;
            this.ItemOtherInfoBox.Text = "";
            // 
            // ItemOtherInfoLabel
            // 
            this.ItemOtherInfoLabel.AutoSize = true;
            this.ItemOtherInfoLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemOtherInfoLabel.Location = new System.Drawing.Point(340, 189);
            this.ItemOtherInfoLabel.Name = "ItemOtherInfoLabel";
            this.ItemOtherInfoLabel.Size = new System.Drawing.Size(124, 33);
            this.ItemOtherInfoLabel.TabIndex = 19;
            this.ItemOtherInfoLabel.Text = "Other Info:";
            // 
            // AddRawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::JSMS.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 476);
            this.Controls.Add(this.ItemOtherInfoLabel);
            this.Controls.Add(this.ItemOtherInfoBox);
            this.Controls.Add(this.ItemPriceBox);
            this.Controls.Add(this.ItemPriceLabel);
            this.Controls.Add(this.ItemQuantityBox);
            this.Controls.Add(this.ItemQuantityLabel);
            this.Controls.Add(this.VendorIDBox);
            this.Controls.Add(this.VendorIDLabel);
            this.Controls.Add(this.ItemMaterialLabel);
            this.Controls.Add(this.ItemMaterialBox);
            this.Controls.Add(this.ItemTypeLabel);
            this.Controls.Add(this.ItemTypeBox);
            this.Controls.Add(this.ItemNameBox);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.ItemBox);
            this.Controls.Add(this.AddRawMaterialLabel);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRawMaterial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.SideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SideBar;
        private System.Windows.Forms.Label AddRawMaterialLabel;
        private System.Windows.Forms.TextBox ItemBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.TextBox ItemNameBox;
        private System.Windows.Forms.TextBox ItemTypeBox;
        private System.Windows.Forms.Label ItemTypeLabel;
        private System.Windows.Forms.TextBox ItemMaterialBox;
        private System.Windows.Forms.Label ItemMaterialLabel;
        private System.Windows.Forms.Label VendorIDLabel;
        private System.Windows.Forms.TextBox VendorIDBox;
        private System.Windows.Forms.Label ItemQuantityLabel;
        private System.Windows.Forms.TextBox ItemQuantityBox;
        private System.Windows.Forms.Label ItemPriceLabel;
        private System.Windows.Forms.TextBox ItemPriceBox;
        private System.Windows.Forms.RichTextBox ItemOtherInfoBox;
        private System.Windows.Forms.Label ItemOtherInfoLabel;
    }
}