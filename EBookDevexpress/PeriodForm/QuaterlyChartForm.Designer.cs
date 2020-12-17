
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuaterlyChartForm));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.FullStackedLineSeriesView fullStackedLineSeriesView1 = new DevExpress.XtraCharts.FullStackedLineSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            this.groupCtrlQuarterly = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtSelectedDate = new DevExpress.XtraEditors.TextEdit();
            this.lblCtrlStartdate = new DevExpress.XtraEditors.LabelControl();
            this.lblSearchGuide = new DevExpress.XtraEditors.LabelControl();
            this.checkedListBox = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.chartCntrlQuarterly = new DevExpress.XtraCharts.ChartControl();
            this.lblSelectList = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrlQuarterly)).BeginInit();
            this.groupCtrlQuarterly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelectedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBox)).BeginInit();
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
            this.SuspendLayout();
            // 
            // groupCtrlQuarterly
            // 
            this.groupCtrlQuarterly.Controls.Add(this.lblSearchGuide);
            this.groupCtrlQuarterly.Controls.Add(this.btnSearch);
            this.groupCtrlQuarterly.Controls.Add(this.txtSelectedDate);
            this.groupCtrlQuarterly.Controls.Add(this.lblCtrlStartdate);
            this.groupCtrlQuarterly.Location = new System.Drawing.Point(12, 12);
            this.groupCtrlQuarterly.Name = "groupCtrlQuarterly";
            this.groupCtrlQuarterly.Size = new System.Drawing.Size(776, 96);
            this.groupCtrlQuarterly.TabIndex = 2;
            this.groupCtrlQuarterly.Text = "분기 대여 통계";
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
            this.lblCtrlStartdate.Text = "조회 기간 선택";
            // 
            // lblSearchGuide
            // 
            this.lblSearchGuide.Location = new System.Drawing.Point(118, 68);
            this.lblSearchGuide.Name = "lblSearchGuide";
            this.lblSearchGuide.Size = new System.Drawing.Size(373, 18);
            this.lblSearchGuide.TabIndex = 3;
            this.lblSearchGuide.Text = "*선택일 시작 기준으로 3개월 간의 통계를 조회할 수 있습니다.";
            // 
            // checkedListBox
            // 
            this.checkedListBox.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "경제"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "교양"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "문학"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "사회과학")});
            this.checkedListBox.Location = new System.Drawing.Point(586, 168);
            this.checkedListBox.MultiColumn = true;
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkedListBox.Size = new System.Drawing.Size(202, 270);
            this.checkedListBox.TabIndex = 5;
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
            // lblSelectList
            // 
            this.lblSelectList.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectList.Appearance.Options.UseFont = true;
            this.lblSelectList.Location = new System.Drawing.Point(586, 141);
            this.lblSelectList.Name = "lblSelectList";
            this.lblSelectList.Size = new System.Drawing.Size(53, 21);
            this.lblSelectList.TabIndex = 6;
            this.lblSelectList.Text = "항목 선택";
            // 
            // QuaterlyChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSelectList);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.chartCntrlQuarterly);
            this.Controls.Add(this.groupCtrlQuarterly);
            this.Name = "QuaterlyChartForm";
            this.Text = "분기 대여";
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrlQuarterly)).EndInit();
            this.groupCtrlQuarterly.ResumeLayout(false);
            this.groupCtrlQuarterly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelectedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBox)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupCtrlQuarterly;
        private DevExpress.XtraEditors.LabelControl lblSearchGuide;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtSelectedDate;
        private DevExpress.XtraEditors.LabelControl lblCtrlStartdate;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBox;
        private DevExpress.XtraCharts.ChartControl chartCntrlQuarterly;
        private DevExpress.XtraEditors.LabelControl lblSelectList;
    }
}