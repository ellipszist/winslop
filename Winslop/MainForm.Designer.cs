namespace Winslop
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.rtbLogger = new System.Windows.Forms.RichTextBox();
            this.comboLogActions = new System.Windows.Forms.ComboBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Windows = new System.Windows.Forms.TabPage();
            this.Apps = new System.Windows.Forms.TabPage();
            this.Extensions = new System.Windows.Forms.TabPage();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuPlugins = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelContainer.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.Teal;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.panelContent);
            this.panelContainer.Location = new System.Drawing.Point(3, 40);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(480, 485);
            this.panelContainer.TabIndex = 198;
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.AutoScroll = true;
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panelContent.Controls.Add(this.rtbLogger);
            this.panelContent.Controls.Add(this.comboLogActions);
            this.panelContent.Controls.Add(this.btnAnalyze);
            this.panelContent.Controls.Add(this.tabControl);
            this.panelContent.Controls.Add(this.btnFix);
            this.panelContent.Location = new System.Drawing.Point(19, 20);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(442, 454);
            this.panelContent.TabIndex = 205;
            // 
            // rtbLogger
            // 
            this.rtbLogger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLogger.BackColor = System.Drawing.Color.White;
            this.rtbLogger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLogger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLogger.Location = new System.Drawing.Point(7, 240);
            this.rtbLogger.Name = "rtbLogger";
            this.rtbLogger.ReadOnly = true;
            this.rtbLogger.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLogger.ShowSelectionMargin = true;
            this.rtbLogger.Size = new System.Drawing.Size(426, 142);
            this.rtbLogger.TabIndex = 195;
            this.rtbLogger.TabStop = false;
            this.rtbLogger.Text = "";
            this.toolTip.SetToolTip(this.rtbLogger, "Inspection output will appear here.");
            // 
            // comboLogActions
            // 
            this.comboLogActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboLogActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comboLogActions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLogActions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboLogActions.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLogActions.FormattingEnabled = true;
            this.comboLogActions.Location = new System.Drawing.Point(7, 388);
            this.comboLogActions.Name = "comboLogActions";
            this.comboLogActions.Size = new System.Drawing.Size(426, 24);
            this.comboLogActions.TabIndex = 210;
            this.comboLogActions.TabStop = false;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnalyze.AutoEllipsis = true;
            this.btnAnalyze.BackColor = System.Drawing.Color.Transparent;
            this.btnAnalyze.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.btnAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnAnalyze.Location = new System.Drawing.Point(7, 418);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(121, 29);
            this.btnAnalyze.TabIndex = 1;
            this.btnAnalyze.Text = "&Inspect system";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.Windows);
            this.tabControl.Controls.Add(this.Apps);
            this.tabControl.Controls.Add(this.Extensions);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.HotTrack = true;
            this.tabControl.ItemSize = new System.Drawing.Size(68, 28);
            this.tabControl.Location = new System.Drawing.Point(7, 8);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(426, 231);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 199;
            this.tabControl.TabStop = false;
            // 
            // Windows
            // 
            this.Windows.AutoScroll = true;
            this.Windows.BackColor = System.Drawing.Color.White;
            this.Windows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Windows.Location = new System.Drawing.Point(4, 32);
            this.Windows.Name = "Windows";
            this.Windows.Size = new System.Drawing.Size(418, 195);
            this.Windows.TabIndex = 0;
            this.Windows.Text = "Windows";
            this.Windows.UseVisualStyleBackColor = true;
            // 
            // Apps
            // 
            this.Apps.BackColor = System.Drawing.SystemColors.Control;
            this.Apps.Location = new System.Drawing.Point(4, 32);
            this.Apps.Name = "Apps";
            this.Apps.Size = new System.Drawing.Size(418, 195);
            this.Apps.TabIndex = 1;
            this.Apps.Text = "Applications";
            this.Apps.UseVisualStyleBackColor = true;
            // 
            // Extensions
            // 
            this.Extensions.Location = new System.Drawing.Point(4, 32);
            this.Extensions.Name = "Extensions";
            this.Extensions.Size = new System.Drawing.Size(418, 195);
            this.Extensions.TabIndex = 2;
            this.Extensions.Text = "Extensions";
            // 
            // btnFix
            // 
            this.btnFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFix.AutoEllipsis = true;
            this.btnFix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.btnFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnFix.Location = new System.Drawing.Point(247, 418);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(185, 29);
            this.btnFix.TabIndex = 2;
            this.btnFix.TabStop = false;
            this.btnFix.Text = "Apply selected changes";
            this.btnFix.UseVisualStyleBackColor = false;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F);
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(4, 10);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 23);
            this.btnMenu.TabIndex = 201;
            this.btnMenu.TabStop = false;
            this.btnMenu.Text = "Menu";
            this.toolTip.SetToolTip(this.btnMenu, "Menu");
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.AutoSize = true;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(210)))));
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.Crimson;
            this.btnAbout.Location = new System.Drawing.Point(445, 10);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(34, 23);
            this.btnAbout.TabIndex = 211;
            this.btnAbout.TabStop = false;
            this.btnAbout.Text = "...";
            this.toolTip.SetToolTip(this.btnAbout, "About this app");
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuToggle,
            this.toolStripSeparator2,
            this.toolStripMenuImport,
            this.toolStripMenuExport,
            this.toolStripSeparator1,
            this.toolStripMenuRestore,
            this.toolStripMenuPlugins,
            this.toolStripSeparator3,
            this.toolStripMenuAbout});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenu.Size = new System.Drawing.Size(172, 154);
            // 
            // toolStripMenuToggle
            // 
            this.toolStripMenuToggle.Name = "toolStripMenuToggle";
            this.toolStripMenuToggle.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuToggle.Text = "Toggle all";
            this.toolStripMenuToggle.Click += new System.EventHandler(this.toolStripMenuSelection_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // toolStripMenuImport
            // 
            this.toolStripMenuImport.Name = "toolStripMenuImport";
            this.toolStripMenuImport.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuImport.Text = "Import";
            this.toolStripMenuImport.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // toolStripMenuExport
            // 
            this.toolStripMenuExport.Name = "toolStripMenuExport";
            this.toolStripMenuExport.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuExport.Text = "Export";
            this.toolStripMenuExport.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // toolStripMenuRestore
            // 
            this.toolStripMenuRestore.Name = "toolStripMenuRestore";
            this.toolStripMenuRestore.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuRestore.Text = "Undo last changes";
            this.toolStripMenuRestore.Click += new System.EventHandler(this.toolStripMenuRestore_Click);
            // 
            // toolStripMenuPlugins
            // 
            this.toolStripMenuPlugins.Name = "toolStripMenuPlugins";
            this.toolStripMenuPlugins.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuPlugins.Tag = "Tools";
            this.toolStripMenuPlugins.Text = "Manage plugins...";
            this.toolStripMenuPlugins.Click += new System.EventHandler(this.toolStripMenuPlugins_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // toolStripMenuAbout
            // 
            this.toolStripMenuAbout.Enabled = false;
            this.toolStripMenuAbout.Name = "toolStripMenuAbout";
            this.toolStripMenuAbout.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuAbout.Tag = "About";
            this.toolStripMenuAbout.Text = "About";
            // 
            // textSearch
            // 
            this.textSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSearch.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9.5F);
            this.textSearch.ForeColor = System.Drawing.Color.DimGray;
            this.textSearch.Location = new System.Drawing.Point(141, 10);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(222, 24);
            this.textSearch.TabIndex = 520;
            this.textSearch.Text = "Search";
            this.textSearch.Click += new System.EventHandler(this.textSearch_Click);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(484, 546);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.panelContainer);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winslop.exe";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panelContainer.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Windows;
        private System.Windows.Forms.TabPage Apps;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRestore;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPlugins;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuToggle;
        public System.Windows.Forms.RichTextBox rtbLogger;
        private System.Windows.Forms.ComboBox comboLogActions;
        private System.Windows.Forms.TabPage Extensions;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuImport;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

