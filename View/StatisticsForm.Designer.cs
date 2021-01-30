namespace OO_Seminar.View
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartRatings = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCalories = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPrices = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRatings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrices)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRatings
            // 
            chartArea1.AxisX.Maximum = 11D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chartRatings.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartRatings.Legends.Add(legend1);
            this.chartRatings.Location = new System.Drawing.Point(12, 12);
            this.chartRatings.Name = "chartRatings";
            this.chartRatings.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ratings";
            this.chartRatings.Series.Add(series1);
            this.chartRatings.Size = new System.Drawing.Size(376, 300);
            this.chartRatings.TabIndex = 0;
            this.chartRatings.Text = "chart1";
            title1.Name = "Ratings";
            title1.Text = "Ratings";
            this.chartRatings.Titles.Add(title1);
            // 
            // chartCalories
            // 
            chartArea2.AxisX.Maximum = 11D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chartCalories.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartCalories.Legends.Add(legend2);
            this.chartCalories.Location = new System.Drawing.Point(394, 12);
            this.chartCalories.Name = "chartCalories";
            this.chartCalories.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Calories";
            this.chartCalories.Series.Add(series2);
            this.chartCalories.Size = new System.Drawing.Size(376, 300);
            this.chartCalories.TabIndex = 1;
            this.chartCalories.Text = "chartCalories";
            title2.Name = "Calories";
            title2.Text = "Calories";
            this.chartCalories.Titles.Add(title2);
            // 
            // chartPrices
            // 
            chartArea3.AxisX.Maximum = 11D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.chartPrices.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartPrices.Legends.Add(legend3);
            this.chartPrices.Location = new System.Drawing.Point(776, 12);
            this.chartPrices.Name = "chartPrices";
            this.chartPrices.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Prices";
            this.chartPrices.Series.Add(series3);
            this.chartPrices.Size = new System.Drawing.Size(376, 300);
            this.chartPrices.TabIndex = 2;
            this.chartPrices.Text = "chart1";
            title3.Name = "Prices";
            title3.Text = "Prices";
            this.chartPrices.Titles.Add(title3);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 574);
            this.Controls.Add(this.chartPrices);
            this.Controls.Add(this.chartCalories);
            this.Controls.Add(this.chartRatings);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartRatings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRatings;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCalories;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrices;
    }
}