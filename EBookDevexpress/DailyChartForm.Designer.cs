
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyChartForm));
            DevExpress.XtraCharts.SwiftPlotDiagram swiftPlotDiagram1 = new DevExpress.XtraCharts.SwiftPlotDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SwiftPlotSeriesView swiftPlotSeriesView1 = new DevExpress.XtraCharts.SwiftPlotSeriesView();
            this.groupCtrlDaily = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtSelectedDate = new DevExpress.XtraEditors.TextEdit();
            this.lblCtrlStartdate = new DevExpress.XtraEditors.LabelControl();
            this.timeSpanChartRangeControlClient1 = new DevExpress.XtraEditors.TimeSpanChartRangeControlClient();
            this.chartCntrlDaily = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrlDaily)).BeginInit();
            this.groupCtrlDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelectedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCntrlDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCtrlDaily
            // 
            this.groupCtrlDaily.Controls.Add(this.btnSearch);
            this.groupCtrlDaily.Controls.Add(this.txtSelectedDate);
            this.groupCtrlDaily.Controls.Add(this.lblCtrlStartdate);
            this.groupCtrlDaily.Location = new System.Drawing.Point(12, 12);
            this.groupCtrlDaily.Name = "groupCtrlDaily";
            this.groupCtrlDaily.Size = new System.Drawing.Size(776, 75);
            this.groupCtrlDaily.TabIndex = 0;
            this.groupCtrlDaily.Text = "일간 대여 통계";
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnSearch.Location = new System.Drawing.Point(281, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "조회";
            // 
            // txtSelectedDate
            // 
            this.txtSelectedDate.Location = new System.Drawing.Point(118, 38);
            this.txtSelectedDate.Name = "txtSelectedDate";
            this.txtSelectedDate.Size = new System.Drawing.Size(157, 24);
            this.txtSelectedDate.TabIndex = 1;
            // 
            // lblCtrlStartdate
            // 
            this.lblCtrlStartdate.Location = new System.Drawing.Point(14, 41);
            this.lblCtrlStartdate.Name = "lblCtrlStartdate";
            this.lblCtrlStartdate.Size = new System.Drawing.Size(88, 18);
            this.lblCtrlStartdate.TabIndex = 0;
            this.lblCtrlStartdate.Text = "조회 날짜 선택";
            
            // 
            // chartCntrlDaily
            // 
            swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartCntrlDaily.Diagram = swiftPlotDiagram1;
            this.chartCntrlDaily.Legend.Name = "Default Legend";
            this.chartCntrlDaily.Location = new System.Drawing.Point(13, 93);
            this.chartCntrlDaily.Name = "chartCntrlDaily";
            series1.Name = "일일 대여량";
            series1.View = swiftPlotSeriesView1;
            this.chartCntrlDaily.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartCntrlDaily.Size = new System.Drawing.Size(776, 345);
            this.chartCntrlDaily.TabIndex = 1;
            
            // 
            // DailyChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartCntrlDaily);
            this.Controls.Add(this.groupCtrlDaily);
            this.Name = "DailyChartForm";
            this.Text = "일간 대여";
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrlDaily)).EndInit();
            this.groupCtrlDaily.ResumeLayout(false);
            this.groupCtrlDaily.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelectedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCntrlDaily)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupCtrlDaily;
        private DevExpress.XtraEditors.LabelControl lblCtrlStartdate;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtSelectedDate;
        private DevExpress.XtraEditors.TimeSpanChartRangeControlClient timeSpanChartRangeControlClient1;
        private DevExpress.XtraCharts.ChartControl chartCntrlDaily;
    }
}