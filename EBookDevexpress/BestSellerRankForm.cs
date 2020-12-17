using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraCharts;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EBookDevexpress
{
    public partial class BestSellerRankForm : Form
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
/*
            //NewBookRankChart.DataSource = BookModel.RentCount.GetModels();
            var book = BookModel.RentCount.GetModels();
            BestSellerRankChart.Series[0].View.Colorizer = CreateColorizer(book);
            BestSellerRankChart.DataSource = book;

            CreateColorizerBase CreateColorizer(List<BookModel> models)
            {
                KeyColorizer colorizer = new KeyColorizer()
                {
                    PaletteName = "Apex"
                };

                var names = book.Select(x => x.name).ToList();
                colorizer.Keys.AddRange(names);

                return colorizer;
            }*/
        }


    }
}
