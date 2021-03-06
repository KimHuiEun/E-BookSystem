﻿using DevExpress.XtraCharts;
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
    public partial class WeeklyChartForm : Form
    {
        public WeeklyChartForm()
        {
            InitializeComponent();
        }

        private void weekSelectControl1_ButtonWeekSearch(object sender, WeekSelectControl.ButtonWeekSearchEventArgs e)
        {
            bdsWeek.DataSource = Dao.Rent.WeekSearch(e.Week);
        }

        private void genreSelectControl1_GenreSelected(object sender, GenreSelectControl.GenreSelectedEventArgs e)
        {
            Series series = chartCntrlWeekly.Series.FirstOrDefault(x => x.Name == e.Genre) as Series;

            if (series == null)
                return;

            series.Visible = false;
        }
    }
}
