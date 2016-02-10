namespace JSMS
{
    partial class NewsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewsForm));
            this.Searchbar = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Homebtn = new System.Windows.Forms.Button();
            this.Reloadbtn = new System.Windows.Forms.Button();
            this.Nextbtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Searchbar
            // 
            this.Searchbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Searchbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Searchbar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Searchbar.Location = new System.Drawing.Point(180, 4);
            this.Searchbar.Name = "Searchbar";
            this.Searchbar.Size = new System.Drawing.Size(674, 35);
            this.Searchbar.TabIndex = 14;
            this.Searchbar.Text = "www.";
            this.Searchbar.WordWrap = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(2, 47);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(897, 468);
            this.webBrowser1.TabIndex = 13;
            this.webBrowser1.Url = new System.Uri("http://www.goldrates.pk", System.UriKind.Absolute);
            // 
            // Searchbtn
            // 
            this.Searchbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Searchbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Searchbtn.BackgroundImage")));
            this.Searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Searchbtn.Location = new System.Drawing.Point(860, 2);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(39, 39);
            this.Searchbtn.TabIndex = 15;
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Homebtn
            // 
            this.Homebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Homebtn.BackgroundImage")));
            this.Homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Homebtn.Location = new System.Drawing.Point(135, 2);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(39, 39);
            this.Homebtn.TabIndex = 16;
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // Reloadbtn
            // 
            this.Reloadbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Reloadbtn.BackgroundImage")));
            this.Reloadbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Reloadbtn.Location = new System.Drawing.Point(90, 2);
            this.Reloadbtn.Name = "Reloadbtn";
            this.Reloadbtn.Size = new System.Drawing.Size(39, 39);
            this.Reloadbtn.TabIndex = 17;
            this.Reloadbtn.UseVisualStyleBackColor = true;
            this.Reloadbtn.Click += new System.EventHandler(this.Reloadbtn_Click);
            // 
            // Nextbtn
            // 
            this.Nextbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Nextbtn.BackgroundImage")));
            this.Nextbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nextbtn.Location = new System.Drawing.Point(45, 2);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(39, 39);
            this.Nextbtn.TabIndex = 18;
            this.Nextbtn.UseVisualStyleBackColor = true;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Backbtn.BackgroundImage")));
            this.Backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Backbtn.Location = new System.Drawing.Point(2, 2);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(39, 39);
            this.Backbtn.TabIndex = 19;
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // NewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 516);
            this.Controls.Add(this.Searchbar);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.Homebtn);
            this.Controls.Add(this.Reloadbtn);
            this.Controls.Add(this.Nextbtn);
            this.Controls.Add(this.Backbtn);
            this.Name = "NewsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Searchbar;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.Button Reloadbtn;
        private System.Windows.Forms.Button Nextbtn;
        private System.Windows.Forms.Button Backbtn;

    }
}