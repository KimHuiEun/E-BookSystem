
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
            this.groupCtrlQuarterly = new DevExpress.XtraEditors.GroupControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSearchGuide = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lblCtrlStartdate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrlQuarterly)).BeginInit();
            this.groupCtrlQuarterly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCtrlQuarterly
            // 
            this.groupCtrlQuarterly.Controls.Add(this.comboBoxEdit1);
            this.groupCtrlQuarterly.Controls.Add(this.lblSearchGuide);
            this.groupCtrlQuarterly.Controls.Add(this.btnSearch);
            this.groupCtrlQuarterly.Controls.Add(this.lblCtrlStartdate);
            this.groupCtrlQuarterly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupCtrlQuarterly.Location = new System.Drawing.Point(0, 0);
            this.groupCtrlQuarterly.Name = "groupCtrlQuarterly";
            this.groupCtrlQuarterly.Size = new System.Drawing.Size(800, 98);
            this.groupCtrlQuarterly.TabIndex = 3;
            this.groupCtrlQuarterly.Text = "분기 대여 통계";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(118, 38);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "1/4분기",
            "2/4분기",
            "3/4분기",
            "4/4분기"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(125, 24);
            this.comboBoxEdit1.TabIndex = 4;
            // 
            // lblSearchGuide
            // 
            this.lblSearchGuide.Location = new System.Drawing.Point(118, 68);
            this.lblSearchGuide.Name = "lblSearchGuide";
            this.lblSearchGuide.Size = new System.Drawing.Size(373, 18);
            this.lblSearchGuide.TabIndex = 3;
            this.lblSearchGuide.Text = "*선택일 시작 기준으로 3개월 간의 통계를 조회할 수 있습니다.";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(249, 36);
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
            // QuarterSelectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupCtrlQuarterly);
            this.Name = "QuarterSelectControl";
            this.Size = new System.Drawing.Size(800, 98);
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrlQuarterly)).EndInit();
            this.groupCtrlQuarterly.ResumeLayout(false);
            this.groupCtrlQuarterly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupCtrlQuarterly;
        private DevExpress.XtraEditors.LabelControl lblSearchGuide;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl lblCtrlStartdate;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
    }
}
