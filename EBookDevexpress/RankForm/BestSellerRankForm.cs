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

            genreSelectControl1.ItemClicked += GenreSelectControl1_ItemClicked;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;
        }

        private void GenreSelectControl1_ItemClicked(object sender, ItemClickedEventArgs e)
        {
            
            MessageBox.Show(e.Text);
        }

        private void BestSellerRankForm_Load(object sender, EventArgs e)
        {
            //TODO : 책 대여량 베스트 10 가져오는 소스 코드 필요함
            //dbsNewbook.DataSource = Dao.Rent.BookCountRank();
            //dbsBestSeller.DataSource = Dao.Rent.BookCountRank();
        }

        //EBookDevexpress.ItemClickedEventArgs += private ItemCheckedEventArgs_ItemClicked();

        private void genreSelectControl1_ItemClicked(object sender, ItemClickedEventArgs e)
        {
            MessageBox.Show(e.Text);
        }
    }
}
