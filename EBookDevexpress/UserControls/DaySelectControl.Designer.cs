
namespace EBookDevexpress
{
    partial class DaySelectControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaySelectControl));
            this.gcDay = new DevExpress.XtraEditors.GroupControl();
            this.day = new DevExpress.XtraEditors.DateEdit();
            this.btnDaySearch = new DevExpress.XtraEditors.SimpleButton();
            this.lblCtrlStartdate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcDay)).BeginInit();
            this.gcDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDay
            // 
            this.gcDay.Controls.Add(this.day);
            this.gcDay.Controls.Add(this.btnDaySearch);
            this.gcDay.Controls.Add(this.lblCtrlStartdate);
            this.gcDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDay.Location = new System.Drawing.Point(0, 0);
            this.gcDay.Name = "gcDay";
            this.gcDay.Size = new System.Drawing.Size(802, 98);
            this.gcDay.TabIndex = 6;
            this.gcDay.Text = "일간 대여 통계";
            // 
            // day
            // 
            this.day.EditValue = null;
            this.day.Location = new System.Drawing.Point(109, 36);
            this.day.Name = "day";
            this.day.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.day.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.day.Size = new System.Drawing.Size(166, 24);
            this.day.TabIndex = 3;
            // 
            // btnDaySearch
            // 
            this.btnDaySearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnDaySearch.Location = new System.Drawing.Point(281, 35);
            this.btnDaySearch.Name = "btnDaySearch";
            this.btnDaySearch.Size = new System.Drawing.Size(71, 27);
            this.btnDaySearch.TabIndex = 2;
            this.btnDaySearch.Text = "조회";
            this.btnDaySearch.Click += new System.EventHandler(this.btnDaySearch_Click);
            // 
            // lblCtrlStartdate
            // 
            this.lblCtrlStartdate.Location = new System.Drawing.Point(14, 41);
            this.lblCtrlStartdate.Name = "lblCtrlStartdate";
            this.lblCtrlStartdate.Size = new System.Drawing.Size(88, 18);
            this.lblCtrlStartdate.TabIndex = 0;
            this.lblCtrlStartdate.Text = "조회 기간 선택";
            // 
            // DaySelectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcDay);
            this.Name = "DaySelectControl";
            this.Size = new System.Drawing.Size(802, 98);
            ((System.ComponentModel.ISupportInitialize)(this.gcDay)).EndInit();
            this.gcDay.ResumeLayout(false);
            this.gcDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcDay;
        private DevExpress.XtraEditors.SimpleButton btnDaySearch;
        private DevExpress.XtraEditors.LabelControl lblCtrlStartdate;
        private DevExpress.XtraEditors.DateEdit day;
    }
}
