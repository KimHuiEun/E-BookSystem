
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
            this.dbsNewbook = new System.Windows.Forms.BindingSource(this.components);
            this.genreSelectControl1 = new EBookDevexpress.GenreSelectControl();
            ((System.ComponentModel.ISupportInitialize)(this.NewBookRankChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsNewbook)).BeginInit();
            this.SuspendLayout();
            // 
            // NewBookRankChart
            // 
            this.NewBookRankChart.DataSource = this.dbsNewbook;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.Rotated = true;
            this.NewBookRankChart.Diagram = xyDiagram1;
            this.NewBookRankChart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.NewBookRankChart.Legend.Name = "Default Legend";
            this.NewBookRankChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.NewBookRankChart.Location = new System.Drawing.Point(12, 12);
            this.NewBookRankChart.Name = "NewBookRankChart";
            this.NewBookRankChart.PaletteName = "Apex";
            series1.ArgumentDataMember = "Title";
            series1.Name = "Series 1";
            this.NewBookRankChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.NewBookRankChart.SeriesTemplate.ArgumentDataMember = "RentCount";
            this.NewBookRankChart.Size = new System.Drawing.Size(620, 395);
            this.NewBookRankChart.TabIndex = 3;
            // 
            // genreSelectControl1
            // 
            this.genreSelectControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.genreSelectControl1.Location = new System.Drawing.Point(649, 92);
            this.genreSelectControl1.Name = "genreSelectControl1";
            this.genreSelectControl1.Size = new System.Drawing.Size(220, 315);
            this.genreSelectControl1.TabIndex = 4;
            this.genreSelectControl1.Load += new System.EventHandler(this.genreSelectControl1_Load);
            // 
            // NewBookRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 422);
            this.Controls.Add(this.genreSelectControl1);
            this.Controls.Add(this.NewBookRankChart);
            this.Name = "NewBookRankForm";
            this.Text = "신간 대여순위";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBookRankChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsNewbook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl NewBookRankChart;
        private System.Windows.Forms.BindingSource dbsNewbook;
        private GenreSelectControl genreSelectControl1;
    }
}