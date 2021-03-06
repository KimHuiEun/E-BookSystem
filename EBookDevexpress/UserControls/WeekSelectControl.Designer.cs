﻿
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
            this.week = new DevExpress.XtraEditors.DateEdit();
            this.lblSearchGuide = new DevExpress.XtraEditors.LabelControl();
            this.btnWeekSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lblCtrlStartdate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcWeek)).BeginInit();
            this.gcWeek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.week.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.week.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcWeek
            // 
            this.gcWeek.Controls.Add(this.week);
            this.gcWeek.Controls.Add(this.lblSearchGuide);
            this.gcWeek.Controls.Add(this.btnWeekSearch);
            this.gcWeek.Controls.Add(this.lblCtrlStartdate);
            this.gcWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcWeek.Location = new System.Drawing.Point(0, 0);
            this.gcWeek.Name = "gcWeek";
            this.gcWeek.Size = new System.Drawing.Size(805, 99);
            this.gcWeek.TabIndex = 5;
            this.gcWeek.Text = "주간 대여 통계";
            // 
            // week
            // 
            this.week.EditValue = null;
            this.week.Location = new System.Drawing.Point(109, 37);
            this.week.Name = "week";
            this.week.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.week.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.week.Size = new System.Drawing.Size(166, 24);
            this.week.TabIndex = 4;
            // 
            // lblSearchGuide
            // 
            this.lblSearchGuide.Location = new System.Drawing.Point(118, 68);
            this.lblSearchGuide.Name = "lblSearchGuide";
            this.lblSearchGuide.Size = new System.Drawing.Size(378, 18);
            this.lblSearchGuide.TabIndex = 3;
            this.lblSearchGuide.Text = "*선택일 시작 기준으로 일주일 간의 통계를 조회할 수 있습니다.";
            // 
            // btnWeekSearch
            // 
            this.btnWeekSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnWeekSearch.ImageOptions.Image")));
            this.btnWeekSearch.Location = new System.Drawing.Point(281, 35);
            this.btnWeekSearch.Name = "btnWeekSearch";
            this.btnWeekSearch.Size = new System.Drawing.Size(71, 27);
            this.btnWeekSearch.TabIndex = 2;
            this.btnWeekSearch.Text = "조회";
            this.btnWeekSearch.Click += new System.EventHandler(this.btnWeekSearch_Click);
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
            this.Controls.Add(this.gcWeek);
            this.Name = "WeekSelectControl";
            this.Size = new System.Drawing.Size(805, 99);
            ((System.ComponentModel.ISupportInitialize)(this.gcWeek)).EndInit();
            this.gcWeek.ResumeLayout(false);
            this.gcWeek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.week.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.week.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcWeek;
        private DevExpress.XtraEditors.LabelControl lblSearchGuide;
        private DevExpress.XtraEditors.SimpleButton btnWeekSearch;
        private DevExpress.XtraEditors.LabelControl lblCtrlStartdate;
        private DevExpress.XtraEditors.DateEdit week;
    }
}
