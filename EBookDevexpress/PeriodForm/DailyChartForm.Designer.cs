
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.daySelectControl1 = new EBookDevexpress.DaySelectControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.bdsDay = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDay)).BeginInit();
            this.SuspendLayout();
            // 
            // daySelectControl1
            // 
            this.daySelectControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.daySelectControl1.Location = new System.Drawing.Point(0, 0);
            this.daySelectControl1.Name = "daySelectControl1";
            this.daySelectControl1.Size = new System.Drawing.Size(853, 98);
            this.daySelectControl1.TabIndex = 0;
            this.daySelectControl1.ButtonDaySearch += new System.EventHandler<EBookDevexpress.DaySelectControl.ButtonDaySearchEventArgs>(this.daySelectControl1_ButtonDaySearch);
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.bdsDay;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 98);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Series 1";
            series1.View = lineSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(853, 388);
            this.chartControl1.TabIndex = 1;
            // 
            // bdsDay
            // 
            this.bdsDay.DataSource = typeof(EBook.Data.Models.PeriodSummary);
            // 
            // DailyChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 486);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.daySelectControl1);
            this.Name = "DailyChartForm";
            this.Text = "DailyChartForm";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DaySelectControl daySelectControl1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource bdsDay;
    }
}