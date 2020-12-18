
namespace EBookDevexpress
{
    partial class WeeklyChartForm
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.FullStackedLineSeriesView fullStackedLineSeriesView1 = new DevExpress.XtraCharts.FullStackedLineSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            this.timeSpanChartRangeControlClient1 = new DevExpress.XtraEditors.TimeSpanChartRangeControlClient();
            this.chartCntrlWeekly = new DevExpress.XtraCharts.ChartControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.weekSelectControl1 = new EBookDevexpress.WeekSelectControl();
            this.bdsWeek = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCntrlWeekly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedLineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWeek)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCntrlWeekly
            // 
            this.chartCntrlWeekly.DataSource = this.bdsWeek;
            xyDiagram1.AxisX.MinorCount = 5;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.PaneDistance = 100;
            this.chartCntrlWeekly.Diagram = xyDiagram1;
            this.chartCntrlWeekly.Legend.Name = "Default Legend";
            this.chartCntrlWeekly.Location = new System.Drawing.Point(26, 130);
            this.chartCntrlWeekly.Name = "chartCntrlWeekly";
            series1.Name = "경제";
            series1.View = lineSeriesView1;
            series2.Name = "교양";
            series2.View = fullStackedLineSeriesView1;
            series3.Name = "문학";
            series3.View = lineSeriesView2;
            series4.Name = "사회과학";
            series4.View = lineSeriesView3;
            this.chartCntrlWeekly.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3,
        series4};
            this.chartCntrlWeekly.Size = new System.Drawing.Size(558, 324);
            this.chartCntrlWeekly.TabIndex = 2;
            // 
            // weekSelectControl1
            // 
            this.weekSelectControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.weekSelectControl1.Location = new System.Drawing.Point(0, 0);
            this.weekSelectControl1.Name = "weekSelectControl1";
            this.weekSelectControl1.Size = new System.Drawing.Size(864, 99);
            this.weekSelectControl1.TabIndex = 3;
            this.weekSelectControl1.ButtonWeekSearch += new System.EventHandler<EBookDevexpress.WeekSelectControl.ButtonWeekSearchEventArgs>(this.weekSelectControl1_ButtonWeekSearch);
            // 
            // bdsWeek
            // 
            this.bdsWeek.DataSource = typeof(EBook.Data.Models.PeriodSummary);
            // 
            // WeeklyChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 493);
            this.Controls.Add(this.weekSelectControl1);
            this.Controls.Add(this.chartCntrlWeekly);
            this.Name = "WeeklyChartForm";
            this.Text = "주간 대여";
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedLineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCntrlWeekly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWeek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TimeSpanChartRangeControlClient timeSpanChartRangeControlClient1;
        private DevExpress.XtraCharts.ChartControl chartCntrlWeekly;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private WeekSelectControl weekSelectControl1;
        private System.Windows.Forms.BindingSource bdsWeek;
    }
}