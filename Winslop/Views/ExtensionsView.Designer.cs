namespace Winslop.Extensions
{
    partial class ExtensionsView
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanelTools = new System.Windows.Forms.FlowLayoutPanel();
            this.contextDropDown = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuWriteExtension = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuExtensionDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMoreOptions = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboFilter = new System.Windows.Forms.ComboBox();
            this.contextDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelTools
            // 
            this.flowLayoutPanelTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelTools.AutoScroll = true;
            this.flowLayoutPanelTools.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelTools.Location = new System.Drawing.Point(3, 46);
            this.flowLayoutPanelTools.Name = "flowLayoutPanelTools";
            this.flowLayoutPanelTools.Size = new System.Drawing.Size(471, 332);
            this.flowLayoutPanelTools.TabIndex = 0;
            // 
            // contextDropDown
            // 
            this.contextDropDown.Font = new System.Drawing.Font("Segoe UI Variable Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextDropDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripMenuWriteExtension,
            this.toolStripMenuExtensionDirectory});
            this.contextDropDown.Name = "contextMenuStripAdd";
            this.contextDropDown.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextDropDown.Size = new System.Drawing.Size(172, 80);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripMenuWriteExtension
            // 
            this.toolStripMenuWriteExtension.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuWriteExtension.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toolStripMenuWriteExtension.Name = "toolStripMenuWriteExtension";
            this.toolStripMenuWriteExtension.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuWriteExtension.Text = "Write an extension";
            this.toolStripMenuWriteExtension.Click += new System.EventHandler(this.toolStripMenuWriteExtension_Click);
            // 
            // toolStripMenuExtensionDirectory
            // 
            this.toolStripMenuExtensionDirectory.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuExtensionDirectory.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toolStripMenuExtensionDirectory.Name = "toolStripMenuExtensionDirectory";
            this.toolStripMenuExtensionDirectory.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuExtensionDirectory.Text = "Extension folder...";
            this.toolStripMenuExtensionDirectory.Click += new System.EventHandler(this.toolStripMenuExtensionDirectory_Click);
            // 
            // btnMoreOptions
            // 
            this.btnMoreOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoreOptions.AutoEllipsis = true;
            this.btnMoreOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnMoreOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoreOptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnMoreOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnMoreOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnMoreOptions.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.25F);
            this.btnMoreOptions.ForeColor = System.Drawing.Color.Black;
            this.btnMoreOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoreOptions.Location = new System.Drawing.Point(441, 8);
            this.btnMoreOptions.Name = "btnMoreOptions";
            this.btnMoreOptions.Size = new System.Drawing.Size(33, 23);
            this.btnMoreOptions.TabIndex = 350;
            this.btnMoreOptions.Text = "...";
            this.btnMoreOptions.UseVisualStyleBackColor = false;
            this.btnMoreOptions.Click += new System.EventHandler(this.btnMoreOptions_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoEllipsis = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(0, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(339, 18);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Loading...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.UseCompatibleTextRendering = true;
            this.lblStatus.Visible = false;
            // 
            // comboFilter
            // 
            this.comboFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFilter.BackColor = System.Drawing.Color.White;
            this.comboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboFilter.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 8F);
            this.comboFilter.ForeColor = System.Drawing.Color.Black;
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.Location = new System.Drawing.Point(364, 8);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(71, 23);
            this.comboFilter.TabIndex = 351;
            this.comboFilter.TabStop = false;
            this.comboFilter.SelectedIndexChanged += new System.EventHandler(this.comboFilter_SelectedIndexChanged);
            // 
            // ExtensionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.comboFilter);
            this.Controls.Add(this.btnMoreOptions);
            this.Controls.Add(this.flowLayoutPanelTools);
            this.Name = "ExtensionsView";
            this.Size = new System.Drawing.Size(477, 398);
            this.contextDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTools;
        private System.Windows.Forms.ContextMenuStrip contextDropDown;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuWriteExtension;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExtensionDirectory;
        private System.Windows.Forms.Button btnMoreOptions;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}
