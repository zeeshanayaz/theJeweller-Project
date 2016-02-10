namespace JSMS
{
    partial class RepairJob
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
            this.JewelleryTypeList = new System.Windows.Forms.ComboBox();
            this.MaterialList = new System.Windows.Forms.ComboBox();
            this.SubmitJobButton = new System.Windows.Forms.Button();
            this.Requirements = new System.Windows.Forms.RichTextBox();
            this.RequirementsLabel = new System.Windows.Forms.Label();
            this.SizeBox = new System.Windows.Forms.TextBox();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.JobIDBox = new System.Windows.Forms.TextBox();
            this.MaterialTypeLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.JobIDLabel = new System.Windows.Forms.Label();
            this.SideBar = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.CustomJobLabel = new System.Windows.Forms.Label();
            this.PromiseDate = new System.Windows.Forms.DateTimePicker();
            this.IssueDatelabel = new System.Windows.Forms.Label();
            this.IssueDate = new System.Windows.Forms.DateTimePicker();
            this.PromiseDateLabel = new System.Windows.Forms.Label();
            this.BorderT_R = new System.Windows.Forms.PictureBox();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_R)).BeginInit();
            this.SuspendLayout();
            // 
            // JewelleryTypeList
            // 
            this.JewelleryTypeList.BackColor = System.Drawing.Color.PowderBlue;
            this.JewelleryTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JewelleryTypeList.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JewelleryTypeList.ForeColor = System.Drawing.Color.Black;
            this.JewelleryTypeList.FormattingEnabled = true;
            this.JewelleryTypeList.Items.AddRange(new object[] {
            "Complete Set",
            "Bracelets",
            "Rings",
            "Necklace",
            "Bangles",
            "Earrings ",
            "Other"});
            this.JewelleryTypeList.Location = new System.Drawing.Point(151, 318);
            this.JewelleryTypeList.Name = "JewelleryTypeList";
            this.JewelleryTypeList.Size = new System.Drawing.Size(132, 30);
            this.JewelleryTypeList.TabIndex = 4;
            // 
            // MaterialList
            // 
            this.MaterialList.BackColor = System.Drawing.Color.White;
            this.MaterialList.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaterialList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialList.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialList.ForeColor = System.Drawing.Color.Black;
            this.MaterialList.Items.AddRange(new object[] {
            "Gold",
            "Silver",
            "Other"});
            this.MaterialList.Location = new System.Drawing.Point(151, 213);
            this.MaterialList.Name = "MaterialList";
            this.MaterialList.Size = new System.Drawing.Size(132, 30);
            this.MaterialList.TabIndex = 1;
            // 
            // SubmitJobButton
            // 
            this.SubmitJobButton.BackColor = System.Drawing.Color.PowderBlue;
            this.SubmitJobButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitJobButton.Location = new System.Drawing.Point(363, 416);
            this.SubmitJobButton.Name = "SubmitJobButton";
            this.SubmitJobButton.Size = new System.Drawing.Size(143, 33);
            this.SubmitJobButton.TabIndex = 8;
            this.SubmitJobButton.Text = "Submit";
            this.SubmitJobButton.UseVisualStyleBackColor = false;
            this.SubmitJobButton.Click += new System.EventHandler(this.SubmitJobButton_Click);
            // 
            // Requirements
            // 
            this.Requirements.BackColor = System.Drawing.Color.PowderBlue;
            this.Requirements.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Requirements.Location = new System.Drawing.Point(305, 200);
            this.Requirements.Name = "Requirements";
            this.Requirements.Size = new System.Drawing.Size(257, 193);
            this.Requirements.TabIndex = 7;
            this.Requirements.Text = "";
            // 
            // RequirementsLabel
            // 
            this.RequirementsLabel.AutoSize = true;
            this.RequirementsLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequirementsLabel.Location = new System.Drawing.Point(300, 172);
            this.RequirementsLabel.Name = "RequirementsLabel";
            this.RequirementsLabel.Size = new System.Drawing.Size(117, 25);
            this.RequirementsLabel.TabIndex = 33;
            this.RequirementsLabel.Text = "Requirements:";
            // 
            // SizeBox
            // 
            this.SizeBox.BackColor = System.Drawing.Color.PowderBlue;
            this.SizeBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeBox.Location = new System.Drawing.Point(151, 283);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(132, 29);
            this.SizeBox.TabIndex = 3;
            // 
            // WeightBox
            // 
            this.WeightBox.BackColor = System.Drawing.Color.PowderBlue;
            this.WeightBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightBox.Location = new System.Drawing.Point(151, 248);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(132, 29);
            this.WeightBox.TabIndex = 2;
            // 
            // JobIDBox
            // 
            this.JobIDBox.BackColor = System.Drawing.Color.PowderBlue;
            this.JobIDBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobIDBox.Location = new System.Drawing.Point(151, 178);
            this.JobIDBox.Name = "JobIDBox";
            this.JobIDBox.ReadOnly = true;
            this.JobIDBox.Size = new System.Drawing.Size(132, 29);
            this.JobIDBox.TabIndex = 199;
            this.JobIDBox.TabStop = false;
            // 
            // MaterialTypeLabel
            // 
            this.MaterialTypeLabel.AutoSize = true;
            this.MaterialTypeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialTypeLabel.Location = new System.Drawing.Point(40, 318);
            this.MaterialTypeLabel.Name = "MaterialTypeLabel";
            this.MaterialTypeLabel.Size = new System.Drawing.Size(47, 25);
            this.MaterialTypeLabel.TabIndex = 30;
            this.MaterialTypeLabel.Text = "Type";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(39, 283);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(43, 25);
            this.SizeLabel.TabIndex = 27;
            this.SizeLabel.Text = "Size";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(40, 248);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(66, 25);
            this.WeightLabel.TabIndex = 25;
            this.WeightLabel.Text = "Weight";
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialLabel.Location = new System.Drawing.Point(39, 213);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(78, 25);
            this.MaterialLabel.TabIndex = 24;
            this.MaterialLabel.Text = "Material";
            // 
            // JobIDLabel
            // 
            this.JobIDLabel.AutoSize = true;
            this.JobIDLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobIDLabel.Location = new System.Drawing.Point(40, 178);
            this.JobIDLabel.Name = "JobIDLabel";
            this.JobIDLabel.Size = new System.Drawing.Size(79, 25);
            this.JobIDLabel.TabIndex = 21;
            this.JobIDLabel.Text = "Job ID#";
            // 
            // SideBar
            // 
            this.SideBar.Image = global::JSMS.Properties.Resources.BlueSideBar;
            this.SideBar.Location = new System.Drawing.Point(-9, -11);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(42, 499);
            this.SideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SideBar.TabIndex = 16;
            this.SideBar.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Image = global::JSMS.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(25, -1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(284, 161);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 17;
            this.Logo.TabStop = false;
            // 
            // CustomJobLabel
            // 
            this.CustomJobLabel.AutoSize = true;
            this.CustomJobLabel.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomJobLabel.Location = new System.Drawing.Point(355, 85);
            this.CustomJobLabel.Name = "CustomJobLabel";
            this.CustomJobLabel.Size = new System.Drawing.Size(151, 43);
            this.CustomJobLabel.TabIndex = 34;
            this.CustomJobLabel.Text = "Repair Job";
            // 
            // PromiseDate
            // 
            this.PromiseDate.CalendarFont = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromiseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromiseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PromiseDate.Location = new System.Drawing.Point(186, 444);
            this.PromiseDate.Name = "PromiseDate";
            this.PromiseDate.Size = new System.Drawing.Size(97, 22);
            this.PromiseDate.TabIndex = 6;
            // 
            // IssueDatelabel
            // 
            this.IssueDatelabel.AutoSize = true;
            this.IssueDatelabel.BackColor = System.Drawing.Color.Transparent;
            this.IssueDatelabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueDatelabel.Location = new System.Drawing.Point(40, 402);
            this.IssueDatelabel.Name = "IssueDatelabel";
            this.IssueDatelabel.Size = new System.Drawing.Size(99, 25);
            this.IssueDatelabel.TabIndex = 37;
            this.IssueDatelabel.Text = "Issue Date:";
            // 
            // IssueDate
            // 
            this.IssueDate.CalendarFont = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IssueDate.Location = new System.Drawing.Point(186, 404);
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Size = new System.Drawing.Size(97, 22);
            this.IssueDate.TabIndex = 5;
            // 
            // PromiseDateLabel
            // 
            this.PromiseDateLabel.AutoSize = true;
            this.PromiseDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.PromiseDateLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromiseDateLabel.Location = new System.Drawing.Point(40, 442);
            this.PromiseDateLabel.Name = "PromiseDateLabel";
            this.PromiseDateLabel.Size = new System.Drawing.Size(118, 25);
            this.PromiseDateLabel.TabIndex = 39;
            this.PromiseDateLabel.Text = "Promise Date:";
            // 
            // BorderT_R
            // 
            this.BorderT_R.Image = global::JSMS.Properties.Resources.Border_T_R;
            this.BorderT_R.Location = new System.Drawing.Point(518, 0);
            this.BorderT_R.Name = "BorderT_R";
            this.BorderT_R.Size = new System.Drawing.Size(58, 54);
            this.BorderT_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BorderT_R.TabIndex = 40;
            this.BorderT_R.TabStop = false;
            // 
            // StatusBox
            // 
            this.StatusBox.BackColor = System.Drawing.Color.PowderBlue;
            this.StatusBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.Location = new System.Drawing.Point(151, 355);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(132, 29);
            this.StatusBox.TabIndex = 200;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(39, 355);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(72, 25);
            this.StatusLabel.TabIndex = 201;
            this.StatusLabel.Text = "Status :";
            // 
            // RepairJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::JSMS.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 476);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.BorderT_R);
            this.Controls.Add(this.PromiseDateLabel);
            this.Controls.Add(this.IssueDate);
            this.Controls.Add(this.IssueDatelabel);
            this.Controls.Add(this.PromiseDate);
            this.Controls.Add(this.CustomJobLabel);
            this.Controls.Add(this.JewelleryTypeList);
            this.Controls.Add(this.MaterialList);
            this.Controls.Add(this.SubmitJobButton);
            this.Controls.Add(this.Requirements);
            this.Controls.Add(this.RequirementsLabel);
            this.Controls.Add(this.SizeBox);
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.JobIDBox);
            this.Controls.Add(this.MaterialTypeLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.JobIDLabel);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RepairJob";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RepairJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_R)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox JewelleryTypeList;
        private System.Windows.Forms.ComboBox MaterialList;
        private System.Windows.Forms.Button SubmitJobButton;
        private System.Windows.Forms.RichTextBox Requirements;
        private System.Windows.Forms.Label RequirementsLabel;
        private System.Windows.Forms.TextBox SizeBox;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.TextBox JobIDBox;
        private System.Windows.Forms.Label MaterialTypeLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.Label JobIDLabel;
        private System.Windows.Forms.PictureBox SideBar;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label CustomJobLabel;
        private System.Windows.Forms.DateTimePicker PromiseDate;
        private System.Windows.Forms.Label IssueDatelabel;
        private System.Windows.Forms.DateTimePicker IssueDate;
        private System.Windows.Forms.Label PromiseDateLabel;
        private System.Windows.Forms.PictureBox BorderT_R;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.Label StatusLabel;
    }
}