﻿using DevExpress.XtraEditors;
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
    public partial class NewBookRankForm : XtraForm
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

            bdsNewBook.DataSource = Dao.Rent.NewBookRank();
        }
    }
}
