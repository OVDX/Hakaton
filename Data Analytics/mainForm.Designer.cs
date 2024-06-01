namespace Data_Analytics
{
    partial class mainForm
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.nameCmb = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.typeCmb = new System.Windows.Forms.ComboBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
			this.pieChart1 = new LiveCharts.Wpf.PieChart();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.placePrice = new System.Windows.Forms.Integration.ElementHost();
			this.pieChart2 = new LiveCharts.Wpf.PieChart();
			this.placeCount = new System.Windows.Forms.Integration.ElementHost();
			this.pieChart3 = new LiveCharts.Wpf.PieChart();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1257, 724);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tabControl2);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.nameCmb);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.typeCmb);
			this.tabPage1.Location = new System.Drawing.Point(4, 39);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage1.Size = new System.Drawing.Size(1249, 681);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Номенклатури";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.tabPage3);
			this.tabControl2.Controls.Add(this.tabPage4);
			this.tabControl2.Controls.Add(this.tabPage5);
			this.tabControl2.Location = new System.Drawing.Point(34, 164);
			this.tabControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(1172, 493);
			this.tabControl2.TabIndex = 4;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 39);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage3.Size = new System.Drawing.Size(1164, 450);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "Графік 1";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.elementHost1);
			this.tabPage4.Location = new System.Drawing.Point(4, 39);
			this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage4.Size = new System.Drawing.Size(1164, 450);
			this.tabPage4.TabIndex = 1;
			this.tabPage4.Text = "Графік 2";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(311, 23);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 30);
			this.label2.TabIndex = 3;
			this.label2.Text = "Номенклатура";
			// 
			// nameCmb
			// 
			this.nameCmb.FormattingEnabled = true;
			this.nameCmb.Location = new System.Drawing.Point(316, 67);
			this.nameCmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.nameCmb.Name = "nameCmb";
			this.nameCmb.Size = new System.Drawing.Size(824, 38);
			this.nameCmb.TabIndex = 2;
			this.nameCmb.SelectedIndexChanged += new System.EventHandler(this.nameCmb_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 23);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(203, 30);
			this.label1.TabIndex = 1;
			this.label1.Text = "Тип номенклатури";
			// 
			// typeCmb
			// 
			this.typeCmb.FormattingEnabled = true;
			this.typeCmb.Location = new System.Drawing.Point(34, 67);
			this.typeCmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.typeCmb.Name = "typeCmb";
			this.typeCmb.Size = new System.Drawing.Size(243, 38);
			this.typeCmb.TabIndex = 0;
			this.typeCmb.SelectedIndexChanged += new System.EventHandler(this.typeCmb_SelectedIndexChanged);
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 39);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage2.Size = new System.Drawing.Size(1249, 681);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Сезони";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// elementHost1
			// 
			this.elementHost1.Location = new System.Drawing.Point(18, 20);
			this.elementHost1.Name = "elementHost1";
			this.elementHost1.Size = new System.Drawing.Size(478, 407);
			this.elementHost1.TabIndex = 0;
			this.elementHost1.Text = "elementHost1";
			this.elementHost1.Child = this.pieChart1;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.chart1);
			this.tabPage5.Controls.Add(this.placeCount);
			this.tabPage5.Controls.Add(this.placePrice);
			this.tabPage5.Location = new System.Drawing.Point(4, 39);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(1164, 450);
			this.tabPage5.TabIndex = 2;
			this.tabPage5.Text = "Графік 3";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// placePrice
			// 
			this.placePrice.Location = new System.Drawing.Point(3, 3);
			this.placePrice.Name = "placePrice";
			this.placePrice.Size = new System.Drawing.Size(457, 370);
			this.placePrice.TabIndex = 0;
			this.placePrice.Text = "elementHost2";
			this.placePrice.Child = this.pieChart2;
			// 
			// placeCount
			// 
			this.placeCount.Location = new System.Drawing.Point(467, 4);
			this.placeCount.Name = "placeCount";
			this.placeCount.Size = new System.Drawing.Size(684, 382);
			this.placeCount.TabIndex = 1;
			this.placeCount.Text = "elementHost3";
			this.placeCount.Child = this.pieChart3;
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(3, 4);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(409, 369);
			this.chart1.TabIndex = 2;
			this.chart1.Text = "chart1";
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1257, 724);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "mainForm";
			this.Text = "mainForm";
			this.Load += new System.EventHandler(this.mainForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabControl2.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeCmb;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nameCmb;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Integration.ElementHost elementHost1;
		private LiveCharts.Wpf.PieChart pieChart1;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.Integration.ElementHost placeCount;
		private LiveCharts.Wpf.PieChart pieChart3;
		private System.Windows.Forms.Integration.ElementHost placePrice;
		private LiveCharts.Wpf.PieChart pieChart2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
	}
}