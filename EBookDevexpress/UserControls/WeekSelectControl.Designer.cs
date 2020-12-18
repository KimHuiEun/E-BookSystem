
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
            this.groupCtrlWeekly = new DevExpress.XtraEditors.GroupControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.lblSearchGuide = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lblCtrlStartdate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrlWeekly)).BeginInit();
            this.groupCtrlWeekly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCtrlWeekly
            // 
            this.groupCtrlWeekly.Controls.Add(this.dateEdit1);
            this.groupCtrlWeekly.Controls.Add(this.lblSearchGuide);
            this.groupCtrlWeekly.Controls.Add(this.btnSearch);
            this.groupCtrlWeekly.Controls.Add(this.lblCtrlStartdate);
            this.groupCtrlWeekly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupCtrlWeekly.Location = new System.Drawing.Point(0, 0);
            this.groupCtrlWeekly.Name = "groupCtrlWeekly";
            this.groupCtrlWeekly.Size = new System.Drawing.Size(805, 99);
            this.groupCtrlWeekly.TabIndex = 5;
            this.groupCtrlWeekly.Text = "주간 대여 통계";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(109, 37);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(166, 24);
            this.dateEdit1.TabIndex = 4;
            // 
            // lblSearchGuide
            // 
            this.lblSearchGuide.Location = new System.Drawing.Point(118, 68);
            this.lblSearchGuide.Name = "lblSearchGuide";
            this.lblSearchGuide.Size = new System.Drawing.Size(378, 18);
            this.lblSearchGuide.TabIndex = 3;
            this.lblSearchGuide.Text = "*선택일 시작 기준으로 일주일 간의 통계를 조회할 수 있습니다.";
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
            // lblCtrlStartdate
            // 
            this.lblCtrlStartdate.Location = new System.Drawing.Point(14, 41);
            this.lblCtrlStartdate.Name = "lblCtrlStartdate";
            this.lblCtrlStartdate.Size = new System.Drawing.Size(88, 18);
            this.lblCtrlStartdate.TabIndex = 0;
            this.lblCtrlStartdate.Text = "조회 기간 선택";
            // 
            // WeekSelectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupCtrlWeekly);
            this.Name = "WeekSelectControl";
            this.Size = new System.Drawing.Size(805, 99);
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrlWeekly)).EndInit();
            this.groupCtrlWeekly.ResumeLayout(false);
            this.groupCtrlWeekly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupCtrlWeekly;
        private DevExpress.XtraEditors.LabelControl lblSearchGuide;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl lblCtrlStartdate;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
    }
}
