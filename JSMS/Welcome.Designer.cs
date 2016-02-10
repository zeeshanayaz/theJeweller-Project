namespace JSMS
{
    partial class Welcome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.WelcmeLbael = new System.Windows.Forms.Label();
            this.ConnectivityInfo = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SideBar = new System.Windows.Forms.PictureBox();
            this.Circle = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcmeLbael
            // 
            this.WelcmeLbael.AutoSize = true;
            this.WelcmeLbael.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcmeLbael.Location = new System.Drawing.Point(236, 318);
            this.WelcmeLbael.Name = "WelcmeLbael";
            this.WelcmeLbael.Size = new System.Drawing.Size(130, 43);
            this.WelcmeLbael.TabIndex = 2;
            this.WelcmeLbael.Text = "Welcome";
            // 
            // ConnectivityInfo
            // 
            this.ConnectivityInfo.AutoSize = true;
            this.ConnectivityInfo.BackColor = System.Drawing.Color.Transparent;
            this.ConnectivityInfo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectivityInfo.ForeColor = System.Drawing.Color.Black;
            this.ConnectivityInfo.Location = new System.Drawing.Point(39, 497);
            this.ConnectivityInfo.Name = "ConnectivityInfo";
            this.ConnectivityInfo.Size = new System.Drawing.Size(0, 22);
            this.ConnectivityInfo.TabIndex = 3;
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 190;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 23.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Version 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "2015 TheJeweller\r\nAll Rights Reserved";
            // 
            // SideBar
            // 
            this.SideBar.Image = global::JSMS.Properties.Resources.BlueSideBar;
            this.SideBar.Location = new System.Drawing.Point(-4, -6);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(37, 623);
            this.SideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SideBar.TabIndex = 6;
            this.SideBar.TabStop = false;
            // 
            // Circle
            // 
            this.Circle.Image = global::JSMS.Properties.Resources.Circle;
            this.Circle.Location = new System.Drawing.Point(94, 302);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(111, 72);
            this.Circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Circle.TabIndex = 1;
            this.Circle.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JSMS.Properties.Resources.BlueArrow;
            this.pictureBox1.Location = new System.Drawing.Point(9, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Image = global::JSMS.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(55, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(351, 228);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(24, 563);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::JSMS.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(460, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.ConnectivityInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelcmeLbael);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.SideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox Circle;
        private System.Windows.Forms.Label WelcmeLbael;
        private System.Windows.Forms.Label ConnectivityInfo;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SideBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
    }
}