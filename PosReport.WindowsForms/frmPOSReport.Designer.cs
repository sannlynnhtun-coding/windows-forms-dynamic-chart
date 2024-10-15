namespace PosReport.WindowsForms
{
    partial class frmPOSReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.comboChartType = new System.Windows.Forms.ComboBox();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenerateReport);
            this.panel1.Controls.Add(this.comboChartType);
            this.panel1.Controls.Add(this.comboCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 81);
            this.panel1.TabIndex = 1;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(237, 38);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(169, 23);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // comboChartType
            // 
            this.comboChartType.FormattingEnabled = true;
            this.comboChartType.Location = new System.Drawing.Point(75, 40);
            this.comboChartType.Name = "comboChartType";
            this.comboChartType.Size = new System.Drawing.Size(121, 21);
            this.comboChartType.TabIndex = 1;
            // 
            // comboCustomer
            // 
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Location = new System.Drawing.Point(75, 13);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(121, 21);
            this.comboCustomer.TabIndex = 0;
            // 
            // chartSales
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea1);
            this.chartSales.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartSales.Legends.Add(legend1);
            this.chartSales.Location = new System.Drawing.Point(0, 81);
            this.chartSales.Name = "chartSales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSales.Series.Add(series1);
            this.chartSales.Size = new System.Drawing.Size(601, 369);
            this.chartSales.TabIndex = 2;
            this.chartSales.Text = "chart1";
            this.chartSales.Visible = false;
            // 
            // frmPOSReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.chartSales);
            this.Controls.Add(this.panel1);
            this.Name = "frmPOSReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.ComboBox comboChartType;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}

