
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
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            this.BestSellerRankChart = new DevExpress.XtraCharts.ChartControl();
            this.dbsBestSeller = new System.Windows.Forms.BindingSource(this.components);
            this.genreSelectControl1 = new EBookDevexpress.GenreSelectControl();
            ((System.ComponentModel.ISupportInitialize)(this.BestSellerRankChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsBestSeller)).BeginInit();
            this.SuspendLayout();
            // 
            // BestSellerRankChart
            // 
            this.BestSellerRankChart.DataSource = this.dbsBestSeller;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.Rotated = true;
            this.BestSellerRankChart.Diagram = xyDiagram2;
            this.BestSellerRankChart.Dock = System.Windows.Forms.DockStyle.Left;
            this.BestSellerRankChart.Legend.Name = "Default Legend";
            this.BestSellerRankChart.Location = new System.Drawing.Point(0, 0);
            this.BestSellerRankChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BestSellerRankChart.Name = "BestSellerRankChart";
            this.BestSellerRankChart.SeriesDataMember = "Title";
            series2.ArgumentDataMember = "Title";
            series2.Name = "Series 1";
            series2.ValueDataMembersSerializable = "BookCount";
            this.BestSellerRankChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.BestSellerRankChart.SeriesTemplate.ArgumentDataMember = "BookCount";
            this.BestSellerRankChart.SeriesTemplate.SeriesDataMember = "Title";
            this.BestSellerRankChart.SeriesTemplate.ValueDataMembersSerializable = "Rank";
            this.BestSellerRankChart.SeriesTemplate.Visible = false;
            this.BestSellerRankChart.Size = new System.Drawing.Size(763, 426);
            this.BestSellerRankChart.TabIndex = 0;
            // 
            // genreSelectControl1
            // 
            this.genreSelectControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.genreSelectControl1.Location = new System.Drawing.Point(765, 0);
            this.genreSelectControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genreSelectControl1.Name = "genreSelectControl1";
            this.genreSelectControl1.Size = new System.Drawing.Size(120, 426);
            this.genreSelectControl1.TabIndex = 2;
            this.genreSelectControl1.ItemClicked += new System.EventHandler<EBookDevexpress.ItemClickedEventArgs>(this.genreSelectControl1_ItemClicked);
            // 
            // BestSellerRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 426);
            this.Controls.Add(this.genreSelectControl1);
            this.Controls.Add(this.BestSellerRankChart);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BestSellerRankForm";
            this.Text = "베스트셀러 대여순위";
            this.Load += new System.EventHandler(this.BestSellerRankForm_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestSellerRankChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsBestSeller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl BestSellerRankChart;
        private System.Windows.Forms.BindingSource dbsBestSeller;
        private GenreSelectControl genreSelectControl1;
    }
}