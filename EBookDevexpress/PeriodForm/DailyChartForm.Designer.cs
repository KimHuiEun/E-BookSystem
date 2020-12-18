
namespace EBookDevexpress
{
    partial class DailyChartForm
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
            DevExpress.XtraCharts.SwiftPlotDiagram swiftPlotDiagram1 = new DevExpress.XtraCharts.SwiftPlotDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SwiftPlotSeriesView swiftPlotSeriesView1 = new DevExpress.XtraCharts.SwiftPlotSeriesView();
            this.timeSpanChartRangeControlClient1 = new DevExpress.XtraEditors.TimeSpanChartRangeControlClient();
            this.chartCntrlDaily = new DevExpress.XtraCharts.ChartControl();
            this.daySelectControl1 = new EBookDevexpress.DaySelectControl();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCntrlDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCntrlDaily
            // 
            swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartCntrlDaily.Diagram = swiftPlotDiagram1;
            this.chartCntrlDaily.Legend.Name = "Default Legend";
            this.chartCntrlDaily.Location = new System.Drawing.Point(26, 113);
            this.chartCntrlDaily.Name = "chartCntrlDaily";
            series1.Name = "일일 대여량";
            series1.View = swiftPlotSeriesView1;
            this.chartCntrlDaily.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartCntrlDaily.Size = new System.Drawing.Size(776, 345);
            this.chartCntrlDaily.TabIndex = 1;
            // 
            // daySelectControl1
            // 
            this.daySelectControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.daySelectControl1.Location = new System.Drawing.Point(0, 0);
            this.daySelectControl1.Name = "daySelectControl1";
            this.daySelectControl1.Size = new System.Drawing.Size(827, 98);
            this.daySelectControl1.TabIndex = 2;
            // 
            // DailyChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 502);
            this.Controls.Add(this.daySelectControl1);
            this.Controls.Add(this.chartCntrlDaily);
            this.Name = "DailyChartForm";
            this.Text = "일간 대여";
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCntrlDaily)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TimeSpanChartRangeControlClient timeSpanChartRangeControlClient1;
        private DevExpress.XtraCharts.ChartControl chartCntrlDaily;
        private DaySelectControl daySelectControl1;
    }
}