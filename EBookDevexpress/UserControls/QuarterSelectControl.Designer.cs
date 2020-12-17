
namespace EBookDevexpress
{
    partial class QuarterSelectControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuarterSelectControl));
            this.gcQuarter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.fourQuarter = new System.Windows.Forms.RadioButton();
            this.threeQuarter = new System.Windows.Forms.RadioButton();
            this.twoQuarter = new System.Windows.Forms.RadioButton();
            this.oneQuarter = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcQuarter)).BeginInit();
            this.gcQuarter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcQuarter
            // 
            this.gcQuarter.Controls.Add(this.btnSearch);
            this.gcQuarter.Controls.Add(this.fourQuarter);
            this.gcQuarter.Controls.Add(this.threeQuarter);
            this.gcQuarter.Controls.Add(this.twoQuarter);
            this.gcQuarter.Controls.Add(this.oneQuarter);
            this.gcQuarter.Location = new System.Drawing.Point(13, 13);
            this.gcQuarter.Name = "gcQuarter";
            this.gcQuarter.Size = new System.Drawing.Size(776, 75);
            this.gcQuarter.TabIndex = 2;
            this.gcQuarter.Text = "분기 대여 통계";
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.Location = new System.Drawing.Point(479, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "조회";
            // 
            // fourQuarter
            // 
            this.fourQuarter.AutoSize = true;
            this.fourQuarter.Location = new System.Drawing.Point(357, 41);
            this.fourQuarter.Name = "fourQuarter";
            this.fourQuarter.Size = new System.Drawing.Size(77, 22);
            this.fourQuarter.TabIndex = 3;
            this.fourQuarter.TabStop = true;
            this.fourQuarter.Text = "4/4분기";
            this.fourQuarter.UseVisualStyleBackColor = true;
            // 
            // threeQuarter
            // 
            this.threeQuarter.AutoSize = true;
            this.threeQuarter.Location = new System.Drawing.Point(240, 41);
            this.threeQuarter.Name = "threeQuarter";
            this.threeQuarter.Size = new System.Drawing.Size(77, 22);
            this.threeQuarter.TabIndex = 2;
            this.threeQuarter.TabStop = true;
            this.threeQuarter.Text = "3/4분기";
            this.threeQuarter.UseVisualStyleBackColor = true;
            // 
            // twoQuarter
            // 
            this.twoQuarter.AutoSize = true;
            this.twoQuarter.Location = new System.Drawing.Point(123, 41);
            this.twoQuarter.Name = "twoQuarter";
            this.twoQuarter.Size = new System.Drawing.Size(77, 22);
            this.twoQuarter.TabIndex = 1;
            this.twoQuarter.TabStop = true;
            this.twoQuarter.Text = "2/4분기";
            this.twoQuarter.UseVisualStyleBackColor = true;
            // 
            // oneQuarter
            // 
            this.oneQuarter.AutoSize = true;
            this.oneQuarter.Location = new System.Drawing.Point(6, 41);
            this.oneQuarter.Name = "oneQuarter";
            this.oneQuarter.Size = new System.Drawing.Size(77, 22);
            this.oneQuarter.TabIndex = 0;
            this.oneQuarter.TabStop = true;
            this.oneQuarter.Text = "1/4분기";
            this.oneQuarter.UseVisualStyleBackColor = true;
            // 
            // QuarterSelectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcQuarter);
            this.Name = "QuarterSelectControl";
            this.Size = new System.Drawing.Size(805, 103);
            ((System.ComponentModel.ISupportInitialize)(this.gcQuarter)).EndInit();
            this.gcQuarter.ResumeLayout(false);
            this.gcQuarter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcQuarter;
        private System.Windows.Forms.RadioButton fourQuarter;
        private System.Windows.Forms.RadioButton threeQuarter;
        private System.Windows.Forms.RadioButton twoQuarter;
        private System.Windows.Forms.RadioButton oneQuarter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
    }
}
