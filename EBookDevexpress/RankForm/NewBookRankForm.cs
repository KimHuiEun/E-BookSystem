using EBook.Data;
using EBook.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBookDevexpress
{
    public partial class NewBookRankForm : Form
    {
        public NewBookRankForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;
        }

        private void genreSelectControl1_Load(object sender, EventArgs e)
        {
            //TODO : 모자른 소스 코드
            //1. 클릭시에 따른 장르 가져오기
            //2. 클릭을 해제시 처음 데이터 코드로 변경하기
            //3. 책의 데여량 가져오는 쿼리문이 완성 됬던가...?
        }

        private void checkedListBoxControl1_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            int i;
            string s;
            s = "Checked items:\n";
            for (i = 0; i <= (checkedListBoxControl1.Items.Count - 1); i++)
            {
                if (checkedListBoxControl1.GetItemChecked(i))
                {
                    s = s + "Item " + (i + 1).ToString() + " = " + checkedListBoxControl1.Items[i].ToString() + "\n";
                }
            }
            //버튼을 클릭시 메세지 박스 출력까지는 성공함.
            //눌러진 버튼을 보내서 데이터베이스의 장르별 데이터에 접근하는 법 필요함.
            //MessageBox.Show(s);
        }

        private void NewBookRankForm_Load(object sender, EventArgs e)
        {
            //TODO : 책 대여량 베스트 10 가져오는 소스 코드 필요함
            //dbsNewbook.DataSource = Dao.Rent.BookCountRank(e.);
        }
    }
}
