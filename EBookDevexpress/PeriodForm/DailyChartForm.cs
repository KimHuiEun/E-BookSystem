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
    public partial class DailyChartForm : Form
    {
        public DailyChartForm()
        {
            InitializeComponent();
        }


        private void daySelectControl1_ButtonDaySearch(object sender, DaySelectControl.ButtonDaySearchEventArgs e)
        {
            bdsList.DataSource = Dao.Rent.DaySearch(e.Day);
                //e.Day = new 
            
        }
    }
}
