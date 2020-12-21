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

            bdsBestSeller.DataSource = Dao.Rent.BookCountRank();
        }
    }
}
