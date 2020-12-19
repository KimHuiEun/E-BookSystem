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
            //dbsNewbook.DataSource = Dao.Rent.BookCountRank(e);
        }
    }
}
