using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBook
{
    public partial class Mainform : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Mainform()
        {
            InitializeComponent();
        }


        private void ShowChildForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new DailyChartForm());
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new WeeklyChartForm());
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new QuaterlyChartForm());
        }
    }
}
