
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
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView4 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.FullStackedLineSeriesView fullStackedLineSeriesView2 = new DevExpress.XtraCharts.FullStackedLineSeriesView();
            DevExpress.XtraCharts.Series series7 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView5 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series8 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView6 = new DevExpress.XtraCharts.LineSeriesView();
            this.timeSpanChartRangeControlClient1 = new DevExpress.XtraEditors.TimeSpanChartRangeControlClient();
            this.chartCntrlWeekly = new DevExpress.XtraCharts.ChartControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.weekSelectControl1 = new EBookDevexpress.WeekSelectControl();
            this.genreSelectControl1 = new EBookDevexpress.GenreSelectControl();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCntrlWeekly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedLineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCntrlWeekly
            // 
            xyDiagram2.AxisX.MinorCount = 5;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.EnableAxisXScrolling = true;
            xyDiagram2.PaneDistance = 100;
            this.chartCntrlWeekly.Diagram = xyDiagram2;
            this.chartCntrlWeekly.Legend.Name = "Default Legend";
            this.chartCntrlWeekly.Location = new System.Drawing.Point(26, 155);
            this.chartCntrlWeekly.Name = "chartCntrlWeekly";
            series5.Name = "경제";
            series5.View = lineSeriesView4;
            series6.Name = "교양";
            series6.View = fullStackedLineSeriesView2;
            series7.Name = "문학";
            series7.View = lineSeriesView5;
            series8.Name = "사회과학";
            series8.View = lineSeriesView6;
            this.chartCntrlWeekly.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series5,
        series6,
        series7,
        series8};
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
            // 
            // genreSelectControl1
            // 
            this.genreSelectControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.genreSelectControl1.Location = new System.Drawing.Point(644, 99);
            this.genreSelectControl1.Name = "genreSelectControl1";
            this.genreSelectControl1.Size = new System.Drawing.Size(220, 394);
            this.genreSelectControl1.TabIndex = 4;
            // 
            // WeeklyChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 493);
            this.Controls.Add(this.genreSelectControl1);
            this.Controls.Add(this.weekSelectControl1);
            this.Controls.Add(this.chartCntrlWeekly);
            this.Name = "WeeklyChartForm";
            this.Text = "주간 대여";
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedLineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCntrlWeekly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TimeSpanChartRangeControlClient timeSpanChartRangeControlClient1;
        private DevExpress.XtraCharts.ChartControl chartCntrlWeekly;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private WeekSelectControl weekSelectControl1;
        private GenreSelectControl genreSelectControl1;
    }
}