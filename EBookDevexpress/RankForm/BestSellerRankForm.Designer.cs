
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
            this.BestSellerRankChart = new DevExpress.XtraCharts.ChartControl();
            this.sbsBestSellerRank = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BestSellerRankChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbsBestSellerRank)).BeginInit();
            this.SuspendLayout();
            // 
            // BestSellerRankChart
            // 
            this.BestSellerRankChart.DataSource = this.sbsBestSellerRank;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.Rotated = true;
            this.BestSellerRankChart.Diagram = xyDiagram1;
            this.BestSellerRankChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BestSellerRankChart.Legend.Name = "Default Legend";
            this.BestSellerRankChart.Location = new System.Drawing.Point(0, 0);
            this.BestSellerRankChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BestSellerRankChart.Name = "BestSellerRankChart";
            this.BestSellerRankChart.SeriesDataMember = "Title";
            series1.ArgumentDataMember = "Title";
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "BookCount";
            this.BestSellerRankChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.BestSellerRankChart.SeriesTemplate.ArgumentDataMember = "BookCount";
            this.BestSellerRankChart.SeriesTemplate.SeriesDataMember = "Title";
            this.BestSellerRankChart.SeriesTemplate.ValueDataMembersSerializable = "Rank";
            this.BestSellerRankChart.SeriesTemplate.Visible = false;
            this.BestSellerRankChart.Size = new System.Drawing.Size(777, 542);
            this.BestSellerRankChart.TabIndex = 0;
            // 
            // sbsBestSellerRank
            // 
            this.sbsBestSellerRank.DataSource = typeof(EBook.Data.Summary);
            // 
            // BestSellerRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 542);
            this.Controls.Add(this.BestSellerRankChart);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BestSellerRankForm";
            this.Text = "베스트셀러 대여순위";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestSellerRankChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbsBestSellerRank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl BestSellerRankChart;
        private System.Windows.Forms.BindingSource sbsBestSellerRank;
    }
}