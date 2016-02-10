namespace JSMS
{
    partial class CheckStatus
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
            this.Logo = new System.Windows.Forms.PictureBox();
            this.SideBar = new System.Windows.Forms.PictureBox();
            this.JobIDBox = new System.Windows.Forms.TextBox();
            this.CustomJobRadioButton = new System.Windows.Forms.RadioButton();
            this.IDLabel = new System.Windows.Forms.Label();
            this.RepairJobRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchJobButton = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.RichTextBox();
            this.SatusLabel = new System.Windows.Forms.Label();
            this.BorderT_R = new System.Windows.Forms.PictureBox();
            this.BorderT_L = new System.Windows.Forms.PictureBox();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_L)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = global::JSMS.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(38, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(235, 153);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // SideBar
            // 
            this.SideBar.Image = global::JSMS.Properties.Resources.BlueSideBar;
            this.SideBar.Location = new System.Drawing.Point(-5, -4);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(23, 456);
            this.SideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SideBar.TabIndex = 1;
            this.SideBar.TabStop = false;
            // 
            // JobIDBox
            // 
            this.JobIDBox.BackColor = System.Drawing.Color.PowderBlue;
            this.JobIDBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobIDBox.Location = new System.Drawing.Point(144, 188);
            this.JobIDBox.Name = "JobIDBox";
            this.JobIDBox.Size = new System.Drawing.Size(129, 29);
            this.JobIDBox.TabIndex = 1;
            // 
            // CustomJobRadioButton
            // 
            this.CustomJobRadioButton.AutoSize = true;
            this.CustomJobRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.CustomJobRadioButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomJobRadioButton.Location = new System.Drawing.Point(38, 233);
            this.CustomJobRadioButton.Name = "CustomJobRadioButton";
            this.CustomJobRadioButton.Size = new System.Drawing.Size(107, 26);
            this.CustomJobRadioButton.TabIndex = 2;
            this.CustomJobRadioButton.TabStop = true;
            this.CustomJobRadioButton.Text = "Custom Job";
            this.CustomJobRadioButton.UseVisualStyleBackColor = false;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(33, 186);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(89, 28);
            this.IDLabel.TabIndex = 4;
            this.IDLabel.Text = "Job ID#";
            // 
            // RepairJobRadioButton
            // 
            this.RepairJobRadioButton.AutoSize = true;
            this.RepairJobRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.RepairJobRadioButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepairJobRadioButton.Location = new System.Drawing.Point(38, 265);
            this.RepairJobRadioButton.Name = "RepairJobRadioButton";
            this.RepairJobRadioButton.Size = new System.Drawing.Size(101, 26);
            this.RepairJobRadioButton.TabIndex = 3;
            this.RepairJobRadioButton.TabStop = true;
            this.RepairJobRadioButton.Text = "Repair Job";
            this.RepairJobRadioButton.UseVisualStyleBackColor = false;
            // 
            // SearchJobButton
            // 
            this.SearchJobButton.BackColor = System.Drawing.Color.PowderBlue;
            this.SearchJobButton.Location = new System.Drawing.Point(155, 247);
            this.SearchJobButton.Name = "SearchJobButton";
            this.SearchJobButton.Size = new System.Drawing.Size(108, 35);
            this.SearchJobButton.TabIndex = 4;
            this.SearchJobButton.Text = "Search";
            this.SearchJobButton.UseVisualStyleBackColor = false;
            this.SearchJobButton.Click += new System.EventHandler(this.SearchJobButton_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.DetectUrls = false;
            this.StatusBox.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.Location = new System.Drawing.Point(38, 337);
            this.StatusBox.Multiline = false;
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.Size = new System.Drawing.Size(235, 49);
            this.StatusBox.TabIndex = 7;
            this.StatusBox.TabStop = false;
            this.StatusBox.Text = "";
            // 
            // SatusLabel
            // 
            this.SatusLabel.AutoSize = true;
            this.SatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.SatusLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SatusLabel.Location = new System.Drawing.Point(33, 306);
            this.SatusLabel.Name = "SatusLabel";
            this.SatusLabel.Size = new System.Drawing.Size(74, 28);
            this.SatusLabel.TabIndex = 8;
            this.SatusLabel.Text = "Status:";
            // 
            // BorderT_R
            // 
            this.BorderT_R.Image = global::JSMS.Properties.Resources.Border_T_R;
            this.BorderT_R.Location = new System.Drawing.Point(229, 0);
            this.BorderT_R.Name = "BorderT_R";
            this.BorderT_R.Size = new System.Drawing.Size(58, 54);
            this.BorderT_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BorderT_R.TabIndex = 36;
            this.BorderT_R.TabStop = false;
            // 
            // BorderT_L
            // 
            this.BorderT_L.Image = global::JSMS.Properties.Resources.Border_T_L;
            this.BorderT_L.Location = new System.Drawing.Point(16, 0);
            this.BorderT_L.Name = "BorderT_L";
            this.BorderT_L.Size = new System.Drawing.Size(58, 54);
            this.BorderT_L.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BorderT_L.TabIndex = 37;
            this.BorderT_L.TabStop = false;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.PowderBlue;
            this.ClearButton.Location = new System.Drawing.Point(155, 294);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(108, 35);
            this.ClearButton.TabIndex = 38;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CheckStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::JSMS.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(284, 391);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.BorderT_R);
            this.Controls.Add(this.SatusLabel);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.SearchJobButton);
            this.Controls.Add(this.RepairJobRadioButton);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.CustomJobRadioButton);
            this.Controls.Add(this.JobIDBox);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.BorderT_L);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckStatus";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_L)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox SideBar;
        private System.Windows.Forms.TextBox JobIDBox;
        private System.Windows.Forms.RadioButton CustomJobRadioButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.RadioButton RepairJobRadioButton;
        private System.Windows.Forms.Button SearchJobButton;
        private System.Windows.Forms.RichTextBox StatusBox;
        private System.Windows.Forms.Label SatusLabel;
        private System.Windows.Forms.PictureBox BorderT_R;
        private System.Windows.Forms.PictureBox BorderT_L;
        private System.Windows.Forms.Button ClearButton;
    }
}