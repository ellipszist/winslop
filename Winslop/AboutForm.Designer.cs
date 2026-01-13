namespace Winslop
{
    partial class AboutForm
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
            this.btnDonate = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblVersionInfo = new System.Windows.Forms.Label();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.border = new System.Windows.Forms.Label();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDonate
            // 
            this.btnDonate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDonate.AutoEllipsis = true;
            this.btnDonate.BackColor = System.Drawing.Color.Transparent;
            this.btnDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonate.FlatAppearance.BorderSize = 0;
            this.btnDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnDonate.ForeColor = System.Drawing.Color.Black;
            this.btnDonate.Location = new System.Drawing.Point(69, 182);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(315, 51);
            this.btnDonate.TabIndex = 240;
            this.btnDonate.TabStop = false;
            this.btnDonate.Text = "Support a newborn app 🐣 \r\nThis app is built to remove things, not to impress you" +
    ".\r\nIf you appreciate simple, honest software, consider a donation.";
            this.btnDonate.UseVisualStyleBackColor = false;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(78, 31);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(63, 22);
            this.lblHeader.TabIndex = 235;
            this.lblHeader.Text = "Winslop";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader.UseCompatibleTextRendering = true;
            // 
            // lblVersionInfo
            // 
            this.lblVersionInfo.AutoSize = true;
            this.lblVersionInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblVersionInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersionInfo.ForeColor = System.Drawing.Color.Black;
            this.lblVersionInfo.Location = new System.Drawing.Point(78, 55);
            this.lblVersionInfo.Name = "lblVersionInfo";
            this.lblVersionInfo.Size = new System.Drawing.Size(13, 13);
            this.lblVersionInfo.TabIndex = 238;
            this.lblVersionInfo.Text = "v";
            this.lblVersionInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.Silver;
            this.panelSettings.Controls.Add(this.pictureBox1);
            this.panelSettings.Controls.Add(this.border);
            this.panelSettings.Controls.Add(this.linkGithub);
            this.panelSettings.Controls.Add(this.button1);
            this.panelSettings.Controls.Add(this.lblCopyright);
            this.panelSettings.Controls.Add(this.btnDonate);
            this.panelSettings.Controls.Add(this.lblHeader);
            this.panelSettings.Controls.Add(this.lblVersionInfo);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSettings.ForeColor = System.Drawing.Color.White;
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(396, 307);
            this.panelSettings.TabIndex = 243;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Winslop.Properties.Resources.AppLogo64;
            this.pictureBox1.Location = new System.Drawing.Point(6, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 64);
            this.pictureBox1.TabIndex = 245;
            this.pictureBox1.TabStop = false;
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.Black;
            this.border.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.border.ForeColor = System.Drawing.Color.Black;
            this.border.Location = new System.Drawing.Point(75, 157);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(305, 1);
            this.border.TabIndex = 244;
            // 
            // linkGithub
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.linkGithub.Location = new System.Drawing.Point(78, 119);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(224, 13);
            this.linkGithub.TabIndex = 243;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "https://github.com/builtbybel/Winslop";
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithub_LinkClicked);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(299, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblCopyright.ForeColor = System.Drawing.Color.Black;
            this.lblCopyright.Location = new System.Drawing.Point(78, 74);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(196, 13);
            this.lblCopyright.TabIndex = 241;
            this.lblCopyright.Text = "Copyright (c) 2026, A Belim app creation";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 307);
            this.Controls.Add(this.panelSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Winslop";
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblVersionInfo;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.Label border;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}