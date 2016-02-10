namespace JSMS
{
    partial class UpdateStatus
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
            this.SatusLabel = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.RichTextBox();
            this.UpdateJobButton = new System.Windows.Forms.Button();
            this.RepairJobRadioButton = new System.Windows.Forms.RadioButton();
            this.IDLabel = new System.Windows.Forms.Label();
            this.CustomJobRadioButton = new System.Windows.Forms.RadioButton();
            this.JobIDBox = new System.Windows.Forms.TextBox();
            this.BorderT_R = new System.Windows.Forms.PictureBox();
            this.SideBar = new System.Windows.Forms.PictureBox();
            this.BorderT_L = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // SatusLabel
            // 
            this.SatusLabel.AutoSize = true;
            this.SatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.SatusLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SatusLabel.Location = new System.Drawing.Point(32, 306);
            this.SatusLabel.Name = "SatusLabel";
            this.SatusLabel.Size = new System.Drawing.Size(74, 28);
            this.SatusLabel.TabIndex = 46;
            this.SatusLabel.Text = "Status:";
            // 
            // StatusBox
            // 
            this.StatusBox.BackColor = System.Drawing.Color.PowderBlue;
            this.StatusBox.DetectUrls = false;
            this.StatusBox.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.Location = new System.Drawing.Point(37, 337);
            this.StatusBox.Multiline = false;
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(235, 49);
            this.StatusBox.TabIndex = 4;
            this.StatusBox.TabStop = false;
            this.StatusBox.Text = "";
            // 
            // UpdateJobButton
            // 
            this.UpdateJobButton.BackColor = System.Drawing.Color.PowderBlue;
            this.UpdateJobButton.Location = new System.Drawing.Point(154, 247);
            this.UpdateJobButton.Name = "UpdateJobButton";
            this.UpdateJobButton.Size = new System.Drawing.Size(108, 35);
            this.UpdateJobButton.TabIndex = 5;
            this.UpdateJobButton.Text = "Update";
            this.UpdateJobButton.UseVisualStyleBackColor = false;
            this.UpdateJobButton.Click += new System.EventHandler(this.UpdateJobButton_Click);
            // 
            // RepairJobRadioButton
            // 
            this.RepairJobRadioButton.AutoSize = true;
            this.RepairJobRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.RepairJobRadioButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepairJobRadioButton.Location = new System.Drawing.Point(37, 265);
            this.RepairJobRadioButton.Name = "RepairJobRadioButton";
            this.RepairJobRadioButton.Size = new System.Drawing.Size(101, 26);
            this.RepairJobRadioButton.TabIndex = 3;
            this.RepairJobRadioButton.TabStop = true;
            this.RepairJobRadioButton.Text = "Repair Job";
            this.RepairJobRadioButton.UseVisualStyleBackColor = false;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(32, 186);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(89, 28);
            this.IDLabel.TabIndex = 44;
            this.IDLabel.Text = "Job ID#";
            // 
            // CustomJobRadioButton
            // 
            this.CustomJobRadioButton.AutoSize = true;
            this.CustomJobRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.CustomJobRadioButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomJobRadioButton.Location = new System.Drawing.Point(37, 233);
            this.CustomJobRadioButton.Name = "CustomJobRadioButton";
            this.CustomJobRadioButton.Size = new System.Drawing.Size(107, 26);
            this.CustomJobRadioButton.TabIndex = 2;
            this.CustomJobRadioButton.TabStop = true;
            this.CustomJobRadioButton.Text = "Custom Job";
            this.CustomJobRadioButton.UseVisualStyleBackColor = false;
            // 
            // JobIDBox
            // 
            this.JobIDBox.BackColor = System.Drawing.Color.PowderBlue;
            this.JobIDBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobIDBox.Location = new System.Drawing.Point(143, 188);
            this.JobIDBox.Name = "JobIDBox";
            this.JobIDBox.Size = new System.Drawing.Size(129, 29);
            this.JobIDBox.TabIndex = 1;
            // 
            // BorderT_R
            // 
            this.BorderT_R.Image = global::JSMS.Properties.Resources.Border_T_R;
            this.BorderT_R.Location = new System.Drawing.Point(228, 0);
            this.BorderT_R.Name = "BorderT_R";
            this.BorderT_R.Size = new System.Drawing.Size(58, 54);
            this.BorderT_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BorderT_R.TabIndex = 47;
            this.BorderT_R.TabStop = false;
            // 
            // SideBar
            // 
            this.SideBar.Image = global::JSMS.Properties.Resources.BlueSideBar;
            this.SideBar.Location = new System.Drawing.Point(-6, -4);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(23, 456);
            this.SideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SideBar.TabIndex = 40;
            this.SideBar.TabStop = false;
            // 
            // BorderT_L
            // 
            this.BorderT_L.Image = global::JSMS.Properties.Resources.Border_T_L;
            this.BorderT_L.Location = new System.Drawing.Point(15, 0);
            this.BorderT_L.Name = "BorderT_L";
            this.BorderT_L.Size = new System.Drawing.Size(58, 54);
            this.BorderT_L.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BorderT_L.TabIndex = 48;
            this.BorderT_L.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Image = global::JSMS.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(37, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(235, 153);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 38;
            this.Logo.TabStop = false;
            // 
            // UpdateStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::JSMS.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(284, 391);
            this.Controls.Add(this.BorderT_R);
            this.Controls.Add(this.SatusLabel);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.UpdateJobButton);
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
            this.Name = "UpdateStatus";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderT_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BorderT_R;
        private System.Windows.Forms.Label SatusLabel;
        private System.Windows.Forms.RichTextBox StatusBox;
        private System.Windows.Forms.Button UpdateJobButton;
        private System.Windows.Forms.RadioButton RepairJobRadioButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.RadioButton CustomJobRadioButton;
        private System.Windows.Forms.TextBox JobIDBox;
        private System.Windows.Forms.PictureBox SideBar;
        private System.Windows.Forms.PictureBox BorderT_L;
        private System.Windows.Forms.PictureBox Logo;
    }
}