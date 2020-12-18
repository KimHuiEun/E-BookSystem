
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.chartCntrlDaily = new DevExpress.XtraCharts.ChartControl();
            this.daySelectControl2 = new EBookDevexpress.DaySelectControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartCntrlDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCntrlDaily
            // 
            swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartCntrlDaily.Diagram = swiftPlotDiagram1;
            this.chartCntrlDaily.Legend.Name = "Default Legend";
            this.chartCntrlDaily.Location = new System.Drawing.Point(22, 118);
            this.chartCntrlDaily.Name = "chartCntrlDaily";
            series1.ArgumentDataMember = "Hour";
            series1.Name = "일일 대여량";
            series1.ValueDataMembersSerializable = "Count";
            series1.View = swiftPlotSeriesView1;
            this.chartCntrlDaily.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartCntrlDaily.Size = new System.Drawing.Size(776, 345);
            this.chartCntrlDaily.TabIndex = 1;
            // 
            // daySelectControl2
            // 
            this.daySelectControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.daySelectControl2.Location = new System.Drawing.Point(0, 0);
            this.daySelectControl2.Name = "daySelectControl2";
            this.daySelectControl2.Size = new System.Drawing.Size(827, 98);
            this.daySelectControl2.TabIndex = 0;
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 98);
            this.chartControl1.Name = "chartControl1";
            series2.Name = "Series 1";
            series2.View = lineSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl1.Size = new System.Drawing.Size(827, 404);
            this.chartControl1.TabIndex = 1;
            // 
            // DailyChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 502);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.daySelectControl2);
            this.Name = "DailyChartForm";
            this.Text = "일간 대여";
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCntrlDaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl chartCntrlDaily;
        private DaySelectControl daySelectControl1;
        private DaySelectControl daySelectControl2;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}