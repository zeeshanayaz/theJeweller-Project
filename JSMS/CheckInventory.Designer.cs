namespace JSMS
{
    partial class CheckInventory
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
            this.InventoryTable = new System.Windows.Forms.DataGridView();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.SideBarPic = new System.Windows.Forms.PictureBox();
            this.CheckInventorylabel = new System.Windows.Forms.Label();
            this.JewelleryTypeList = new System.Windows.Forms.ComboBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.BorderT_R = new System.Windows.Forms.PictureBox();
            this.BorderT_L = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBarPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_L)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryTable
            // 
            this.InventoryTable.BackgroundColor = System.Drawing.Color.White;
            this.InventoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryTable.Location = new System.Drawing.Point(25, 225);
            this.InventoryTable.Name = "InventoryTable";
            this.InventoryTable.Size = new System.Drawing.Size(547, 247);
            this.InventoryTable.TabIndex = 0;
            // 
            // LogoPic
            // 
            this.LogoPic.Image = global::JSMS.Properties.Resources.Logo;
            this.LogoPic.Location = new System.Drawing.Point(25, 1);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(248, 175);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPic.TabIndex = 1;
            this.LogoPic.TabStop = false;
            // 
            // SideBarPic
            // 
            this.SideBarPic.Image = global::JSMS.Properties.Resources.BlueSideBar;
            this.SideBarPic.Location = new System.Drawing.Point(-8, -13);
            this.SideBarPic.Name = "SideBarPic";
            this.SideBarPic.Size = new System.Drawing.Size(33, 501);
            this.SideBarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SideBarPic.TabIndex = 2;
            this.SideBarPic.TabStop = false;
            // 
            // CheckInventorylabel
            // 
            this.CheckInventorylabel.AutoSize = true;
            this.CheckInventorylabel.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInventorylabel.Location = new System.Drawing.Point(312, 53);
            this.CheckInventorylabel.Name = "CheckInventorylabel";
            this.CheckInventorylabel.Size = new System.Drawing.Size(220, 43);
            this.CheckInventorylabel.TabIndex = 3;
            this.CheckInventorylabel.Text = "Check Inventory";
            // 
            // JewelleryTypeList
            // 
            this.JewelleryTypeList.BackColor = System.Drawing.Color.White;
            this.JewelleryTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JewelleryTypeList.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JewelleryTypeList.ForeColor = System.Drawing.Color.Black;
            this.JewelleryTypeList.FormattingEnabled = true;
            this.JewelleryTypeList.Items.AddRange(new object[] {
            "All",
            "CompleteSet",
            "Bracelets",
            "Rings",
            "Necklace",
            "Bangles",
            "Earings ",
            "MenWatches",
            "FemaleWatches"});
            this.JewelleryTypeList.Location = new System.Drawing.Point(416, 134);
            this.JewelleryTypeList.Name = "JewelleryTypeList";
            this.JewelleryTypeList.Size = new System.Drawing.Size(146, 30);
            this.JewelleryTypeList.TabIndex = 1;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(301, 129);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(89, 33);
            this.SearchLabel.TabIndex = 6;
            this.SearchLabel.Text = "Search :";
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.PowderBlue;
            this.CheckButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton.Location = new System.Drawing.Point(376, 181);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(94, 37);
            this.CheckButton.TabIndex = 2;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryLabel.Location = new System.Drawing.Point(31, 189);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(116, 33);
            this.InventoryLabel.TabIndex = 7;
            this.InventoryLabel.Text = "Inventory:";
            // 
            // BorderT_R
            // 
            this.BorderT_R.Image = global::JSMS.Properties.Resources.Border_T_R;
            this.BorderT_R.Location = new System.Drawing.Point(513, 1);
            this.BorderT_R.Name = "BorderT_R";
            this.BorderT_R.Size = new System.Drawing.Size(64, 59);
            this.BorderT_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BorderT_R.TabIndex = 8;
            this.BorderT_R.TabStop = false;
            // 
            // BorderT_L
            // 
            this.BorderT_L.Image = global::JSMS.Properties.Resources.Border_T_L;
            this.BorderT_L.Location = new System.Drawing.Point(23, 1);
            this.BorderT_L.Name = "BorderT_L";
            this.BorderT_L.Size = new System.Drawing.Size(64, 59);
            this.BorderT_L.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BorderT_L.TabIndex = 9;
            this.BorderT_L.TabStop = false;
            // 
            // CheckInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 476);
            this.Controls.Add(this.BorderT_L);
            this.Controls.Add(this.BorderT_R);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.JewelleryTypeList);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.CheckInventorylabel);
            this.Controls.Add(this.SideBarPic);
            this.Controls.Add(this.LogoPic);
            this.Controls.Add(this.InventoryTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckInventory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.InventoryTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBarPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_L)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InventoryTable;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.PictureBox SideBarPic;
        private System.Windows.Forms.Label CheckInventorylabel;
        private System.Windows.Forms.ComboBox JewelleryTypeList;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.PictureBox BorderT_R;
        private System.Windows.Forms.PictureBox BorderT_L;
    }
}