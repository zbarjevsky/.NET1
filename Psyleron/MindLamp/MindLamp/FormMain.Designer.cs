﻿namespace MindLamp
{
	partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.m_trackBuffer = new System.Windows.Forms.TrackBar();
            this.m_trackFrequency = new System.Windows.Forms.TrackBar();
            this.m_pic = new System.Windows.Forms.PictureBox();
            this.m_lblBuffer = new System.Windows.Forms.Label();
            this.m_lblTFreq = new System.Windows.Forms.Label();
            this.m_cmbDevice = new System.Windows.Forms.ComboBox();
            this.m_btnStart = new System.Windows.Forms.Button();
            this.m_timer = new System.Windows.Forms.Timer(this.components);
            this.m_picCurrent = new System.Windows.Forms.PictureBox();
            this.m_trackRange = new System.Windows.Forms.TrackBar();
            this.m_statusStrip = new System.Windows.Forms.StatusStrip();
            this.m_lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_pnlTools = new System.Windows.Forms.Panel();
            this.m_tabMode = new System.Windows.Forms.TabControl();
            this.m_tabPage1 = new System.Windows.Forms.TabPage();
            this.m_picWhite2Color = new System.Windows.Forms.PictureBox();
            this.m_tabPage2 = new System.Windows.Forms.TabPage();
            this.m_picRainbow = new System.Windows.Forms.PictureBox();
            this.m_pnlStatus = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_trackBar = new System.Windows.Forms.TrackBar();
            this.m_lblCurrenColor = new System.Windows.Forms.Label();
            this.m_splitMain = new System.Windows.Forms.SplitContainer();
            this.m_spliView = new System.Windows.Forms.SplitContainer();
            this.m_pnlControl = new System.Windows.Forms.Panel();
            this.m_chartValues = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_picCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackRange)).BeginInit();
            this.m_statusStrip.SuspendLayout();
            this.m_pnlTools.SuspendLayout();
            this.m_tabMode.SuspendLayout();
            this.m_tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_picWhite2Color)).BeginInit();
            this.m_tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_picRainbow)).BeginInit();
            this.m_pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_splitMain)).BeginInit();
            this.m_splitMain.Panel1.SuspendLayout();
            this.m_splitMain.Panel2.SuspendLayout();
            this.m_splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_spliView)).BeginInit();
            this.m_spliView.Panel1.SuspendLayout();
            this.m_spliView.Panel2.SuspendLayout();
            this.m_spliView.SuspendLayout();
            this.m_pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_chartValues)).BeginInit();
            this.SuspendLayout();
            // 
            // m_trackBuffer
            // 
            this.m_trackBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_trackBuffer.Location = new System.Drawing.Point(129, 317);
            this.m_trackBuffer.Maximum = 1000;
            this.m_trackBuffer.Minimum = 10;
            this.m_trackBuffer.Name = "m_trackBuffer";
            this.m_trackBuffer.Size = new System.Drawing.Size(353, 45);
            this.m_trackBuffer.TabIndex = 3;
            this.m_trackBuffer.TickFrequency = 100;
            this.m_trackBuffer.Value = 300;
            this.m_trackBuffer.ValueChanged += new System.EventHandler(this.m_trackBuffer_ValueChanged);
            // 
            // m_trackFrequency
            // 
            this.m_trackFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_trackFrequency.Location = new System.Drawing.Point(129, 263);
            this.m_trackFrequency.Minimum = 1;
            this.m_trackFrequency.Name = "m_trackFrequency";
            this.m_trackFrequency.Size = new System.Drawing.Size(353, 45);
            this.m_trackFrequency.TabIndex = 5;
            this.m_trackFrequency.Value = 1;
            this.m_trackFrequency.ValueChanged += new System.EventHandler(this.m_trackFrequency_ValueChanged);
            // 
            // m_pic
            // 
            this.m_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_pic.BackColor = System.Drawing.SystemColors.Info;
            this.m_pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_pic.Location = new System.Drawing.Point(171, 4);
            this.m_pic.Name = "m_pic";
            this.m_pic.Size = new System.Drawing.Size(311, 215);
            this.m_pic.TabIndex = 2;
            this.m_pic.TabStop = false;
            // 
            // m_lblBuffer
            // 
            this.m_lblBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblBuffer.AutoSize = true;
            this.m_lblBuffer.Location = new System.Drawing.Point(12, 327);
            this.m_lblBuffer.Name = "m_lblBuffer";
            this.m_lblBuffer.Size = new System.Drawing.Size(38, 13);
            this.m_lblBuffer.TabIndex = 2;
            this.m_lblBuffer.Text = "Buffer:";
            // 
            // m_lblTFreq
            // 
            this.m_lblTFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblTFreq.AutoSize = true;
            this.m_lblTFreq.Location = new System.Drawing.Point(12, 282);
            this.m_lblTFreq.Name = "m_lblTFreq";
            this.m_lblTFreq.Size = new System.Drawing.Size(60, 13);
            this.m_lblTFreq.TabIndex = 4;
            this.m_lblTFreq.Text = "Frequency:";
            // 
            // m_cmbDevice
            // 
            this.m_cmbDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cmbDevice.FormattingEnabled = true;
            this.m_cmbDevice.Location = new System.Drawing.Point(15, 11);
            this.m_cmbDevice.Name = "m_cmbDevice";
            this.m_cmbDevice.Size = new System.Drawing.Size(662, 21);
            this.m_cmbDevice.TabIndex = 0;
            // 
            // m_btnStart
            // 
            this.m_btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnStart.Location = new System.Drawing.Point(739, 9);
            this.m_btnStart.Name = "m_btnStart";
            this.m_btnStart.Size = new System.Drawing.Size(75, 23);
            this.m_btnStart.TabIndex = 1;
            this.m_btnStart.Text = "Play >";
            this.m_btnStart.UseVisualStyleBackColor = true;
            this.m_btnStart.Click += new System.EventHandler(this.m_btnStart_Click);
            // 
            // m_timer
            // 
            this.m_timer.Tick += new System.EventHandler(this.m_timer_Tick);
            // 
            // m_picCurrent
            // 
            this.m_picCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_picCurrent.BackColor = System.Drawing.Color.White;
            this.m_picCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_picCurrent.Location = new System.Drawing.Point(3, 4);
            this.m_picCurrent.Name = "m_picCurrent";
            this.m_picCurrent.Size = new System.Drawing.Size(106, 215);
            this.m_picCurrent.TabIndex = 6;
            this.m_picCurrent.TabStop = false;
            // 
            // m_trackRange
            // 
            this.m_trackRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_trackRange.LargeChange = 50;
            this.m_trackRange.Location = new System.Drawing.Point(117, 4);
            this.m_trackRange.Maximum = 780;
            this.m_trackRange.Minimum = 380;
            this.m_trackRange.Name = "m_trackRange";
            this.m_trackRange.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.m_trackRange.Size = new System.Drawing.Size(45, 215);
            this.m_trackRange.TabIndex = 7;
            this.m_trackRange.TickFrequency = 40;
            this.m_trackRange.Value = 580;
            this.m_trackRange.ValueChanged += new System.EventHandler(this.m_trackRange_ValueChanged);
            // 
            // m_statusStrip
            // 
            this.m_statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_lblStatus});
            this.m_statusStrip.Location = new System.Drawing.Point(0, 557);
            this.m_statusStrip.Name = "m_statusStrip";
            this.m_statusStrip.Size = new System.Drawing.Size(825, 22);
            this.m_statusStrip.TabIndex = 8;
            this.m_statusStrip.Text = "statusStrip1";
            // 
            // m_lblStatus
            // 
            this.m_lblStatus.Name = "m_lblStatus";
            this.m_lblStatus.Size = new System.Drawing.Size(39, 17);
            this.m_lblStatus.Text = "Ready";
            // 
            // m_pnlTools
            // 
            this.m_pnlTools.Controls.Add(this.m_tabMode);
            this.m_pnlTools.Controls.Add(this.m_pnlStatus);
            this.m_pnlTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_pnlTools.Location = new System.Drawing.Point(0, 0);
            this.m_pnlTools.Name = "m_pnlTools";
            this.m_pnlTools.Size = new System.Drawing.Size(332, 349);
            this.m_pnlTools.TabIndex = 9;
            // 
            // m_tabMode
            // 
            this.m_tabMode.Controls.Add(this.m_tabPage1);
            this.m_tabMode.Controls.Add(this.m_tabPage2);
            this.m_tabMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_tabMode.Location = new System.Drawing.Point(0, 0);
            this.m_tabMode.Name = "m_tabMode";
            this.m_tabMode.SelectedIndex = 0;
            this.m_tabMode.Size = new System.Drawing.Size(332, 289);
            this.m_tabMode.TabIndex = 0;
            // 
            // m_tabPage1
            // 
            this.m_tabPage1.Controls.Add(this.m_picWhite2Color);
            this.m_tabPage1.Location = new System.Drawing.Point(4, 22);
            this.m_tabPage1.Name = "m_tabPage1";
            this.m_tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabPage1.Size = new System.Drawing.Size(324, 326);
            this.m_tabPage1.TabIndex = 0;
            this.m_tabPage1.Text = "White to Color";
            this.m_tabPage1.UseVisualStyleBackColor = true;
            // 
            // m_picWhite2Color
            // 
            this.m_picWhite2Color.BackColor = System.Drawing.Color.White;
            this.m_picWhite2Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.m_picWhite2Color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_picWhite2Color.Image = ((System.Drawing.Image)(resources.GetObject("m_picWhite2Color.Image")));
            this.m_picWhite2Color.Location = new System.Drawing.Point(3, 3);
            this.m_picWhite2Color.Name = "m_picWhite2Color";
            this.m_picWhite2Color.Size = new System.Drawing.Size(318, 320);
            this.m_picWhite2Color.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_picWhite2Color.TabIndex = 0;
            this.m_picWhite2Color.TabStop = false;
            // 
            // m_tabPage2
            // 
            this.m_tabPage2.Controls.Add(this.m_picRainbow);
            this.m_tabPage2.Location = new System.Drawing.Point(4, 22);
            this.m_tabPage2.Name = "m_tabPage2";
            this.m_tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabPage2.Size = new System.Drawing.Size(324, 263);
            this.m_tabPage2.TabIndex = 1;
            this.m_tabPage2.Text = "Rainbow";
            this.m_tabPage2.UseVisualStyleBackColor = true;
            // 
            // m_picRainbow
            // 
            this.m_picRainbow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_picRainbow.Image = ((System.Drawing.Image)(resources.GetObject("m_picRainbow.Image")));
            this.m_picRainbow.Location = new System.Drawing.Point(3, 3);
            this.m_picRainbow.Name = "m_picRainbow";
            this.m_picRainbow.Size = new System.Drawing.Size(318, 257);
            this.m_picRainbow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_picRainbow.TabIndex = 0;
            this.m_picRainbow.TabStop = false;
            // 
            // m_pnlStatus
            // 
            this.m_pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_pnlStatus.Controls.Add(this.label8);
            this.m_pnlStatus.Controls.Add(this.label7);
            this.m_pnlStatus.Controls.Add(this.label6);
            this.m_pnlStatus.Controls.Add(this.label5);
            this.m_pnlStatus.Controls.Add(this.label4);
            this.m_pnlStatus.Controls.Add(this.label3);
            this.m_pnlStatus.Controls.Add(this.label2);
            this.m_pnlStatus.Controls.Add(this.label1);
            this.m_pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnlStatus.Location = new System.Drawing.Point(0, 289);
            this.m_pnlStatus.Name = "m_pnlStatus";
            this.m_pnlStatus.Size = new System.Drawing.Size(332, 60);
            this.m_pnlStatus.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(177, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(116, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(59, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(4, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(177, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(116, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(59, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // m_trackBar
            // 
            this.m_trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_trackBar.LargeChange = 50;
            this.m_trackBar.Location = new System.Drawing.Point(3, 234);
            this.m_trackBar.Maximum = 239;
            this.m_trackBar.Name = "m_trackBar";
            this.m_trackBar.Size = new System.Drawing.Size(106, 45);
            this.m_trackBar.SmallChange = 10;
            this.m_trackBar.TabIndex = 10;
            this.m_trackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.m_trackBar.Value = 50;
            this.m_trackBar.ValueChanged += new System.EventHandler(this.m_trackBar_ValueChanged);
            // 
            // m_lblCurrenColor
            // 
            this.m_lblCurrenColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_lblCurrenColor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_lblCurrenColor.Location = new System.Drawing.Point(0, 349);
            this.m_lblCurrenColor.Name = "m_lblCurrenColor";
            this.m_lblCurrenColor.Size = new System.Drawing.Size(332, 31);
            this.m_lblCurrenColor.TabIndex = 11;
            this.m_lblCurrenColor.Text = "oooo";
            // 
            // m_splitMain
            // 
            this.m_splitMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_splitMain.Location = new System.Drawing.Point(0, 44);
            this.m_splitMain.Name = "m_splitMain";
            this.m_splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // m_splitMain.Panel1
            // 
            this.m_splitMain.Panel1.Controls.Add(this.m_spliView);
            // 
            // m_splitMain.Panel2
            // 
            this.m_splitMain.Panel2.Controls.Add(this.m_chartValues);
            this.m_splitMain.Size = new System.Drawing.Size(825, 513);
            this.m_splitMain.SplitterDistance = 384;
            this.m_splitMain.TabIndex = 12;
            // 
            // m_spliView
            // 
            this.m_spliView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_spliView.Location = new System.Drawing.Point(0, 0);
            this.m_spliView.Name = "m_spliView";
            // 
            // m_spliView.Panel1
            // 
            this.m_spliView.Panel1.Controls.Add(this.m_trackBar);
            this.m_spliView.Panel1.Controls.Add(this.m_trackBuffer);
            this.m_spliView.Panel1.Controls.Add(this.m_pic);
            this.m_spliView.Panel1.Controls.Add(this.m_lblBuffer);
            this.m_spliView.Panel1.Controls.Add(this.m_trackFrequency);
            this.m_spliView.Panel1.Controls.Add(this.m_lblTFreq);
            this.m_spliView.Panel1.Controls.Add(this.m_picCurrent);
            this.m_spliView.Panel1.Controls.Add(this.m_trackRange);
            // 
            // m_spliView.Panel2
            // 
            this.m_spliView.Panel2.Controls.Add(this.m_pnlTools);
            this.m_spliView.Panel2.Controls.Add(this.m_lblCurrenColor);
            this.m_spliView.Size = new System.Drawing.Size(821, 380);
            this.m_spliView.SplitterDistance = 485;
            this.m_spliView.TabIndex = 12;
            // 
            // m_pnlControl
            // 
            this.m_pnlControl.Controls.Add(this.m_cmbDevice);
            this.m_pnlControl.Controls.Add(this.m_btnStart);
            this.m_pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnlControl.Location = new System.Drawing.Point(0, 0);
            this.m_pnlControl.Name = "m_pnlControl";
            this.m_pnlControl.Size = new System.Drawing.Size(825, 44);
            this.m_pnlControl.TabIndex = 13;
            // 
            // m_chartValues
            // 
            this.m_chartValues.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Blue;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            chartArea1.AxisY.LineWidth = 3;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Magenta;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "ChartArea1";
            this.m_chartValues.ChartAreas.Add(chartArea1);
            this.m_chartValues.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.m_chartValues.Legends.Add(legend1);
            this.m_chartValues.Location = new System.Drawing.Point(0, 0);
            this.m_chartValues.Name = "m_chartValues";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Lime;
            series1.LabelForeColor = System.Drawing.Color.Empty;
            series1.Legend = "Legend1";
            series1.Name = "Current";
            this.m_chartValues.Series.Add(series1);
            this.m_chartValues.Size = new System.Drawing.Size(821, 121);
            this.m_chartValues.TabIndex = 0;
            this.m_chartValues.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 579);
            this.Controls.Add(this.m_splitMain);
            this.Controls.Add(this.m_pnlControl);
            this.Controls.Add(this.m_statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMain";
            this.Text = "Lamp !!!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_picCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackRange)).EndInit();
            this.m_statusStrip.ResumeLayout(false);
            this.m_statusStrip.PerformLayout();
            this.m_pnlTools.ResumeLayout(false);
            this.m_tabMode.ResumeLayout(false);
            this.m_tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_picWhite2Color)).EndInit();
            this.m_tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_picRainbow)).EndInit();
            this.m_pnlStatus.ResumeLayout(false);
            this.m_pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBar)).EndInit();
            this.m_splitMain.Panel1.ResumeLayout(false);
            this.m_splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_splitMain)).EndInit();
            this.m_splitMain.ResumeLayout(false);
            this.m_spliView.Panel1.ResumeLayout(false);
            this.m_spliView.Panel1.PerformLayout();
            this.m_spliView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_spliView)).EndInit();
            this.m_spliView.ResumeLayout(false);
            this.m_pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_chartValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TrackBar m_trackBuffer;
		private System.Windows.Forms.TrackBar m_trackFrequency;
		private System.Windows.Forms.PictureBox m_pic;
		private System.Windows.Forms.Label m_lblBuffer;
		private System.Windows.Forms.Label m_lblTFreq;
		private System.Windows.Forms.ComboBox m_cmbDevice;
		private System.Windows.Forms.Button m_btnStart;
		private System.Windows.Forms.Timer m_timer;
		private System.Windows.Forms.PictureBox m_picCurrent;
		private System.Windows.Forms.TrackBar m_trackRange;
		private System.Windows.Forms.StatusStrip m_statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel m_lblStatus;
		private System.Windows.Forms.Panel m_pnlTools;
		private System.Windows.Forms.TabControl m_tabMode;
		private System.Windows.Forms.TabPage m_tabPage1;
		private System.Windows.Forms.TabPage m_tabPage2;
		private System.Windows.Forms.PictureBox m_picWhite2Color;
		private System.Windows.Forms.PictureBox m_picRainbow;
		private System.Windows.Forms.Panel m_pnlStatus;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar m_trackBar;
		private System.Windows.Forms.Label m_lblCurrenColor;
        private System.Windows.Forms.SplitContainer m_splitMain;
        private System.Windows.Forms.SplitContainer m_spliView;
        private System.Windows.Forms.DataVisualization.Charting.Chart m_chartValues;
        private System.Windows.Forms.Panel m_pnlControl;
    }
}

