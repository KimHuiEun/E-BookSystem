
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
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series8 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView7 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series9 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.FullStackedLineSeriesView fullStackedLineSeriesView2 = new DevExpress.XtraCharts.FullStackedLineSeriesView();
            DevExpress.XtraCharts.Series series10 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView8 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series11 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView9 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram4 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series12 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView10 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series13 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView11 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series14 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView12 = new DevExpress.XtraCharts.LineSeriesView();
            this.chartCntrlQuarterly = new DevExpress.XtraCharts.ChartControl();
            this.quarterSelectControl1 = new EBookDevexpress.QuarterSelectControl();
            this.genreSelectControl1 = new EBookDevexpress.GenreSelectControl();
            this.bdsQuarter = new System.Windows.Forms.BindingSource(this.components);
            this.chartCntrlQuaterly = new DevExpress.XtraCharts.ChartControl();
            this.quarterSelectControl2 = new EBookDevexpress.QuarterSelectControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartCntrlQuarterly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedLineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsQuarter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCntrlQuaterly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView12)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCntrlQuarterly
            // 
            xyDiagram3.AxisX.MinorCount = 5;
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram3.EnableAxisXScrolling = true;
            xyDiagram3.PaneDistance = 100;
            this.chartCntrlQuarterly.Diagram = xyDiagram3;
            this.chartCntrlQuarterly.Legend.Name = "Default Legend";
            this.chartCntrlQuarterly.Location = new System.Drawing.Point(12, 115);
            this.chartCntrlQuarterly.Name = "chartCntrlQuarterly";
            series8.Name = "경제";
            series8.View = lineSeriesView7;
            series9.Name = "교양";
            series9.View = fullStackedLineSeriesView2;
            series10.Name = "문학";
            series10.View = lineSeriesView8;
            series11.Name = "사회과학";
            series11.View = lineSeriesView9;
            this.chartCntrlQuarterly.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series8,
        series9,
        series10,
        series11};
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
            // bdsQuarter
            // 
            this.bdsQuarter.DataSource = typeof(EBook.Data.Models.PeriodSummary);
            // 
            // chartCntrlQuaterly
            // 
            this.chartCntrlQuaterly.DataSource = this.bdsQuarter;
            xyDiagram4.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram4.AxisY.VisibleInPanesSerializable = "-1";
            this.chartCntrlQuaterly.Diagram = xyDiagram4;
            this.chartCntrlQuaterly.Legend.Name = "Default Legend";
            this.chartCntrlQuaterly.Location = new System.Drawing.Point(1, 104);
            this.chartCntrlQuaterly.Name = "chartCntrlQuaterly";
            series12.Name = "경제";
            series12.View = lineSeriesView10;
            series13.Name = "교양";
            series13.View = lineSeriesView11;
            series14.Name = "사회과학";
            series14.View = lineSeriesView12;
            this.chartCntrlQuaterly.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series12,
        series13,
        series14};
            this.chartCntrlQuaterly.Size = new System.Drawing.Size(815, 397);
            this.chartCntrlQuaterly.TabIndex = 1;
            // 
            // quarterSelectControl2
            // 
            this.quarterSelectControl2.Location = new System.Drawing.Point(1, 0);
            this.quarterSelectControl2.Name = "quarterSelectControl2";
            this.quarterSelectControl2.Size = new System.Drawing.Size(815, 98);
            this.quarterSelectControl2.TabIndex = 2;
            // 
            // QuaterlyChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 499);
            this.Controls.Add(this.quarterSelectControl2);
            this.Controls.Add(this.chartCntrlQuaterly);
            this.Name = "QuaterlyChartForm";
            this.Text = "분기 대여";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedLineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCntrlQuarterly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsQuarter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCntrlQuaterly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl chartCntrlQuarterly;
        private QuarterSelectControl quarterSelectControl1;
        private GenreSelectControl genreSelectControl1;
        private System.Windows.Forms.BindingSource bdsQuarter;
        private DevExpress.XtraCharts.ChartControl chartCntrlQuaterly;
        private QuarterSelectControl quarterSelectControl2;
    }
}