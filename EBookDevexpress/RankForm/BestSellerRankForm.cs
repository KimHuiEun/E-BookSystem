using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using EBook.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EBookDevexpress
{
    public partial class BestSellerRankForm : XtraForm
    {
        public BestSellerRankForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;
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
            MessageBox.Show(s);
        }
    }
}
