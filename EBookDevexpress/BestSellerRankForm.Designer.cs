
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
            this.rentModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BestSellerRankChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BestSellerRankChart
            // 
            this.BestSellerRankChart.DataSource = this.rentModelBindingSource;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.Rotated = true;
            this.BestSellerRankChart.Diagram = xyDiagram2;
            this.BestSellerRankChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BestSellerRankChart.Legend.Name = "Default Legend";
            this.BestSellerRankChart.Location = new System.Drawing.Point(0, 0);
            this.BestSellerRankChart.Name = "BestSellerRankChart";
            series2.Name = "Series 1";
            this.BestSellerRankChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.BestSellerRankChart.Size = new System.Drawing.Size(800, 450);
            this.BestSellerRankChart.TabIndex = 0;
            // 
            // rentModelBindingSource
            // 
            //this.rentModelBindingSource.DataSource = typeof(EBook.Data.RentModel);
            // 
            // BestSellerRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BestSellerRankChart);
            this.Name = "BestSellerRankForm";
            this.Text = "베스트셀러 대여순위";
            //this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestSellerRankChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl BestSellerRankChart;
        private System.Windows.Forms.BindingSource rentModelBindingSource;
    }
}