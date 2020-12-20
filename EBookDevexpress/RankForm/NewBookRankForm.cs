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
            //MessageBox.Show(s);
        }

        private void NewBookRankForm_Load(object sender, EventArgs e)
        {
            dbsNewbook.DataSource = Dao.Rent.BookCountRank(e.);
        }
    }
}
