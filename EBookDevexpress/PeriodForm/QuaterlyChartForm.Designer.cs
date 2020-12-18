
namespace EBookDevexpress
{
    partial class QuaterlyChartForm
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
            this.chartCntrlQuarterly = new DevExpress.XtraCharts.ChartControl();
            this.quarterSelectControl1 = new EBookDevexpress.QuarterSelectControl();
            this.genreSelectControl1 = new EBookDevexpress.GenreSelectControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.quarterSelectControl2 = new EBookDevexpress.QuarterSelectControl();
            this.bdsQuarter = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartCntrlQuarterly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedLineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsQuarter)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCntrlQuarterly
            // 
            xyDiagram1.AxisX.MinorCount = 5;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.PaneDistance = 100;
            this.chartCntrlQuarterly.Diagram = xyDiagram1;
            this.chartCntrlQuarterly.Legend.Name = "Default Legend";
            this.chartCntrlQuarterly.Location = new System.Drawing.Point(12, 115);
            this.chartCntrlQuarterly.Name = "chartCntrlQuarterly";
            series1.Name = "경제";
            series1.View = lineSeriesView1;
            series2.Name = "교양";
            series2.View = fullStackedLineSeriesView1;
            series3.Name = "문학";
            series3.View = lineSeriesView2;
            series4.Name = "사회과학";
            series4.View = lineSeriesView3;
            this.chartCntrlQuarterly.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3,
        series4};
            this.chartCntrlQuarterly.Size = new System.Drawing.Size(558, 324);
            this.chartCntrlQuarterly.TabIndex = 4;
            // 
            // quarterSelectControl1
            // 
            this.quarterSelectControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.quarterSelectControl1.Location = new System.Drawing.Point(0, 0);
            this.quarterSelectControl1.Name = "quarterSelectControl1";
            this.quarterSelectControl1.Size = new System.Drawing.Size(813, 98);
            this.quarterSelectControl1.TabIndex = 7;
            // 
            // genreSelectControl1
            // 
            this.genreSelectControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.genreSelectControl1.Location = new System.Drawing.Point(593, 98);
            this.genreSelectControl1.Name = "genreSelectControl1";
            this.genreSelectControl1.Size = new System.Drawing.Size(220, 401);
            this.genreSelectControl1.TabIndex = 8;
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.bdsQuarter;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(154, 179);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(300, 200);
            this.chartControl1.TabIndex = 0;
            // 
            // quarterSelectControl2
            // 
            this.quarterSelectControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.quarterSelectControl2.Location = new System.Drawing.Point(0, 0);
            this.quarterSelectControl2.Name = "quarterSelectControl2";
            this.quarterSelectControl2.Size = new System.Drawing.Size(813, 98);
            this.quarterSelectControl2.TabIndex = 1;
            // 
            // bdsQuarter
            // 
            this.bdsQuarter.DataSource = typeof(EBook.Data.Models.PeriodSummary);
            // 
            // QuaterlyChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 499);
            this.Controls.Add(this.quarterSelectControl2);
            this.Controls.Add(this.chartControl1);
            this.Name = "QuaterlyChartForm";
            this.Text = "분기 대여";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedLineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCntrlQuarterly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsQuarter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl chartCntrlQuarterly;
        private QuarterSelectControl quarterSelectControl1;
        private GenreSelectControl genreSelectControl1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource bdsQuarter;
        private QuarterSelectControl quarterSelectControl2;
    }
}