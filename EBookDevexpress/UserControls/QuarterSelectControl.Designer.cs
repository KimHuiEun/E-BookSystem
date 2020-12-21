
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
            this.btnPeriod4 = new System.Windows.Forms.RadioButton();
            this.btnPeriod3 = new System.Windows.Forms.RadioButton();
            this.btnPeriod2 = new System.Windows.Forms.RadioButton();
            this.btnPeriod1 = new System.Windows.Forms.RadioButton();
            this.btnQuarterSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lblCtrlStartdate = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gcQuarter)).BeginInit();
            this.gcQuarter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcQuarter
            // 
            this.gcQuarter.Controls.Add(this.radioGroup1);
            this.gcQuarter.Controls.Add(this.btnPeriod4);
            this.gcQuarter.Controls.Add(this.btnPeriod3);
            this.gcQuarter.Controls.Add(this.btnPeriod2);
            this.gcQuarter.Controls.Add(this.btnPeriod1);
            this.gcQuarter.Controls.Add(this.btnQuarterSearch);
            this.gcQuarter.Controls.Add(this.lblCtrlStartdate);
            this.gcQuarter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcQuarter.Location = new System.Drawing.Point(0, 0);
            this.gcQuarter.Name = "gcQuarter";
            this.gcQuarter.Size = new System.Drawing.Size(800, 98);
            this.gcQuarter.TabIndex = 3;
            this.gcQuarter.Text = "분기 대여 통계";
            // 
            // btnPeriod4
            // 
            this.btnPeriod4.AutoSize = true;
            this.btnPeriod4.Location = new System.Drawing.Point(480, 40);
            this.btnPeriod4.Name = "btnPeriod4";
            this.btnPeriod4.Size = new System.Drawing.Size(131, 22);
            this.btnPeriod4.TabIndex = 14;
            this.btnPeriod4.TabStop = true;
            this.btnPeriod4.Text = "4분기(10~12월)";
            this.btnPeriod4.UseVisualStyleBackColor = true;
            // 
            // btnPeriod3
            // 
            this.btnPeriod3.AutoSize = true;
            this.btnPeriod3.Location = new System.Drawing.Point(359, 40);
            this.btnPeriod3.Name = "btnPeriod3";
            this.btnPeriod3.Size = new System.Drawing.Size(115, 22);
            this.btnPeriod3.TabIndex = 13;
            this.btnPeriod3.TabStop = true;
            this.btnPeriod3.Text = "3분기(7~9월)";
            this.btnPeriod3.UseVisualStyleBackColor = true;
            // 
            // btnPeriod2
            // 
            this.btnPeriod2.AutoSize = true;
            this.btnPeriod2.Location = new System.Drawing.Point(238, 39);
            this.btnPeriod2.Name = "btnPeriod2";
            this.btnPeriod2.Size = new System.Drawing.Size(115, 22);
            this.btnPeriod2.TabIndex = 12;
            this.btnPeriod2.TabStop = true;
            this.btnPeriod2.Text = "2분기(4~6월)";
            this.btnPeriod2.UseVisualStyleBackColor = true;
            // 
            // btnPeriod1
            // 
            this.btnPeriod1.AutoSize = true;
            this.btnPeriod1.Location = new System.Drawing.Point(112, 39);
            this.btnPeriod1.Name = "btnPeriod1";
            this.btnPeriod1.Size = new System.Drawing.Size(115, 22);
            this.btnPeriod1.TabIndex = 11;
            this.btnPeriod1.TabStop = true;
            this.btnPeriod1.Text = "1분기(1~3월)";
            this.btnPeriod1.UseVisualStyleBackColor = true;
            // 
            // btnQuarterSearch
            // 
            this.btnQuarterSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuarterSearch.ImageOptions.Image")));
            this.btnQuarterSearch.Location = new System.Drawing.Point(617, 36);
            this.btnQuarterSearch.Name = "btnQuarterSearch";
            this.btnQuarterSearch.Size = new System.Drawing.Size(71, 27);
            this.btnQuarterSearch.TabIndex = 10;
            this.btnQuarterSearch.Text = "조회";
            // 
            // lblCtrlStartdate
            // 
            this.lblCtrlStartdate.Location = new System.Drawing.Point(14, 41);
            this.lblCtrlStartdate.Name = "lblCtrlStartdate";
            this.lblCtrlStartdate.Size = new System.Drawing.Size(88, 18);
            this.lblCtrlStartdate.TabIndex = 0;
            this.lblCtrlStartdate.Text = "조회 기간 선택";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(112, 67);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Size = new System.Drawing.Size(100, 96);
            this.radioGroup1.TabIndex = 15;
            // 
            // QuarterSelectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcQuarter);
            this.Name = "QuarterSelectControl";
            this.Size = new System.Drawing.Size(800, 98);
            ((System.ComponentModel.ISupportInitialize)(this.gcQuarter)).EndInit();
            this.gcQuarter.ResumeLayout(false);
            this.gcQuarter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcQuarter;
        private DevExpress.XtraEditors.LabelControl lblCtrlStartdate;
        private System.Windows.Forms.RadioButton btnPeriod4;
        private System.Windows.Forms.RadioButton btnPeriod3;
        private System.Windows.Forms.RadioButton btnPeriod2;
        private System.Windows.Forms.RadioButton btnPeriod1;
        private DevExpress.XtraEditors.SimpleButton btnQuarterSearch;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
    }
}
