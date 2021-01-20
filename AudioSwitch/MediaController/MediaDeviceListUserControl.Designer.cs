﻿namespace MkZ.Media
{
    partial class MediaDeviceListUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaDeviceListUserControl));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Connected", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Unplugged", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Disabled", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Not Present", System.Windows.Forms.HorizontalAlignment.Left);
            this.m_btnActivate = new System.Windows.Forms.Button();
            this.m_btnRefresh = new System.Windows.Forms.Button();
            this.m_mnuDevices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.m_mnuActivate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_mnuMute = new System.Windows.Forms.ToolStripMenuItem();
            this.m_imageListMute = new System.Windows.Forms.ImageList(this.components);
            this.m_listDevices = new ListViewExtensions.ListViewCollapsibleGroups();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_mnuDevices.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_btnActivate
            // 
            this.m_btnActivate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnActivate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnActivate.Location = new System.Drawing.Point(0, 272);
            this.m_btnActivate.Name = "m_btnActivate";
            this.m_btnActivate.Size = new System.Drawing.Size(502, 27);
            this.m_btnActivate.TabIndex = 1;
            this.m_btnActivate.Text = "Set Active: ";
            this.m_btnActivate.UseVisualStyleBackColor = true;
            this.m_btnActivate.Click += new System.EventHandler(this.m_btnActivate_Click);
            // 
            // m_btnRefresh
            // 
            this.m_btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("m_btnRefresh.Image")));
            this.m_btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnRefresh.Location = new System.Drawing.Point(508, 272);
            this.m_btnRefresh.Name = "m_btnRefresh";
            this.m_btnRefresh.Size = new System.Drawing.Size(68, 27);
            this.m_btnRefresh.TabIndex = 2;
            this.m_btnRefresh.Text = "Refresh";
            this.m_btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_btnRefresh.UseVisualStyleBackColor = true;
            this.m_btnRefresh.Click += new System.EventHandler(this.m_btnRefresh_Click);
            // 
            // m_mnuDevices
            // 
            this.m_mnuDevices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_mnuActivate,
            this.toolStripMenuItem1,
            this.m_mnuMute});
            this.m_mnuDevices.Name = "m_mnuDevices";
            this.m_mnuDevices.Size = new System.Drawing.Size(118, 54);
            // 
            // m_mnuActivate
            // 
            this.m_mnuActivate.Name = "m_mnuActivate";
            this.m_mnuActivate.Size = new System.Drawing.Size(117, 22);
            this.m_mnuActivate.Text = "&Activate";
            this.m_mnuActivate.Click += new System.EventHandler(this.m_mnuActivate_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 6);
            // 
            // m_mnuMute
            // 
            this.m_mnuMute.Name = "m_mnuMute";
            this.m_mnuMute.Size = new System.Drawing.Size(117, 22);
            this.m_mnuMute.Text = "&Mute";
            this.m_mnuMute.Click += new System.EventHandler(this.m_mnuMute_Click);
            // 
            // m_imageListMute
            // 
            this.m_imageListMute.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_imageListMute.ImageStream")));
            this.m_imageListMute.TransparentColor = System.Drawing.Color.Transparent;
            this.m_imageListMute.Images.SetKeyName(0, "happy_32px.png");
            this.m_imageListMute.Images.SetKeyName(1, "hazardous_32px.png");
            // 
            // m_listDevices
            // 
            this.m_listDevices.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.m_listDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_listDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.m_listDevices.ContextMenuStrip = this.m_mnuDevices;
            this.m_listDevices.FullRowSelect = true;
            this.m_listDevices.GridLines = true;
            listViewGroup1.Header = "Connected";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "Unplugged";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "Disabled";
            listViewGroup3.Name = "listViewGroup3";
            listViewGroup4.Header = "Not Present";
            listViewGroup4.Name = "listViewGroup4";
            this.m_listDevices.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.m_listDevices.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.m_listDevices.HideSelection = false;
            this.m_listDevices.Location = new System.Drawing.Point(0, 0);
            this.m_listDevices.MultiSelect = false;
            this.m_listDevices.Name = "m_listDevices";
            this.m_listDevices.ShowItemToolTips = true;
            this.m_listDevices.Size = new System.Drawing.Size(576, 268);
            this.m_listDevices.TabIndex = 0;
            this.m_listDevices.UseCompatibleStateImageBehavior = false;
            this.m_listDevices.View = System.Windows.Forms.View.Details;
            this.m_listDevices.SelectedIndexChanged += new System.EventHandler(this.m_listDevices_SelectedIndexChanged);
            this.m_listDevices.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.m_listDevices_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Devices";
            this.columnHeader1.Width = 362;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Volume";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 73;
            // 
            // MediaDeviceListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_btnActivate);
            this.Controls.Add(this.m_listDevices);
            this.Controls.Add(this.m_btnRefresh);
            this.Name = "MediaDeviceListUserControl";
            this.Size = new System.Drawing.Size(576, 302);
            this.Load += new System.EventHandler(this.MediaDeviceListUserControl_Load);
            this.m_mnuDevices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_btnActivate;
        private ListViewExtensions.ListViewCollapsibleGroups m_listDevices;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button m_btnRefresh;
        private System.Windows.Forms.ContextMenuStrip m_mnuDevices;
        private System.Windows.Forms.ToolStripMenuItem m_mnuActivate;
        private System.Windows.Forms.ToolStripMenuItem m_mnuMute;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ImageList m_imageListMute;
    }
}
