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
    public partial class NaverBooks : Form
    {
        public NaverBooks()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            webBrowser1.Navigate("https://book.naver.com/monitor/cc?nsc=book.home&text=&url=https%3A%2F%2Fbook.naver.com%2Fbookdb%2Fbook_detail.nhn%3Fbid%3D17590999&area=rhb.newbookcat&cid=&rank=&pageX=560&pageY=374&width=939&timestamp=1608191889961");
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
