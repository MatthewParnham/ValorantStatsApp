namespace ValorantStatsApp
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MapComboBox = new System.Windows.Forms.ComboBox();
            this.HeroComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.WinLossComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.MatchReportButton = new System.Windows.Forms.Button();
            this.matchesPanel = new System.Windows.Forms.Panel();
            this.StatsPageButton = new System.Windows.Forms.Button();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.weaponsDataGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.HeroDataGridView = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.matchesPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 378);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // MapComboBox
            // 
            this.MapComboBox.FormattingEnabled = true;
            this.MapComboBox.Location = new System.Drawing.Point(32, 28);
            this.MapComboBox.Name = "MapComboBox";
            this.MapComboBox.Size = new System.Drawing.Size(121, 21);
            this.MapComboBox.TabIndex = 3;
            this.MapComboBox.SelectedIndexChanged += new System.EventHandler(this.MapComboBox_SelectedIndexChanged);
            // 
            // HeroComboBox
            // 
            this.HeroComboBox.FormattingEnabled = true;
            this.HeroComboBox.Location = new System.Drawing.Point(619, 493);
            this.HeroComboBox.Name = "HeroComboBox";
            this.HeroComboBox.Size = new System.Drawing.Size(121, 21);
            this.HeroComboBox.TabIndex = 4;
            this.HeroComboBox.SelectedIndexChanged += new System.EventHandler(this.HeroComboBox_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(319, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(525, 29);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // WinLossComboBox
            // 
            this.WinLossComboBox.FormattingEnabled = true;
            this.WinLossComboBox.Items.AddRange(new object[] {
            "Any",
            "Won",
            "Lost"});
            this.WinLossComboBox.Location = new System.Drawing.Point(174, 28);
            this.WinLossComboBox.Name = "WinLossComboBox";
            this.WinLossComboBox.Size = new System.Drawing.Size(121, 21);
            this.WinLossComboBox.TabIndex = 8;
            this.WinLossComboBox.SelectedIndexChanged += new System.EventHandler(this.WinLossComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Map";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Won/Lost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Match Date Between";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(491, 520);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1036, 279);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.Tag = "Scoreboard";
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hero";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(619, 77);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(908, 378);
            this.dataGridView3.TabIndex = 14;
            this.dataGridView3.Tag = "Timeline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Match Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Scoreboard";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(616, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Timeline";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(32, 520);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(441, 179);
            this.dataGridView4.TabIndex = 18;
            this.dataGridView4.Tag = "Performance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Performance";
            // 
            // MatchReportButton
            // 
            this.MatchReportButton.Location = new System.Drawing.Point(22, 794);
            this.MatchReportButton.Name = "MatchReportButton";
            this.MatchReportButton.Size = new System.Drawing.Size(131, 30);
            this.MatchReportButton.TabIndex = 20;
            this.MatchReportButton.Text = "Generate Match Report";
            this.MatchReportButton.UseVisualStyleBackColor = true;
            this.MatchReportButton.Click += new System.EventHandler(this.MatchReportButton_Click);
            // 
            // matchesPanel
            // 
            this.matchesPanel.Controls.Add(this.label7);
            this.matchesPanel.Controls.Add(this.label8);
            this.matchesPanel.Controls.Add(this.StatsPageButton);
            this.matchesPanel.Controls.Add(this.label5);
            this.matchesPanel.Controls.Add(this.MatchReportButton);
            this.matchesPanel.Controls.Add(this.MapComboBox);
            this.matchesPanel.Controls.Add(this.label1);
            this.matchesPanel.Controls.Add(this.dataGridView4);
            this.matchesPanel.Controls.Add(this.WinLossComboBox);
            this.matchesPanel.Controls.Add(this.label2);
            this.matchesPanel.Controls.Add(this.dataGridView3);
            this.matchesPanel.Controls.Add(this.label6);
            this.matchesPanel.Controls.Add(this.dataGridView2);
            this.matchesPanel.Controls.Add(this.dateTimePicker2);
            this.matchesPanel.Controls.Add(this.dataGridView1);
            this.matchesPanel.Controls.Add(this.dateTimePicker1);
            this.matchesPanel.Controls.Add(this.label4);
            this.matchesPanel.Controls.Add(this.label3);
            this.matchesPanel.Controls.Add(this.HeroComboBox);
            this.matchesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchesPanel.Location = new System.Drawing.Point(0, 0);
            this.matchesPanel.Name = "matchesPanel";
            this.matchesPanel.Size = new System.Drawing.Size(1584, 861);
            this.matchesPanel.TabIndex = 21;
            // 
            // StatsPageButton
            // 
            this.StatsPageButton.Location = new System.Drawing.Point(1497, 12);
            this.StatsPageButton.Name = "StatsPageButton";
            this.StatsPageButton.Size = new System.Drawing.Size(75, 23);
            this.StatsPageButton.TabIndex = 21;
            this.StatsPageButton.Text = "View Stats";
            this.StatsPageButton.UseVisualStyleBackColor = true;
            this.StatsPageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // statsPanel
            // 
            this.statsPanel.Controls.Add(this.UsernameBox);
            this.statsPanel.Controls.Add(this.label10);
            this.statsPanel.Controls.Add(this.HeroDataGridView);
            this.statsPanel.Controls.Add(this.label9);
            this.statsPanel.Controls.Add(this.weaponsDataGridView);
            this.statsPanel.Controls.Add(this.chart1);
            this.statsPanel.Controls.Add(this.BackButton);
            this.statsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsPanel.Location = new System.Drawing.Point(0, 0);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(1584, 861);
            this.statsPanel.TabIndex = 22;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(1497, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(746, 217);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(426, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // weaponsDataGridView
            // 
            this.weaponsDataGridView.AllowUserToAddRows = false;
            this.weaponsDataGridView.AllowUserToDeleteRows = false;
            this.weaponsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weaponsDataGridView.Location = new System.Drawing.Point(32, 77);
            this.weaponsDataGridView.Name = "weaponsDataGridView";
            this.weaponsDataGridView.ReadOnly = true;
            this.weaponsDataGridView.Size = new System.Drawing.Size(247, 413);
            this.weaponsDataGridView.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Favorite Weapons";
            // 
            // HeroDataGridView
            // 
            this.HeroDataGridView.AllowUserToAddRows = false;
            this.HeroDataGridView.AllowUserToDeleteRows = false;
            this.HeroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HeroDataGridView.Location = new System.Drawing.Point(319, 77);
            this.HeroDataGridView.Name = "HeroDataGridView";
            this.HeroDataGridView.ReadOnly = true;
            this.HeroDataGridView.Size = new System.Drawing.Size(247, 413);
            this.HeroDataGridView.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Favorite Heroes";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(322, 29);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(100, 20);
            this.UsernameBox.TabIndex = 6;
            this.UsernameBox.TextChanged += new System.EventHandler(this.UsernameBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.matchesPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Valorant Stats App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.matchesPanel.ResumeLayout(false);
            this.matchesPanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox MapComboBox;
        private System.Windows.Forms.ComboBox HeroComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox WinLossComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button MatchReportButton;
        private System.Windows.Forms.Panel matchesPanel;
        private System.Windows.Forms.Button StatsPageButton;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView weaponsDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView HeroDataGridView;
    }
}

