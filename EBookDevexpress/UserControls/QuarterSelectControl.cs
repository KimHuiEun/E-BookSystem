﻿using System;
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
    public partial class QuarterSelectControl : UserControl
    {
        public QuarterSelectControl()
        {
            InitializeComponent();
        }

        #region ButtonQuarterSearch event things for C# 3.0
        public event EventHandler<ButtonQuarterSearchEventArgs> ButtonQuarterSearch;

        protected virtual void OnButtonQuarterSearch(ButtonQuarterSearchEventArgs e)
        {
            if (ButtonQuarterSearch != null)
                ButtonQuarterSearch(this, e);
        }

        private ButtonQuarterSearchEventArgs OnButtonQuarterSearch(string quarter)
        {
            ButtonQuarterSearchEventArgs args = new ButtonQuarterSearchEventArgs(quarter);
            OnButtonQuarterSearch(args);

            return args;
        }

        private ButtonQuarterSearchEventArgs OnButtonQuarterSearchForOut()
        {
            ButtonQuarterSearchEventArgs args = new ButtonQuarterSearchEventArgs();
            OnButtonQuarterSearch(args);

            return args;
        }

        public class ButtonQuarterSearchEventArgs : EventArgs
        {
            public string Quarter { get; set; }

            public ButtonQuarterSearchEventArgs()
            {
            }

            public ButtonQuarterSearchEventArgs(string quarter)
            {
                Quarter = quarter;
            }
        }
        #endregion
    }



    //    private void btnQuarterSearch_Click(object sender, EventArgs e)
    //    {
    //        RadioButton quartSelect = sender as RadioButton;
    //        string msg = //초기화.

    //        if (quartSelect.Checked = false)
    //            return;

    //        msg = string.Format(quartSelect.Text);
    //    }
    //}
}
