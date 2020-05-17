﻿namespace MZ.ControlsWinForms
{
    partial class FileExplorerUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileExplorerUserControl));
            this.m_listFiles = new System.Windows.Forms.ListView();
            this.m_imageListTreeView = new System.Windows.Forms.ImageList(this.components);
            this.m_pnlCommands = new System.Windows.Forms.Panel();
            this.m_btnRoot = new System.Windows.Forms.Button();
            this.m_btnUp = new System.Windows.Forms.Button();
            this.m_txtPath = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.m_pnlCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_listFiles
            // 
            this.m_listFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_listFiles.FullRowSelect = true;
            this.m_listFiles.GridLines = true;
            this.m_listFiles.HideSelection = false;
            this.m_listFiles.Location = new System.Drawing.Point(0, 29);
            this.m_listFiles.Name = "m_listFiles";
            this.m_listFiles.Size = new System.Drawing.Size(235, 466);
            this.m_listFiles.SmallImageList = this.m_imageListTreeView;
            this.m_listFiles.TabIndex = 0;
            this.m_listFiles.UseCompatibleStateImageBehavior = false;
            this.m_listFiles.View = System.Windows.Forms.View.Details;
            this.m_listFiles.VirtualMode = true;
            this.m_listFiles.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.m_listFiles_RetrieveVirtualItem);
            this.m_listFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.m_listFiles_MouseDoubleClick);
            // 
            // m_imageListTreeView
            // 
            this.m_imageListTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_imageListTreeView.ImageStream")));
            this.m_imageListTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.m_imageListTreeView.Images.SetKeyName(0, "");
            this.m_imageListTreeView.Images.SetKeyName(1, "");
            this.m_imageListTreeView.Images.SetKeyName(2, "");
            this.m_imageListTreeView.Images.SetKeyName(3, "");
            this.m_imageListTreeView.Images.SetKeyName(4, "");
            this.m_imageListTreeView.Images.SetKeyName(5, "");
            this.m_imageListTreeView.Images.SetKeyName(6, "");
            this.m_imageListTreeView.Images.SetKeyName(7, "");
            this.m_imageListTreeView.Images.SetKeyName(8, "");
            this.m_imageListTreeView.Images.SetKeyName(9, "Copy.ico");
            // 
            // m_pnlCommands
            // 
            this.m_pnlCommands.Controls.Add(this.m_btnRoot);
            this.m_pnlCommands.Controls.Add(this.m_btnUp);
            this.m_pnlCommands.Controls.Add(this.m_txtPath);
            this.m_pnlCommands.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnlCommands.Location = new System.Drawing.Point(0, 0);
            this.m_pnlCommands.Name = "m_pnlCommands";
            this.m_pnlCommands.Size = new System.Drawing.Size(235, 29);
            this.m_pnlCommands.TabIndex = 1;
            // 
            // m_btnRoot
            // 
            this.m_btnRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRoot.Location = new System.Drawing.Point(178, 2);
            this.m_btnRoot.Name = "m_btnRoot";
            this.m_btnRoot.Size = new System.Drawing.Size(25, 20);
            this.m_btnRoot.TabIndex = 4;
            this.m_btnRoot.Text = "/";
            this.toolTip1.SetToolTip(this.m_btnRoot, "Drive Root");
            this.m_btnRoot.UseVisualStyleBackColor = true;
            this.m_btnRoot.Click += new System.EventHandler(this.m_btnRoot_Click);
            // 
            // m_btnUp
            // 
            this.m_btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnUp.Location = new System.Drawing.Point(207, 2);
            this.m_btnUp.Name = "m_btnUp";
            this.m_btnUp.Size = new System.Drawing.Size(25, 20);
            this.m_btnUp.TabIndex = 3;
            this.m_btnUp.Text = "..";
            this.toolTip1.SetToolTip(this.m_btnUp, "Folder UP");
            this.m_btnUp.UseVisualStyleBackColor = true;
            this.m_btnUp.Click += new System.EventHandler(this.m_btnBrowse_Click);
            // 
            // m_txtPath
            // 
            this.m_txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtPath.Location = new System.Drawing.Point(3, 3);
            this.m_txtPath.Name = "m_txtPath";
            this.m_txtPath.ReadOnly = true;
            this.m_txtPath.Size = new System.Drawing.Size(167, 20);
            this.m_txtPath.TabIndex = 2;
            // 
            // FileExplorerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_listFiles);
            this.Controls.Add(this.m_pnlCommands);
            this.Name = "FileExplorerUserControl";
            this.Size = new System.Drawing.Size(235, 495);
            this.Load += new System.EventHandler(this.FileExplorerUserControl_Load);
            this.m_pnlCommands.ResumeLayout(false);
            this.m_pnlCommands.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView m_listFiles;
        private System.Windows.Forms.ImageList m_imageListTreeView;
        private System.Windows.Forms.Panel m_pnlCommands;
        private System.Windows.Forms.Button m_btnRoot;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button m_btnUp;
        private System.Windows.Forms.TextBox m_txtPath;
    }
}
