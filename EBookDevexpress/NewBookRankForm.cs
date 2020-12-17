using EBook.Data;
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

            /*//NewBookRankChart.DataSource = BookModel.RentCount.GetModels();
            var book = BookModel.RentCount.GetModels();
            NewBookRankChart.Series[0].View.Colorizer = CreateColorizer(book);
            NewBookRankChart.DataSource = book;

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
