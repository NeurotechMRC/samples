﻿using Indices.Spectrum;

namespace Indices
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Alpha",
            "awd",
            "ww",
            "www"}, -1);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._startSignalButton = new System.Windows.Forms.ToolStripButton();
            this._stopButton = new System.Windows.Forms.ToolStripButton();
            this._channelsListBox = new System.Windows.Forms.CheckedListBox();
            this._createIndexButton = new System.Windows.Forms.Button();
            this._startFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._stopFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._customIndexRadio = new System.Windows.Forms.RadioButton();
            this._thetaRadio = new System.Windows.Forms.RadioButton();
            this._deltaRadio = new System.Windows.Forms.RadioButton();
            this._betaRadio = new System.Windows.Forms.RadioButton();
            this._alphaRadio = new System.Windows.Forms.RadioButton();
            this._indicesListView = new System.Windows.Forms.ListView();
            this.IndexColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChannelsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FrequencyColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WindowColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._removeIndexButton = new System.Windows.Forms.Button();
            this._indexNameTextBox = new System.Windows.Forms.TextBox();
            this._indexWindowTextBox = new System.Windows.Forms.TextBox();
            this._indexWindowOverlapTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._scaleTrackBar = new System.Windows.Forms.TrackBar();
            this._timeTrackBar = new System.Windows.Forms.TrackBar();
            this._durationLabek = new System.Windows.Forms.Label();
            this._addEmulationChannelButton = new System.Windows.Forms.Button();
            this._spectrumAmplitudeLabel = new System.Windows.Forms.Label();
            this._spectrumTimeLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this._emulationParamsBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._deviceListBox = new System.Windows.Forms.ListBox();
            this._addDeviceButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._filtersListBox = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._wattLabel = new System.Windows.Forms.Label();
            this._lowFreqTrackBar = new System.Windows.Forms.TrackBar();
            this._highFreqTrackBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._lowFreqLabel = new System.Windows.Forms.Label();
            this._highFreqLabel = new System.Windows.Forms.Label();
            this._spectrumChart = new Indices.Spectrum.SpectrumChart();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this._blackmanWindowRadio = new System.Windows.Forms.RadioButton();
            this._hammingWindowRadio = new System.Windows.Forms.RadioButton();
            this._sineWindowRadio = new System.Windows.Forms.RadioButton();
            this._rectangularWindowRadio = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._scaleTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._timeTrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lowFreqTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._highFreqTrackBar)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._startSignalButton,
            this._stopButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1711, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _startSignalButton
            // 
            this._startSignalButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._startSignalButton.Image = ((System.Drawing.Image)(resources.GetObject("_startSignalButton.Image")));
            this._startSignalButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._startSignalButton.Name = "_startSignalButton";
            this._startSignalButton.Size = new System.Drawing.Size(35, 22);
            this._startSignalButton.Text = "Start";
            this._startSignalButton.Click += new System.EventHandler(this._startSignalButton_Click);
            // 
            // _stopButton
            // 
            this._stopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._stopButton.Image = ((System.Drawing.Image)(resources.GetObject("_stopButton.Image")));
            this._stopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._stopButton.Name = "_stopButton";
            this._stopButton.Size = new System.Drawing.Size(35, 22);
            this._stopButton.Text = "Stop";
            this._stopButton.Click += new System.EventHandler(this._stopButton_Click);
            // 
            // _channelsListBox
            // 
            this._channelsListBox.FormattingEnabled = true;
            this._channelsListBox.Location = new System.Drawing.Point(6, 16);
            this._channelsListBox.Name = "_channelsListBox";
            this._channelsListBox.Size = new System.Drawing.Size(292, 379);
            this._channelsListBox.TabIndex = 1;
            this._channelsListBox.SelectedIndexChanged += new System.EventHandler(this._channelsListBox_SelectedIndexChanged);
            // 
            // _createIndexButton
            // 
            this._createIndexButton.Location = new System.Drawing.Point(1108, 380);
            this._createIndexButton.Name = "_createIndexButton";
            this._createIndexButton.Size = new System.Drawing.Size(79, 23);
            this._createIndexButton.TabIndex = 2;
            this._createIndexButton.Text = "Create index";
            this._createIndexButton.UseVisualStyleBackColor = true;
            this._createIndexButton.Click += new System.EventHandler(this._createIndexButton_Click);
            // 
            // _startFrequencyTextBox
            // 
            this._startFrequencyTextBox.Location = new System.Drawing.Point(1108, 186);
            this._startFrequencyTextBox.Name = "_startFrequencyTextBox";
            this._startFrequencyTextBox.Size = new System.Drawing.Size(78, 20);
            this._startFrequencyTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1105, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start frequency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1105, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stop frequency";
            // 
            // _stopFrequencyTextBox
            // 
            this._stopFrequencyTextBox.Location = new System.Drawing.Point(1108, 229);
            this._stopFrequencyTextBox.Name = "_stopFrequencyTextBox";
            this._stopFrequencyTextBox.Size = new System.Drawing.Size(79, 20);
            this._stopFrequencyTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._customIndexRadio);
            this.groupBox1.Controls.Add(this._thetaRadio);
            this.groupBox1.Controls.Add(this._deltaRadio);
            this.groupBox1.Controls.Add(this._betaRadio);
            this.groupBox1.Controls.Add(this._alphaRadio);
            this.groupBox1.Location = new System.Drawing.Point(1111, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 137);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Index type";
            // 
            // _customIndexRadio
            // 
            this._customIndexRadio.AutoSize = true;
            this._customIndexRadio.Location = new System.Drawing.Point(7, 114);
            this._customIndexRadio.Name = "_customIndexRadio";
            this._customIndexRadio.Size = new System.Drawing.Size(60, 17);
            this._customIndexRadio.TabIndex = 4;
            this._customIndexRadio.Text = "Custom";
            this._customIndexRadio.UseVisualStyleBackColor = true;
            this._customIndexRadio.CheckedChanged += new System.EventHandler(this._customIndexRadio_CheckedChanged);
            // 
            // _thetaRadio
            // 
            this._thetaRadio.AutoSize = true;
            this._thetaRadio.Location = new System.Drawing.Point(6, 91);
            this._thetaRadio.Name = "_thetaRadio";
            this._thetaRadio.Size = new System.Drawing.Size(53, 17);
            this._thetaRadio.TabIndex = 3;
            this._thetaRadio.Text = "Theta";
            this._thetaRadio.UseVisualStyleBackColor = true;
            this._thetaRadio.CheckedChanged += new System.EventHandler(this._thetaRadio_CheckedChanged);
            // 
            // _deltaRadio
            // 
            this._deltaRadio.AutoSize = true;
            this._deltaRadio.Location = new System.Drawing.Point(7, 68);
            this._deltaRadio.Name = "_deltaRadio";
            this._deltaRadio.Size = new System.Drawing.Size(50, 17);
            this._deltaRadio.TabIndex = 2;
            this._deltaRadio.Text = "Delta";
            this._deltaRadio.UseVisualStyleBackColor = true;
            this._deltaRadio.CheckedChanged += new System.EventHandler(this._deltaRadio_CheckedChanged);
            // 
            // _betaRadio
            // 
            this._betaRadio.AutoSize = true;
            this._betaRadio.Location = new System.Drawing.Point(7, 44);
            this._betaRadio.Name = "_betaRadio";
            this._betaRadio.Size = new System.Drawing.Size(47, 17);
            this._betaRadio.TabIndex = 1;
            this._betaRadio.Text = "Beta";
            this._betaRadio.UseVisualStyleBackColor = true;
            this._betaRadio.CheckedChanged += new System.EventHandler(this._betaRadio_CheckedChanged);
            // 
            // _alphaRadio
            // 
            this._alphaRadio.AutoSize = true;
            this._alphaRadio.Checked = true;
            this._alphaRadio.Location = new System.Drawing.Point(7, 20);
            this._alphaRadio.Name = "_alphaRadio";
            this._alphaRadio.Size = new System.Drawing.Size(52, 17);
            this._alphaRadio.TabIndex = 0;
            this._alphaRadio.TabStop = true;
            this._alphaRadio.Text = "Alpha";
            this._alphaRadio.UseVisualStyleBackColor = true;
            this._alphaRadio.CheckedChanged += new System.EventHandler(this._alphaRadio_CheckedChanged);
            // 
            // _indicesListView
            // 
            this._indicesListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._indicesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IndexColumn,
            this.ChannelsColumn,
            this.FrequencyColumn,
            this.WindowColumn,
            this.ValueColumn});
            this._indicesListView.HideSelection = false;
            this._indicesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this._indicesListView.Location = new System.Drawing.Point(1192, 35);
            this._indicesListView.Name = "_indicesListView";
            this._indicesListView.Size = new System.Drawing.Size(497, 396);
            this._indicesListView.TabIndex = 8;
            this._indicesListView.UseCompatibleStateImageBehavior = false;
            this._indicesListView.View = System.Windows.Forms.View.Details;
            // 
            // IndexColumn
            // 
            this.IndexColumn.Text = "Index";
            // 
            // ChannelsColumn
            // 
            this.ChannelsColumn.Text = "Channels";
            this.ChannelsColumn.Width = 187;
            // 
            // FrequencyColumn
            // 
            this.FrequencyColumn.Text = "Frequency";
            this.FrequencyColumn.Width = 80;
            // 
            // WindowColumn
            // 
            this.WindowColumn.Text = "Window/Overlap";
            this.WindowColumn.Width = 100;
            // 
            // ValueColumn
            // 
            this.ValueColumn.Text = "Value";
            this.ValueColumn.Width = 80;
            // 
            // _removeIndexButton
            // 
            this._removeIndexButton.Location = new System.Drawing.Point(1108, 408);
            this._removeIndexButton.Name = "_removeIndexButton";
            this._removeIndexButton.Size = new System.Drawing.Size(79, 23);
            this._removeIndexButton.TabIndex = 9;
            this._removeIndexButton.Text = "Remove index";
            this._removeIndexButton.UseVisualStyleBackColor = true;
            this._removeIndexButton.Click += new System.EventHandler(this._removeIndexButton_Click);
            // 
            // _indexNameTextBox
            // 
            this._indexNameTextBox.Location = new System.Drawing.Point(1108, 274);
            this._indexNameTextBox.Name = "_indexNameTextBox";
            this._indexNameTextBox.Size = new System.Drawing.Size(79, 20);
            this._indexNameTextBox.TabIndex = 10;
            // 
            // _indexWindowTextBox
            // 
            this._indexWindowTextBox.Location = new System.Drawing.Point(1108, 315);
            this._indexWindowTextBox.Name = "_indexWindowTextBox";
            this._indexWindowTextBox.Size = new System.Drawing.Size(79, 20);
            this._indexWindowTextBox.TabIndex = 10;
            this._indexWindowTextBox.Text = "8";
            // 
            // _indexWindowOverlapTextBox
            // 
            this._indexWindowOverlapTextBox.Location = new System.Drawing.Point(1108, 355);
            this._indexWindowOverlapTextBox.Name = "_indexWindowOverlapTextBox";
            this._indexWindowOverlapTextBox.Size = new System.Drawing.Size(79, 20);
            this._indexWindowOverlapTextBox.TabIndex = 10;
            this._indexWindowOverlapTextBox.Text = "0.9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1105, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1105, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Window";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1105, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Overlap coeff";
            // 
            // _scaleTrackBar
            // 
            this._scaleTrackBar.LargeChange = 10;
            this._scaleTrackBar.Location = new System.Drawing.Point(57, 25);
            this._scaleTrackBar.Maximum = 100;
            this._scaleTrackBar.Minimum = 1;
            this._scaleTrackBar.Name = "_scaleTrackBar";
            this._scaleTrackBar.Size = new System.Drawing.Size(527, 45);
            this._scaleTrackBar.TabIndex = 12;
            this._scaleTrackBar.Value = 10;
            // 
            // _timeTrackBar
            // 
            this._timeTrackBar.LargeChange = 2;
            this._timeTrackBar.Location = new System.Drawing.Point(57, 70);
            this._timeTrackBar.Maximum = 16;
            this._timeTrackBar.Minimum = 1;
            this._timeTrackBar.Name = "_timeTrackBar";
            this._timeTrackBar.Size = new System.Drawing.Size(527, 45);
            this._timeTrackBar.TabIndex = 12;
            this._timeTrackBar.Value = 8;
            // 
            // _durationLabek
            // 
            this._durationLabek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._durationLabek.AutoSize = true;
            this._durationLabek.Location = new System.Drawing.Point(991, 872);
            this._durationLabek.Name = "_durationLabek";
            this._durationLabek.Size = new System.Drawing.Size(13, 13);
            this._durationLabek.TabIndex = 14;
            this._durationLabek.Text = "0";
            // 
            // _addEmulationChannelButton
            // 
            this._addEmulationChannelButton.Location = new System.Drawing.Point(51, 105);
            this._addEmulationChannelButton.Name = "_addEmulationChannelButton";
            this._addEmulationChannelButton.Size = new System.Drawing.Size(96, 23);
            this._addEmulationChannelButton.TabIndex = 15;
            this._addEmulationChannelButton.Text = "Add";
            this._addEmulationChannelButton.UseVisualStyleBackColor = true;
            this._addEmulationChannelButton.Click += new System.EventHandler(this._addEmulatorButton_Click);
            // 
            // _spectrumAmplitudeLabel
            // 
            this._spectrumAmplitudeLabel.AutoSize = true;
            this._spectrumAmplitudeLabel.Location = new System.Drawing.Point(12, 30);
            this._spectrumAmplitudeLabel.Name = "_spectrumAmplitudeLabel";
            this._spectrumAmplitudeLabel.Size = new System.Drawing.Size(41, 13);
            this._spectrumAmplitudeLabel.TabIndex = 16;
            this._spectrumAmplitudeLabel.Text = "100 uV";
            // 
            // _spectrumTimeLabel
            // 
            this._spectrumTimeLabel.AutoSize = true;
            this._spectrumTimeLabel.Location = new System.Drawing.Point(12, 73);
            this._spectrumTimeLabel.Name = "_spectrumTimeLabel";
            this._spectrumTimeLabel.Size = new System.Drawing.Size(21, 13);
            this._spectrumTimeLabel.TabIndex = 17;
            this._spectrumTimeLabel.Text = "8 s";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this._emulationParamsBox);
            this.groupBox2.Controls.Add(this._addEmulationChannelButton);
            this.groupBox2.Location = new System.Drawing.Point(590, 459);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 134);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emulation channel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "uV/Hz;uV/Hz;...";
            // 
            // _emulationParamsBox
            // 
            this._emulationParamsBox.Location = new System.Drawing.Point(7, 40);
            this._emulationParamsBox.Multiline = true;
            this._emulationParamsBox.Name = "_emulationParamsBox";
            this._emulationParamsBox.Size = new System.Drawing.Size(192, 62);
            this._emulationParamsBox.TabIndex = 16;
            this._emulationParamsBox.Text = "50/5;100/8;25/16;30/50";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._deviceListBox);
            this.groupBox3.Controls.Add(this._addDeviceButton);
            this.groupBox3.Location = new System.Drawing.Point(590, 599);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 134);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Devices";
            // 
            // _deviceListBox
            // 
            this._deviceListBox.FormattingEnabled = true;
            this._deviceListBox.Location = new System.Drawing.Point(5, 19);
            this._deviceListBox.Name = "_deviceListBox";
            this._deviceListBox.Size = new System.Drawing.Size(194, 82);
            this._deviceListBox.TabIndex = 1;
            // 
            // _addDeviceButton
            // 
            this._addDeviceButton.Location = new System.Drawing.Point(52, 107);
            this._addDeviceButton.Name = "_addDeviceButton";
            this._addDeviceButton.Size = new System.Drawing.Size(95, 23);
            this._addDeviceButton.TabIndex = 0;
            this._addDeviceButton.Text = "Select";
            this._addDeviceButton.UseVisualStyleBackColor = true;
            this._addDeviceButton.Click += new System.EventHandler(this._addDeviceButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._channelsListBox);
            this.groupBox4.Location = new System.Drawing.Point(801, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 401);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Channels";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this._filtersListBox);
            this.groupBox5.Location = new System.Drawing.Point(590, 30);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 430);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filters";
            // 
            // _filtersListBox
            // 
            this._filtersListBox.FormattingEnabled = true;
            this._filtersListBox.Location = new System.Drawing.Point(5, 16);
            this._filtersListBox.Name = "_filtersListBox";
            this._filtersListBox.Size = new System.Drawing.Size(194, 409);
            this._filtersListBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 839);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // _wattLabel
            // 
            this._wattLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._wattLabel.AutoSize = true;
            this._wattLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._wattLabel.Location = new System.Drawing.Point(154, 857);
            this._wattLabel.Name = "_wattLabel";
            this._wattLabel.Size = new System.Drawing.Size(70, 24);
            this._wattLabel.TabIndex = 23;
            this._wattLabel.Text = "= 0 uW";
            // 
            // _lowFreqTrackBar
            // 
            this._lowFreqTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lowFreqTrackBar.LargeChange = 10;
            this._lowFreqTrackBar.Location = new System.Drawing.Point(15, 739);
            this._lowFreqTrackBar.Maximum = 160;
            this._lowFreqTrackBar.Name = "_lowFreqTrackBar";
            this._lowFreqTrackBar.Size = new System.Drawing.Size(582, 45);
            this._lowFreqTrackBar.TabIndex = 24;
            this._lowFreqTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this._lowFreqTrackBar.Value = 16;
            // 
            // _highFreqTrackBar
            // 
            this._highFreqTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._highFreqTrackBar.LargeChange = 10;
            this._highFreqTrackBar.Location = new System.Drawing.Point(15, 771);
            this._highFreqTrackBar.Maximum = 160;
            this._highFreqTrackBar.Name = "_highFreqTrackBar";
            this._highFreqTrackBar.Size = new System.Drawing.Size(582, 45);
            this._highFreqTrackBar.TabIndex = 25;
            this._highFreqTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this._highFreqTrackBar.Value = 28;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 810);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "F    = ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 821);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "low";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 821);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "high";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(139, 810);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "F    = ";
            // 
            // _lowFreqLabel
            // 
            this._lowFreqLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lowFreqLabel.AutoSize = true;
            this._lowFreqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lowFreqLabel.Location = new System.Drawing.Point(70, 810);
            this._lowFreqLabel.Name = "_lowFreqLabel";
            this._lowFreqLabel.Size = new System.Drawing.Size(39, 18);
            this._lowFreqLabel.TabIndex = 30;
            this._lowFreqLabel.Text = "8 Hz";
            // 
            // _highFreqLabel
            // 
            this._highFreqLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._highFreqLabel.AutoSize = true;
            this._highFreqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._highFreqLabel.Location = new System.Drawing.Point(181, 810);
            this._highFreqLabel.Name = "_highFreqLabel";
            this._highFreqLabel.Size = new System.Drawing.Size(47, 18);
            this._highFreqLabel.TabIndex = 31;
            this._highFreqLabel.Text = "14 Hz";
            // 
            // _spectrumChart
            // 
            this._spectrumChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._spectrumChart.FrequencyStep = 0D;
            this._spectrumChart.Location = new System.Drawing.Point(5, 160);
            this._spectrumChart.Name = "_spectrumChart";
            this._spectrumChart.SigScale = 100;
            this._spectrumChart.Size = new System.Drawing.Size(579, 573);
            this._spectrumChart.TabIndex = 12;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this._blackmanWindowRadio);
            this.groupBox6.Controls.Add(this._hammingWindowRadio);
            this.groupBox6.Controls.Add(this._sineWindowRadio);
            this.groupBox6.Controls.Add(this._rectangularWindowRadio);
            this.groupBox6.Location = new System.Drawing.Point(5, 106);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(579, 49);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Window type";
            // 
            // _blackmanWindowRadio
            // 
            this._blackmanWindowRadio.AutoSize = true;
            this._blackmanWindowRadio.Location = new System.Drawing.Point(226, 20);
            this._blackmanWindowRadio.Name = "_blackmanWindowRadio";
            this._blackmanWindowRadio.Size = new System.Drawing.Size(72, 17);
            this._blackmanWindowRadio.TabIndex = 3;
            this._blackmanWindowRadio.Text = "Blackman";
            this._blackmanWindowRadio.UseVisualStyleBackColor = true;
            // 
            // _hammingWindowRadio
            // 
            this._hammingWindowRadio.AutoSize = true;
            this._hammingWindowRadio.Location = new System.Drawing.Point(150, 20);
            this._hammingWindowRadio.Name = "_hammingWindowRadio";
            this._hammingWindowRadio.Size = new System.Drawing.Size(69, 17);
            this._hammingWindowRadio.TabIndex = 2;
            this._hammingWindowRadio.Text = "Hamming";
            this._hammingWindowRadio.UseVisualStyleBackColor = true;
            // 
            // _sineWindowRadio
            // 
            this._sineWindowRadio.AutoSize = true;
            this._sineWindowRadio.Location = new System.Drawing.Point(97, 20);
            this._sineWindowRadio.Name = "_sineWindowRadio";
            this._sineWindowRadio.Size = new System.Drawing.Size(46, 17);
            this._sineWindowRadio.TabIndex = 1;
            this._sineWindowRadio.Text = "Sine";
            this._sineWindowRadio.UseVisualStyleBackColor = true;
            // 
            // _rectangularWindowRadio
            // 
            this._rectangularWindowRadio.AutoSize = true;
            this._rectangularWindowRadio.Checked = true;
            this._rectangularWindowRadio.Location = new System.Drawing.Point(7, 20);
            this._rectangularWindowRadio.Name = "_rectangularWindowRadio";
            this._rectangularWindowRadio.Size = new System.Drawing.Size(83, 17);
            this._rectangularWindowRadio.TabIndex = 0;
            this._rectangularWindowRadio.TabStop = true;
            this._rectangularWindowRadio.Text = "Rectangular";
            this._rectangularWindowRadio.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 912);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this._highFreqLabel);
            this.Controls.Add(this._lowFreqLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._highFreqTrackBar);
            this.Controls.Add(this._lowFreqTrackBar);
            this.Controls.Add(this._wattLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this._spectrumTimeLabel);
            this.Controls.Add(this._spectrumAmplitudeLabel);
            this.Controls.Add(this._durationLabek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._indexWindowTextBox);
            this.Controls.Add(this._indexWindowOverlapTextBox);
            this.Controls.Add(this._timeTrackBar);
            this.Controls.Add(this._scaleTrackBar);
            this.Controls.Add(this._spectrumChart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._indexNameTextBox);
            this.Controls.Add(this._removeIndexButton);
            this.Controls.Add(this._indicesListView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._stopFrequencyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._startFrequencyTextBox);
            this.Controls.Add(this._createIndexButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox4);
            this.MinimumSize = new System.Drawing.Size(650, 320);
            this.Name = "MainForm";
            this.Text = "Signal indices";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._scaleTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._timeTrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lowFreqTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._highFreqTrackBar)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _startSignalButton;
        private System.Windows.Forms.ToolStripButton _stopButton;
        private System.Windows.Forms.CheckedListBox _channelsListBox;
        private System.Windows.Forms.Button _createIndexButton;
        private System.Windows.Forms.TextBox _startFrequencyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _stopFrequencyTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton _customIndexRadio;
        private System.Windows.Forms.RadioButton _thetaRadio;
        private System.Windows.Forms.RadioButton _deltaRadio;
        private System.Windows.Forms.RadioButton _betaRadio;
        private System.Windows.Forms.RadioButton _alphaRadio;
        private System.Windows.Forms.ListView _indicesListView;
        private System.Windows.Forms.ColumnHeader IndexColumn;
        private System.Windows.Forms.ColumnHeader ValueColumn;
        private System.Windows.Forms.ColumnHeader WindowColumn;
        private System.Windows.Forms.Button _removeIndexButton;
        private System.Windows.Forms.ColumnHeader FrequencyColumn;
        private System.Windows.Forms.TextBox _indexNameTextBox;
        private System.Windows.Forms.TextBox _indexWindowTextBox;
        private System.Windows.Forms.TextBox _indexWindowOverlapTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader ChannelsColumn;
        private Spectrum.SpectrumChart _spectrumChart;
        private System.Windows.Forms.TrackBar _scaleTrackBar;
        private System.Windows.Forms.TrackBar _timeTrackBar;
        private System.Windows.Forms.Label _durationLabek;
        private System.Windows.Forms.Button _addEmulationChannelButton;
        private System.Windows.Forms.Label _spectrumAmplitudeLabel;
        private System.Windows.Forms.Label _spectrumTimeLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _emulationParamsBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox _deviceListBox;
        private System.Windows.Forms.Button _addDeviceButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox _filtersListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label _wattLabel;
        private System.Windows.Forms.TrackBar _lowFreqTrackBar;
        private System.Windows.Forms.TrackBar _highFreqTrackBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label _lowFreqLabel;
        private System.Windows.Forms.Label _highFreqLabel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton _blackmanWindowRadio;
        private System.Windows.Forms.RadioButton _hammingWindowRadio;
        private System.Windows.Forms.RadioButton _sineWindowRadio;
        private System.Windows.Forms.RadioButton _rectangularWindowRadio;
    }
}

