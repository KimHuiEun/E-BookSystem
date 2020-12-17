
namespace EBookDevexpress
{
    partial class BestSellerRankForm
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
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("C언어 코딩도장", new object[] {
            ((object)(20D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("이것이 C#이다", new object[] {
            ((object)(50D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("닷넷 정복", new object[] {
            ((object)(16D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("이것이 MSSQL이다", new object[] {
            ((object)(56D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint("TCP/IP가 보이는 그림책", new object[] {
            ((object)(83D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint("ASP.NETMVC5", new object[] {
            ((object)(29D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint("이것이 김프로다", new object[] {
            ((object)(27D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint("여덟", new object[] {
            ((object)(93D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint9 = new DevExpress.XtraCharts.SeriesPoint("아홉", new object[] {
            ((object)(46D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint10 = new DevExpress.XtraCharts.SeriesPoint("열", new object[] {
            ((object)(37D))});
            this.BestSellerRankChart = new DevExpress.XtraCharts.ChartControl();
            this.rentModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BestSellerRankChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BestSellerRankChart
            // 
            this.BestSellerRankChart.DataSource = this.rentModelBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.Rotated = true;
            this.BestSellerRankChart.Diagram = xyDiagram1;
            this.BestSellerRankChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BestSellerRankChart.Legend.Name = "Default Legend";
            this.BestSellerRankChart.Location = new System.Drawing.Point(0, 0);
            this.BestSellerRankChart.Name = "BestSellerRankChart";
            series1.Name = "Series 1";
            seriesPoint1.ColorSerializable = "#FDEADA";
            seriesPoint2.ColorSerializable = "#DBEEE3";
            seriesPoint3.ColorSerializable = "#E5E0EC";
            seriesPoint4.ColorSerializable = "#EBF1DD";
            seriesPoint5.ColorSerializable = "#F2DCDB";
            seriesPoint6.ColorSerializable = "#DBE5F1";
            seriesPoint7.ColorSerializable = "#C6D9F0";
            seriesPoint8.ColorSerializable = "#DDD9C3";
            seriesPoint9.ColorSerializable = "#FBD5B5";
            seriesPoint10.ColorSerializable = "#B7DDE8";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5,
            seriesPoint6,
            seriesPoint7,
            seriesPoint8,
            seriesPoint9,
            seriesPoint10});
            this.BestSellerRankChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.BestSellerRankChart.SeriesSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            this.BestSellerRankChart.Size = new System.Drawing.Size(800, 450);
            this.BestSellerRankChart.TabIndex = 0;
            // 
            // BestSellerRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BestSellerRankChart);
            this.Name = "BestSellerRankForm";
            this.Text = "베스트셀러 대여순위";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestSellerRankChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl BestSellerRankChart;
        private System.Windows.Forms.BindingSource rentModelBindingSource;
    }
}