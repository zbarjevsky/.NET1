﻿namespace MZ.ControlsWinForms
{
    partial class FormBrowseForFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrowseForFolder));
            this.m_txtSelectedFolder = new System.Windows.Forms.RichTextBox();
            this.m_btnNewFolder = new System.Windows.Forms.Button();
            this.m_btnOk = new System.Windows.Forms.Button();
            this.m_btnCancel = new System.Windows.Forms.Button();
            this.m_txtDescription = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_pnlMain = new System.Windows.Forms.Panel();
            this.m_btnRefresh = new System.Windows.Forms.Button();
            this.m_ctxmnuTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.m_mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.m_mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_mnuRename = new System.Windows.Forms.ToolStripMenuItem();
            this.m_imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.m_treeFolders = new MZ.ControlsWinForms.FoldersTreeUserControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.m_pnlMain.SuspendLayout();
            this.m_ctxmnuTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_txtSelectedFolder
            // 
            this.m_txtSelectedFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtSelectedFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_txtSelectedFolder.Location = new System.Drawing.Point(5, 5);
            this.m_txtSelectedFolder.Multiline = false;
            this.m_txtSelectedFolder.Name = "m_txtSelectedFolder";
            this.m_txtSelectedFolder.ReadOnly = true;
            this.m_txtSelectedFolder.Size = new System.Drawing.Size(260, 14);
            this.m_txtSelectedFolder.TabIndex = 0;
            this.m_txtSelectedFolder.Text = "";
            // 
            // m_btnNewFolder
            // 
            this.m_btnNewFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_btnNewFolder.Image = ((System.Drawing.Image)(resources.GetObject("m_btnNewFolder.Image")));
            this.m_btnNewFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnNewFolder.Location = new System.Drawing.Point(4, 331);
            this.m_btnNewFolder.Name = "m_btnNewFolder";
            this.m_btnNewFolder.Size = new System.Drawing.Size(87, 23);
            this.m_btnNewFolder.TabIndex = 4;
            this.m_btnNewFolder.Text = "New &Folder";
            this.m_btnNewFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_btnNewFolder.UseVisualStyleBackColor = true;
            this.m_btnNewFolder.Click += new System.EventHandler(this.m_btnNewFolder_Click);
            // 
            // m_btnOk
            // 
            this.m_btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_btnOk.Image = ((System.Drawing.Image)(resources.GetObject("m_btnOk.Image")));
            this.m_btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnOk.Location = new System.Drawing.Point(121, 331);
            this.m_btnOk.Name = "m_btnOk";
            this.m_btnOk.Size = new System.Drawing.Size(75, 23);
            this.m_btnOk.TabIndex = 5;
            this.m_btnOk.Text = "&Ok";
            this.m_btnOk.UseVisualStyleBackColor = true;
            this.m_btnOk.Click += new System.EventHandler(this.m_btnOk_Click);
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("m_btnCancel.Image")));
            this.m_btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnCancel.Location = new System.Drawing.Point(202, 331);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(75, 23);
            this.m_btnCancel.TabIndex = 0;
            this.m_btnCancel.Text = "&Cancel";
            this.m_btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_btnCancel.UseVisualStyleBackColor = true;
            this.m_btnCancel.Click += new System.EventHandler(this.m_btnCancel_Click);
            // 
            // m_txtDescription
            // 
            this.m_txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_txtDescription.Location = new System.Drawing.Point(5, 5);
            this.m_txtDescription.Multiline = false;
            this.m_txtDescription.Name = "m_txtDescription";
            this.m_txtDescription.ReadOnly = true;
            this.m_txtDescription.Size = new System.Drawing.Size(221, 14);
            this.m_txtDescription.TabIndex = 0;
            this.m_txtDescription.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.m_txtDescription);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 26);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.m_txtSelectedFolder);
            this.panel2.Location = new System.Drawing.Point(5, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 26);
            this.panel2.TabIndex = 3;
            // 
            // m_pnlMain
            // 
            this.m_pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_pnlMain.Controls.Add(this.m_btnRefresh);
            this.m_pnlMain.Controls.Add(this.m_treeFolders);
            this.m_pnlMain.Controls.Add(this.m_btnNewFolder);
            this.m_pnlMain.Controls.Add(this.m_btnOk);
            this.m_pnlMain.Controls.Add(this.m_btnCancel);
            this.m_pnlMain.Controls.Add(this.panel2);
            this.m_pnlMain.Controls.Add(this.panel1);
            this.m_pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_pnlMain.Location = new System.Drawing.Point(0, 0);
            this.m_pnlMain.Name = "m_pnlMain";
            this.m_pnlMain.Size = new System.Drawing.Size(284, 361);
            this.m_pnlMain.TabIndex = 0;
            // 
            // m_btnRefresh
            // 
            this.m_btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("m_btnRefresh.Image")));
            this.m_btnRefresh.Location = new System.Drawing.Point(243, 4);
            this.m_btnRefresh.Name = "m_btnRefresh";
            this.m_btnRefresh.Size = new System.Drawing.Size(33, 27);
            this.m_btnRefresh.TabIndex = 6;
            this.toolTip1.SetToolTip(this.m_btnRefresh, "Refresh (F5)");
            this.m_btnRefresh.UseVisualStyleBackColor = true;
            this.m_btnRefresh.Click += new System.EventHandler(this.m_mnuRefresh_Click);
            // 
            // m_ctxmnuTree
            // 
            this.m_ctxmnuTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_mnuRefresh,
            this.toolStripMenuItem1,
            this.m_mnuRename,
            this.m_mnuDelete});
            this.m_ctxmnuTree.Name = "m_ctxmnuTree";
            this.m_ctxmnuTree.Size = new System.Drawing.Size(137, 76);
            // 
            // m_mnuRefresh
            // 
            this.m_mnuRefresh.Image = ((System.Drawing.Image)(resources.GetObject("m_mnuRefresh.Image")));
            this.m_mnuRefresh.Name = "m_mnuRefresh";
            this.m_mnuRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.m_mnuRefresh.Size = new System.Drawing.Size(180, 22);
            this.m_mnuRefresh.Text = "&Refresh";
            this.m_mnuRefresh.Click += new System.EventHandler(this.m_mnuRefresh_Click);
            // 
            // m_mnuDelete
            // 
            this.m_mnuDelete.Image = ((System.Drawing.Image)(resources.GetObject("m_mnuDelete.Image")));
            this.m_mnuDelete.Name = "m_mnuDelete";
            this.m_mnuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.m_mnuDelete.Size = new System.Drawing.Size(180, 22);
            this.m_mnuDelete.Text = "&Delete";
            this.m_mnuDelete.Click += new System.EventHandler(this.m_mnuDelete_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // m_mnuRename
            // 
            this.m_mnuRename.Image = ((System.Drawing.Image)(resources.GetObject("m_mnuRename.Image")));
            this.m_mnuRename.Name = "m_mnuRename";
            this.m_mnuRename.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.m_mnuRename.Size = new System.Drawing.Size(180, 22);
            this.m_mnuRename.Text = "Re&name";
            this.m_mnuRename.Click += new System.EventHandler(this.m_mnuRename_Click);
            // 
            // m_imageListIcons
            // 
            this.m_imageListIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.m_imageListIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.m_imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // m_treeFolders
            // 
            this.m_treeFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_treeFolders.ContextMenuStrip = this.m_ctxmnuTree;
            this.m_treeFolders.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_treeFolders.Location = new System.Drawing.Point(5, 36);
            this.m_treeFolders.Name = "m_treeFolders";
            this.m_treeFolders.Size = new System.Drawing.Size(272, 257);
            this.m_treeFolders.TabIndex = 0;
            // 
            // FormBrowseForFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.m_pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "FormBrowseForFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Browse For Folder";
            this.Load += new System.EventHandler(this.FormBrowseForFolder_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.m_pnlMain.ResumeLayout(false);
            this.m_ctxmnuTree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FoldersTreeUserControl m_treeFolders;
        private System.Windows.Forms.RichTextBox m_txtSelectedFolder;
        private System.Windows.Forms.Button m_btnNewFolder;
        private System.Windows.Forms.Button m_btnOk;
        private System.Windows.Forms.Button m_btnCancel;
        private System.Windows.Forms.RichTextBox m_txtDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel m_pnlMain;
        private System.Windows.Forms.Button m_btnRefresh;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip m_ctxmnuTree;
        private System.Windows.Forms.ToolStripMenuItem m_mnuRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem m_mnuRename;
        private System.Windows.Forms.ToolStripMenuItem m_mnuDelete;
        private System.Windows.Forms.ImageList m_imageListIcons;
    }
}