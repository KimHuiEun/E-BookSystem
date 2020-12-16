
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
            this.lblChartGuide = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lblChartGuide
            // 
            this.lblChartGuide.Location = new System.Drawing.Point(12, 12);
            this.lblChartGuide.Name = "lblChartGuide";
            this.lblChartGuide.Size = new System.Drawing.Size(407, 18);
            this.lblChartGuide.TabIndex = 5;
            this.lblChartGuide.Text = "*베스트셀러의 기준은 최근 3개월간의 장르 종합 대여량 집계입니다.";
            // 
            // BestSellerRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChartGuide);
            this.Name = "BestSellerRankForm";
            this.Text = "베스트셀러 대여순위";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblChartGuide;
    }
}