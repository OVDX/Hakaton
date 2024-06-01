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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.nameCmb = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.typeCmb = new System.Windows.Forms.ComboBox();
			this.countPlace = new LiveCharts.WinForms.CartesianChart();
			this.pricePlace = new LiveCharts.WinForms.CartesianChart();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1904, 1041);
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
			this.tabPage1.Size = new System.Drawing.Size(1896, 998);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Номенклатури";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.tabPage3);
			this.tabControl2.Controls.Add(this.tabPage5);
			this.tabControl2.Location = new System.Drawing.Point(34, 164);
			this.tabControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(1811, 789);
			this.tabControl2.TabIndex = 4;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.cartesianChart1);
			this.tabPage3.Location = new System.Drawing.Point(4, 39);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage3.Size = new System.Drawing.Size(1164, 450);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "Кількість за місяці";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// cartesianChart1
			// 
			this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cartesianChart1.Location = new System.Drawing.Point(2, 2);
			this.cartesianChart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cartesianChart1.Name = "cartesianChart1";
			this.cartesianChart1.Size = new System.Drawing.Size(1160, 446);
			this.cartesianChart1.TabIndex = 0;
			this.cartesianChart1.Text = "cartesianChart1";
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.pricePlace);
			this.tabPage5.Controls.Add(this.countPlace);
			this.tabPage5.Location = new System.Drawing.Point(4, 39);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(1803, 746);
			this.tabPage5.TabIndex = 2;
			this.tabPage5.Text = "По місцю продажу";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(532, 23);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 30);
			this.label2.TabIndex = 3;
			this.label2.Text = "Номенклатура";
			// 
			// nameCmb
			// 
			this.nameCmb.FormattingEnabled = true;
			this.nameCmb.Location = new System.Drawing.Point(530, 67);
			this.nameCmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.nameCmb.Name = "nameCmb";
			this.nameCmb.Size = new System.Drawing.Size(609, 38);
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
			this.typeCmb.Size = new System.Drawing.Size(469, 38);
			this.typeCmb.TabIndex = 0;
			this.typeCmb.SelectedIndexChanged += new System.EventHandler(this.typeCmb_SelectedIndexChanged);
			// 
			// countPlace
			// 
			this.countPlace.Location = new System.Drawing.Point(3, 3);
			this.countPlace.Name = "countPlace";
			this.countPlace.Size = new System.Drawing.Size(870, 717);
			this.countPlace.TabIndex = 2;
			this.countPlace.Text = "cartesianChart2";
			// 
			// pricePlace
			// 
			this.pricePlace.Location = new System.Drawing.Point(899, 15);
			this.pricePlace.Name = "pricePlace";
			this.pricePlace.Size = new System.Drawing.Size(901, 705);
			this.pricePlace.TabIndex = 3;
			this.pricePlace.Text = "cartesianChart2";
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1904, 1041);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "mainForm";
			this.Text = "mainForm";
			this.Load += new System.EventHandler(this.mainForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabControl2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nameCmb;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.TabPage tabPage5;
		private LiveCharts.WinForms.CartesianChart pricePlace;
		private LiveCharts.WinForms.CartesianChart countPlace;
	}
}