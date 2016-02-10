namespace JSMS
{
    partial class CheckCustomer
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
            this.BorderT_L = new System.Windows.Forms.PictureBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.InputLabel = new System.Windows.Forms.Label();
            this.SearchInputBox = new System.Windows.Forms.TextBox();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.CustomerSearchList = new System.Windows.Forms.ComboBox();
            this.CheckInventorylabel = new System.Windows.Forms.Label();
            this.SideBarPic = new System.Windows.Forms.PictureBox();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.CustomerTable = new System.Windows.Forms.DataGridView();
            this.BorderT_R = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBarPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_R)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderT_L
            // 
            this.BorderT_L.Image = global::JSMS.Properties.Resources.Border_T_L;
            this.BorderT_L.Location = new System.Drawing.Point(26, -1);
            this.BorderT_L.Name = "BorderT_L";
            this.BorderT_L.Size = new System.Drawing.Size(58, 54);
            this.BorderT_L.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BorderT_L.TabIndex = 49;
            this.BorderT_L.TabStop = false;
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.PowderBlue;
            this.CheckButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton.Location = new System.Drawing.Point(375, 187);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(100, 33);
            this.CheckButton.TabIndex = 3;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(280, 134);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(116, 28);
            this.InputLabel.TabIndex = 47;
            this.InputLabel.Text = "Enter Here :";
            // 
            // SearchInputBox
            // 
            this.SearchInputBox.BackColor = System.Drawing.Color.PowderBlue;
            this.SearchInputBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchInputBox.Location = new System.Drawing.Point(407, 136);
            this.SearchInputBox.Name = "SearchInputBox";
            this.SearchInputBox.Size = new System.Drawing.Size(146, 29);
            this.SearchInputBox.TabIndex = 2;
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersLabel.Location = new System.Drawing.Point(32, 190);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(195, 33);
            this.CustomersLabel.TabIndex = 46;
            this.CustomersLabel.Text = "Customer\'s Record:";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(280, 98);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(102, 28);
            this.SearchLabel.TabIndex = 45;
            this.SearchLabel.Text = "Search By:";
            // 
            // CustomerSearchList
            // 
            this.CustomerSearchList.BackColor = System.Drawing.Color.White;
            this.CustomerSearchList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerSearchList.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSearchList.ForeColor = System.Drawing.Color.Black;
            this.CustomerSearchList.FormattingEnabled = true;
            this.CustomerSearchList.Items.AddRange(new object[] {
            "All",
            "Name",
            "Contact #",
            "Invoice #"});
            this.CustomerSearchList.Location = new System.Drawing.Point(407, 100);
            this.CustomerSearchList.Name = "CustomerSearchList";
            this.CustomerSearchList.Size = new System.Drawing.Size(146, 30);
            this.CustomerSearchList.TabIndex = 1;
            // 
            // CheckInventorylabel
            // 
            this.CheckInventorylabel.AutoSize = true;
            this.CheckInventorylabel.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInventorylabel.Location = new System.Drawing.Point(367, 30);
            this.CheckInventorylabel.Name = "CheckInventorylabel";
            this.CheckInventorylabel.Size = new System.Drawing.Size(133, 43);
            this.CheckInventorylabel.TabIndex = 44;
            this.CheckInventorylabel.Text = "Customer";
            // 
            // SideBarPic
            // 
            this.SideBarPic.Image = global::JSMS.Properties.Resources.BlueSideBar;
            this.SideBarPic.Location = new System.Drawing.Point(-7, -12);
            this.SideBarPic.Name = "SideBarPic";
            this.SideBarPic.Size = new System.Drawing.Size(33, 501);
            this.SideBarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SideBarPic.TabIndex = 43;
            this.SideBarPic.TabStop = false;
            // 
            // LogoPic
            // 
            this.LogoPic.Image = global::JSMS.Properties.Resources.Logo;
            this.LogoPic.Location = new System.Drawing.Point(26, 2);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(248, 175);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPic.TabIndex = 42;
            this.LogoPic.TabStop = false;
            // 
            // CustomerTable
            // 
            this.CustomerTable.BackgroundColor = System.Drawing.Color.White;
            this.CustomerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerTable.Location = new System.Drawing.Point(26, 226);
            this.CustomerTable.Name = "CustomerTable";
            this.CustomerTable.Size = new System.Drawing.Size(547, 247);
            this.CustomerTable.TabIndex = 41;
            // 
            // BorderT_R
            // 
            this.BorderT_R.Image = global::JSMS.Properties.Resources.Border_T_R;
            this.BorderT_R.Location = new System.Drawing.Point(516, -1);
            this.BorderT_R.Name = "BorderT_R";
            this.BorderT_R.Size = new System.Drawing.Size(58, 54);
            this.BorderT_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BorderT_R.TabIndex = 48;
            this.BorderT_R.TabStop = false;
            // 
            // CheckCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 476);
            this.Controls.Add(this.BorderT_L);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.SearchInputBox);
            this.Controls.Add(this.CustomersLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.CustomerSearchList);
            this.Controls.Add(this.CheckInventorylabel);
            this.Controls.Add(this.SideBarPic);
            this.Controls.Add(this.LogoPic);
            this.Controls.Add(this.CustomerTable);
            this.Controls.Add(this.BorderT_R);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckCustomer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBarPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_R)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BorderT_L;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox SearchInputBox;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.ComboBox CustomerSearchList;
        private System.Windows.Forms.Label CheckInventorylabel;
        private System.Windows.Forms.PictureBox SideBarPic;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.DataGridView CustomerTable;
        private System.Windows.Forms.PictureBox BorderT_R;
    }
}