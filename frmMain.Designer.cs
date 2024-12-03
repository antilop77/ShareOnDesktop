﻿namespace ShareOnDeskTop
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblShare = new System.Windows.Forms.Label();
            this.cbxSymbol = new System.Windows.Forms.ComboBox();
            this.lblPeriodDown = new System.Windows.Forms.Label();
            this.dgvPeriodDown = new System.Windows.Forms.DataGridView();
            this.lblPeriodUp = new System.Windows.Forms.Label();
            this.lblPeriodx = new System.Windows.Forms.Label();
            this.dgvPeriodUp = new System.Windows.Forms.DataGridView();
            this.lblDown = new System.Windows.Forms.Label();
            this.dgvDailyDown = new System.Windows.Forms.DataGridView();
            this.lblUp = new System.Windows.Forms.Label();
            this.lblDaily = new System.Windows.Forms.Label();
            this.dgvDailyUp = new System.Windows.Forms.DataGridView();
            this.dgv100_2 = new System.Windows.Forms.DataGridView();
            this.lblBist100 = new System.Windows.Forms.Label();
            this.dgv100_1 = new System.Windows.Forms.DataGridView();
            this.lblBist50 = new System.Windows.Forms.Label();
            this.dgv50 = new System.Windows.Forms.DataGridView();
            this.lblBist30 = new System.Windows.Forms.Label();
            this.dgv30 = new System.Windows.Forms.DataGridView();
            this.nudLastProcessCount = new System.Windows.Forms.NumericUpDown();
            this.lblLastProcessCount = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.dgvShare = new System.Windows.Forms.DataGridView();
            this.cbxPeriod = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv100_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv100_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastProcessCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShare)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1899, 1181);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblShare);
            this.tabPage1.Controls.Add(this.cbxSymbol);
            this.tabPage1.Controls.Add(this.lblPeriodDown);
            this.tabPage1.Controls.Add(this.dgvPeriodDown);
            this.tabPage1.Controls.Add(this.lblPeriodUp);
            this.tabPage1.Controls.Add(this.lblPeriodx);
            this.tabPage1.Controls.Add(this.dgvPeriodUp);
            this.tabPage1.Controls.Add(this.lblDown);
            this.tabPage1.Controls.Add(this.dgvDailyDown);
            this.tabPage1.Controls.Add(this.lblUp);
            this.tabPage1.Controls.Add(this.lblDaily);
            this.tabPage1.Controls.Add(this.dgvDailyUp);
            this.tabPage1.Controls.Add(this.dgv100_2);
            this.tabPage1.Controls.Add(this.lblBist100);
            this.tabPage1.Controls.Add(this.dgv100_1);
            this.tabPage1.Controls.Add(this.lblBist50);
            this.tabPage1.Controls.Add(this.dgv50);
            this.tabPage1.Controls.Add(this.lblBist30);
            this.tabPage1.Controls.Add(this.dgv30);
            this.tabPage1.Controls.Add(this.nudLastProcessCount);
            this.tabPage1.Controls.Add(this.lblLastProcessCount);
            this.tabPage1.Controls.Add(this.lblPeriod);
            this.tabPage1.Controls.Add(this.dgvShare);
            this.tabPage1.Controls.Add(this.cbxPeriod);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1891, 1155);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BIST";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblShare
            // 
            this.lblShare.AutoSize = true;
            this.lblShare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShare.ForeColor = System.Drawing.Color.Navy;
            this.lblShare.Location = new System.Drawing.Point(5, 651);
            this.lblShare.Name = "lblShare";
            this.lblShare.Size = new System.Drawing.Size(70, 24);
            this.lblShare.TabIndex = 47;
            this.lblShare.Text = "HİSSE";
            // 
            // cbxSymbol
            // 
            this.cbxSymbol.FormattingEnabled = true;
            this.cbxSymbol.Location = new System.Drawing.Point(80, 654);
            this.cbxSymbol.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSymbol.Name = "cbxSymbol";
            this.cbxSymbol.Size = new System.Drawing.Size(99, 21);
            this.cbxSymbol.TabIndex = 46;
            this.cbxSymbol.SelectedIndexChanged += new System.EventHandler(this.cbxSymbol_SelectedIndexChanged);
            // 
            // lblPeriodDown
            // 
            this.lblPeriodDown.AutoSize = true;
            this.lblPeriodDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPeriodDown.Location = new System.Drawing.Point(1684, 905);
            this.lblPeriodDown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeriodDown.Name = "lblPeriodDown";
            this.lblPeriodDown.Size = new System.Drawing.Size(94, 24);
            this.lblPeriodDown.TabIndex = 45;
            this.lblPeriodDown.Text = "Düşenler";
            // 
            // dgvPeriodDown
            // 
            this.dgvPeriodDown.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPeriodDown.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvPeriodDown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodDown.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvPeriodDown.Location = new System.Drawing.Point(1583, 934);
            this.dgvPeriodDown.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPeriodDown.Name = "dgvPeriodDown";
            this.dgvPeriodDown.RowHeadersWidth = 62;
            this.dgvPeriodDown.RowTemplate.Height = 28;
            this.dgvPeriodDown.Size = new System.Drawing.Size(300, 200);
            this.dgvPeriodDown.TabIndex = 44;
            // 
            // lblPeriodUp
            // 
            this.lblPeriodUp.AutoSize = true;
            this.lblPeriodUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodUp.ForeColor = System.Drawing.Color.Green;
            this.lblPeriodUp.Location = new System.Drawing.Point(1374, 905);
            this.lblPeriodUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeriodUp.Name = "lblPeriodUp";
            this.lblPeriodUp.Size = new System.Drawing.Size(120, 24);
            this.lblPeriodUp.TabIndex = 43;
            this.lblPeriodUp.Text = "Yükselenler";
            // 
            // lblPeriodx
            // 
            this.lblPeriodx.AutoSize = true;
            this.lblPeriodx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodx.ForeColor = System.Drawing.Color.Black;
            this.lblPeriodx.Location = new System.Drawing.Point(1534, 891);
            this.lblPeriodx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeriodx.Name = "lblPeriodx";
            this.lblPeriodx.Size = new System.Drawing.Size(81, 24);
            this.lblPeriodx.TabIndex = 42;
            this.lblPeriodx.Text = "ARALIK";
            // 
            // dgvPeriodUp
            // 
            this.dgvPeriodUp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPeriodUp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvPeriodUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodUp.GridColor = System.Drawing.Color.Chartreuse;
            this.dgvPeriodUp.Location = new System.Drawing.Point(1279, 934);
            this.dgvPeriodUp.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPeriodUp.Name = "dgvPeriodUp";
            this.dgvPeriodUp.RowHeadersWidth = 62;
            this.dgvPeriodUp.RowTemplate.Height = 28;
            this.dgvPeriodUp.Size = new System.Drawing.Size(300, 200);
            this.dgvPeriodUp.TabIndex = 41;
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDown.Location = new System.Drawing.Point(1674, 649);
            this.lblDown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(94, 24);
            this.lblDown.TabIndex = 40;
            this.lblDown.Text = "Düşenler";
            // 
            // dgvDailyDown
            // 
            this.dgvDailyDown.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDailyDown.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvDailyDown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyDown.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvDailyDown.Location = new System.Drawing.Point(1583, 680);
            this.dgvDailyDown.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDailyDown.Name = "dgvDailyDown";
            this.dgvDailyDown.RowHeadersWidth = 62;
            this.dgvDailyDown.RowTemplate.Height = 28;
            this.dgvDailyDown.Size = new System.Drawing.Size(300, 200);
            this.dgvDailyDown.TabIndex = 39;
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUp.ForeColor = System.Drawing.Color.Green;
            this.lblUp.Location = new System.Drawing.Point(1375, 649);
            this.lblUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(120, 24);
            this.lblUp.TabIndex = 38;
            this.lblUp.Text = "Yükselenler";
            // 
            // lblDaily
            // 
            this.lblDaily.AutoSize = true;
            this.lblDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaily.ForeColor = System.Drawing.Color.Black;
            this.lblDaily.Location = new System.Drawing.Point(1529, 626);
            this.lblDaily.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDaily.Name = "lblDaily";
            this.lblDaily.Size = new System.Drawing.Size(92, 24);
            this.lblDaily.TabIndex = 37;
            this.lblDaily.Text = "GÜNLÜK";
            // 
            // dgvDailyUp
            // 
            this.dgvDailyUp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDailyUp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvDailyUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyUp.GridColor = System.Drawing.Color.Chartreuse;
            this.dgvDailyUp.Location = new System.Drawing.Point(1279, 679);
            this.dgvDailyUp.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDailyUp.Name = "dgvDailyUp";
            this.dgvDailyUp.RowHeadersWidth = 62;
            this.dgvDailyUp.RowTemplate.Height = 28;
            this.dgvDailyUp.Size = new System.Drawing.Size(300, 200);
            this.dgvDailyUp.TabIndex = 36;
            // 
            // dgv100_2
            // 
            this.dgv100_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv100_2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv100_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv100_2.Location = new System.Drawing.Point(1235, 69);
            this.dgv100_2.Margin = new System.Windows.Forms.Padding(2);
            this.dgv100_2.Name = "dgv100_2";
            this.dgv100_2.RowHeadersWidth = 62;
            this.dgv100_2.RowTemplate.Height = 28;
            this.dgv100_2.Size = new System.Drawing.Size(407, 466);
            this.dgv100_2.TabIndex = 35;
            // 
            // lblBist100
            // 
            this.lblBist100.AutoSize = true;
            this.lblBist100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblBist100.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBist100.ForeColor = System.Drawing.Color.Navy;
            this.lblBist100.Location = new System.Drawing.Point(1183, 42);
            this.lblBist100.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBist100.Name = "lblBist100";
            this.lblBist100.Size = new System.Drawing.Size(93, 24);
            this.lblBist100.TabIndex = 34;
            this.lblBist100.Text = "BIST 100";
            // 
            // dgv100_1
            // 
            this.dgv100_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv100_1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv100_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv100_1.Location = new System.Drawing.Point(828, 69);
            this.dgv100_1.Margin = new System.Windows.Forms.Padding(2);
            this.dgv100_1.Name = "dgv100_1";
            this.dgv100_1.RowHeadersWidth = 62;
            this.dgv100_1.RowTemplate.Height = 28;
            this.dgv100_1.Size = new System.Drawing.Size(407, 466);
            this.dgv100_1.TabIndex = 33;
            // 
            // lblBist50
            // 
            this.lblBist50.AutoSize = true;
            this.lblBist50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblBist50.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBist50.ForeColor = System.Drawing.Color.Navy;
            this.lblBist50.Location = new System.Drawing.Point(580, 42);
            this.lblBist50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBist50.Name = "lblBist50";
            this.lblBist50.Size = new System.Drawing.Size(82, 24);
            this.lblBist50.TabIndex = 32;
            this.lblBist50.Text = "BIST 50";
            // 
            // dgv50
            // 
            this.dgv50.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv50.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv50.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv50.Location = new System.Drawing.Point(416, 69);
            this.dgv50.Margin = new System.Windows.Forms.Padding(2);
            this.dgv50.Name = "dgv50";
            this.dgv50.RowHeadersWidth = 62;
            this.dgv50.RowTemplate.Height = 28;
            this.dgv50.Size = new System.Drawing.Size(407, 380);
            this.dgv50.TabIndex = 31;
            // 
            // lblBist30
            // 
            this.lblBist30.AutoSize = true;
            this.lblBist30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblBist30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBist30.ForeColor = System.Drawing.Color.Navy;
            this.lblBist30.Location = new System.Drawing.Point(156, 43);
            this.lblBist30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBist30.Name = "lblBist30";
            this.lblBist30.Size = new System.Drawing.Size(82, 24);
            this.lblBist30.TabIndex = 30;
            this.lblBist30.Text = "BIST 30";
            // 
            // dgv30
            // 
            this.dgv30.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv30.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv30.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv30.Location = new System.Drawing.Point(4, 69);
            this.dgv30.Margin = new System.Windows.Forms.Padding(2);
            this.dgv30.Name = "dgv30";
            this.dgv30.RowHeadersWidth = 62;
            this.dgv30.RowTemplate.Height = 28;
            this.dgv30.ShowEditingIcon = false;
            this.dgv30.Size = new System.Drawing.Size(407, 550);
            this.dgv30.TabIndex = 29;
            // 
            // nudLastProcessCount
            // 
            this.nudLastProcessCount.Location = new System.Drawing.Point(328, 14);
            this.nudLastProcessCount.Margin = new System.Windows.Forms.Padding(2);
            this.nudLastProcessCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLastProcessCount.Name = "nudLastProcessCount";
            this.nudLastProcessCount.Size = new System.Drawing.Size(43, 20);
            this.nudLastProcessCount.TabIndex = 28;
            this.nudLastProcessCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLastProcessCount.ValueChanged += new System.EventHandler(this.nudLastProcessCount_ValueChanged);
            // 
            // lblLastProcessCount
            // 
            this.lblLastProcessCount.AutoSize = true;
            this.lblLastProcessCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastProcessCount.Location = new System.Drawing.Point(218, 16);
            this.lblLastProcessCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastProcessCount.Name = "lblLastProcessCount";
            this.lblLastProcessCount.Size = new System.Drawing.Size(99, 13);
            this.lblLastProcessCount.TabIndex = 27;
            this.lblLastProcessCount.Text = "Son İşlem Sayısı";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(92, 16);
            this.lblPeriod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(46, 13);
            this.lblPeriod.TabIndex = 26;
            this.lblPeriod.Text = "Periyot";
            // 
            // dgvShare
            // 
            this.dgvShare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvShare.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvShare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShare.Location = new System.Drawing.Point(4, 680);
            this.dgvShare.Margin = new System.Windows.Forms.Padding(2);
            this.dgvShare.Name = "dgvShare";
            this.dgvShare.RowHeadersWidth = 62;
            this.dgvShare.RowTemplate.Height = 28;
            this.dgvShare.Size = new System.Drawing.Size(1272, 454);
            this.dgvShare.TabIndex = 25;
            // 
            // cbxPeriod
            // 
            this.cbxPeriod.FormattingEnabled = true;
            this.cbxPeriod.Items.AddRange(new object[] {
            "1m",
            "15m",
            "30m",
            "1h",
            "1d",
            "1w",
            "1M"});
            this.cbxPeriod.Location = new System.Drawing.Point(147, 14);
            this.cbxPeriod.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPeriod.Name = "cbxPeriod";
            this.cbxPeriod.Size = new System.Drawing.Size(44, 21);
            this.cbxPeriod.TabIndex = 24;
            this.cbxPeriod.SelectedIndexChanged += new System.EventHandler(this.cbxPeriod_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1868, 875);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BINANCE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 1181);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "EMTİA Analiz Ekranı";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv100_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv100_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastProcessCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbxPeriod;
        private System.Windows.Forms.DataGridView dgvShare;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblLastProcessCount;
        private System.Windows.Forms.NumericUpDown nudLastProcessCount;
        private System.Windows.Forms.DataGridView dgv30;
        private System.Windows.Forms.Label lblBist30;
        private System.Windows.Forms.Label lblBist50;
        private System.Windows.Forms.DataGridView dgv50;
        private System.Windows.Forms.Label lblBist100;
        private System.Windows.Forms.DataGridView dgv100_1;
        private System.Windows.Forms.DataGridView dgv100_2;
        private System.Windows.Forms.DataGridView dgvDailyUp;
        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.Label lblDaily;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.DataGridView dgvDailyDown;
        private System.Windows.Forms.Label lblPeriodDown;
        private System.Windows.Forms.DataGridView dgvPeriodDown;
        private System.Windows.Forms.Label lblPeriodUp;
        private System.Windows.Forms.Label lblPeriodx;
        private System.Windows.Forms.DataGridView dgvPeriodUp;
        private System.Windows.Forms.ComboBox cbxSymbol;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblShare;
    }
}
