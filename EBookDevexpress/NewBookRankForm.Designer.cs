
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
            this.bookModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NewBookRankChart = new DevExpress.XtraCharts.ChartControl();
            this.gcGenre1 = new EBookDevexpress.gcGenre();
            ((System.ComponentModel.ISupportInitialize)(this.bookModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBookRankChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewBookRankChart
            // 
            this.NewBookRankChart.DataSource = this.bookModelBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.Rotated = true;
            this.NewBookRankChart.Diagram = xyDiagram1;
            this.NewBookRankChart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.NewBookRankChart.Legend.Name = "Default Legend";
            this.NewBookRankChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.NewBookRankChart.Location = new System.Drawing.Point(12, 12);
            this.NewBookRankChart.Name = "NewBookRankChart";
            this.NewBookRankChart.PaletteName = "Apex";
            series1.ArgumentDataMember = "Title";
            series1.DataSource = this.bookModelBindingSource;
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "RentCount";
            this.NewBookRankChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.NewBookRankChart.SeriesTemplate.ArgumentDataMember = "RentCount";
            this.NewBookRankChart.Size = new System.Drawing.Size(620, 395);
            this.NewBookRankChart.TabIndex = 3;
            // 
            // gcGenre1
            // 
            this.gcGenre1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gcGenre1.AutoSize = true;
            this.gcGenre1.Location = new System.Drawing.Point(631, 85);
            this.gcGenre1.Name = "gcGenre1";
            this.gcGenre1.Size = new System.Drawing.Size(157, 322);
            this.gcGenre1.TabIndex = 5;
            // 
            // NewBookRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gcGenre1);
            this.Controls.Add(this.NewBookRankChart);
            this.Name = "NewBookRankForm";
            this.Text = "신간 대여순위";
            ((System.ComponentModel.ISupportInitialize)(this.bookModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBookRankChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bookModelBindingSource;
        private DevExpress.XtraCharts.ChartControl NewBookRankChart;
        private gcGenre gcGenre1;
    }
}