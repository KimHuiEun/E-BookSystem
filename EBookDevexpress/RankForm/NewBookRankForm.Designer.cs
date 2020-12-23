
namespace EBookDevexpress
{
    partial class NewBookRankForm
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
            this.NewBookRankChart = new DevExpress.XtraCharts.ChartControl();
            this.bdsNewBook = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NewBookRankChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNewBook)).BeginInit();
            this.SuspendLayout();
            // 
            // NewBookRankChart
            // 
            this.NewBookRankChart.DataSource = this.bdsNewBook;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.Rotated = true;
            this.NewBookRankChart.Diagram = xyDiagram1;
            this.NewBookRankChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewBookRankChart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.NewBookRankChart.Legend.Name = "Default Legend";
            this.NewBookRankChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.NewBookRankChart.Location = new System.Drawing.Point(0, 0);
            this.NewBookRankChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewBookRankChart.Name = "NewBookRankChart";
            this.NewBookRankChart.PaletteName = "Apex";
            series1.ArgumentDataMember = "Title";
            series1.Name = "Series 1";
            this.NewBookRankChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.NewBookRankChart.SeriesTemplate.ArgumentDataMember = "Title";
            this.NewBookRankChart.SeriesTemplate.ValueDataMembersSerializable = "NewBookRank";
            this.NewBookRankChart.Size = new System.Drawing.Size(895, 535);
            this.NewBookRankChart.TabIndex = 3;
            // 
            // bdsNewBook
            // 
            this.bdsNewBook.DataSource = typeof(EBook.Data.Models.RankSummary);
            // 
            // NewBookRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 535);
            this.Controls.Add(this.NewBookRankChart);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewBookRankForm";
            this.Text = "신간 대여순위";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBookRankChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNewBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl NewBookRankChart;
        private System.Windows.Forms.BindingSource bdsNewBook;
    }
}