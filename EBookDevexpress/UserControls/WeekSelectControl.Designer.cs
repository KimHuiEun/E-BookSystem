
namespace EBookDevexpress
{
    partial class WeekSelectControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeekSelectControl));
            this.gcWeek = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtSelectedDate = new DevExpress.XtraEditors.TextEdit();
            this.lblCtrlStartdate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcWeek)).BeginInit();
            this.gcWeek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelectedDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcWeek
            // 
            this.gcWeek.Controls.Add(this.btnSearch);
            this.gcWeek.Controls.Add(this.txtSelectedDate);
            this.gcWeek.Controls.Add(this.lblCtrlStartdate);
            this.gcWeek.Location = new System.Drawing.Point(12, 12);
            this.gcWeek.Name = "gcWeek";
            this.gcWeek.Size = new System.Drawing.Size(776, 75);
            this.gcWeek.TabIndex = 2;
            this.gcWeek.Text = "주간 대여 통계";
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.Location = new System.Drawing.Point(281, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "조회";
            // 
            // txtSelectedDate
            // 
            this.txtSelectedDate.Location = new System.Drawing.Point(118, 38);
            this.txtSelectedDate.Name = "txtSelectedDate";
            this.txtSelectedDate.Size = new System.Drawing.Size(157, 24);
            this.txtSelectedDate.TabIndex = 1;
            // 
            // lblCtrlStartdate
            // 
            this.lblCtrlStartdate.Location = new System.Drawing.Point(14, 41);
            this.lblCtrlStartdate.Name = "lblCtrlStartdate";
            this.lblCtrlStartdate.Size = new System.Drawing.Size(88, 18);
            this.lblCtrlStartdate.TabIndex = 0;
            this.lblCtrlStartdate.Text = "조회 날짜 선택";
            // 
            // WeekSelectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcWeek);
            this.Name = "WeekSelectControl";
            this.Size = new System.Drawing.Size(806, 105);
            ((System.ComponentModel.ISupportInitialize)(this.gcWeek)).EndInit();
            this.gcWeek.ResumeLayout(false);
            this.gcWeek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelectedDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcWeek;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtSelectedDate;
        private DevExpress.XtraEditors.LabelControl lblCtrlStartdate;
    }
}
