
namespace EBookDevexpress
{
    partial class GenreSelectControl
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
            this.gcGenre = new DevExpress.XtraEditors.GroupControl();
            this.clGenre = new DevExpress.XtraEditors.CheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcGenre)).BeginInit();
            this.gcGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // gcGenre
            // 
            this.gcGenre.AutoSize = true;
            this.gcGenre.Controls.Add(this.clGenre);
            this.gcGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGenre.Location = new System.Drawing.Point(0, 0);
            this.gcGenre.Name = "gcGenre";
            this.gcGenre.Size = new System.Drawing.Size(220, 315);
            this.gcGenre.TabIndex = 9;
            this.gcGenre.Text = "항목 선택";
            // 
            // clGenre
            // 
            this.clGenre.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "경제"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "교양"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "문학"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "사회과학")});
            this.clGenre.Location = new System.Drawing.Point(10, 31);
            this.clGenre.MultiColumn = true;
            this.clGenre.Name = "clGenre";
            this.clGenre.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clGenre.Size = new System.Drawing.Size(197, 270);
            this.clGenre.TabIndex = 9;
            // 
            // GenreSelectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcGenre);
            this.Name = "GenreSelectControl";
            this.Size = new System.Drawing.Size(220, 315);
            ((System.ComponentModel.ISupportInitialize)(this.gcGenre)).EndInit();
            this.gcGenre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcGenre;
        private DevExpress.XtraEditors.CheckedListBoxControl clGenre;
    }
}
