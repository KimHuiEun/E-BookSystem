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
    public partial class WeekSelectControl : UserControl
    {
        public WeekSelectControl()
        {
            InitializeComponent();
        }

        private void btnWeekSearch_Click(object sender, EventArgs e)
        {
            OnButtonWeekSearch(week.Text);
        }

        #region ButtonWeekSearch event things for C# 3.0
        public event EventHandler<ButtonWeekSearchEventArgs> ButtonWeekSearch;

        protected virtual void OnButtonWeekSearch(ButtonWeekSearchEventArgs e)
        {
            if (ButtonWeekSearch != null)
                ButtonWeekSearch(this, e);
        }

        private ButtonWeekSearchEventArgs OnButtonWeekSearch(string weekSelect)
        {
            ButtonWeekSearchEventArgs args = new ButtonWeekSearchEventArgs(weekSelect);
            OnButtonWeekSearch(args);

            return args;
        }

        private ButtonWeekSearchEventArgs OnButtonWeekSearchForOut()
        {
            ButtonWeekSearchEventArgs args = new ButtonWeekSearchEventArgs();
            OnButtonWeekSearch(args);

            return args;
        }

        public class ButtonWeekSearchEventArgs : EventArgs
        {
            public string WeekSelect { get; set; }

            public ButtonWeekSearchEventArgs()
            {
            }

            public ButtonWeekSearchEventArgs(string weekSelect)
            {
                WeekSelect = weekSelect;
            }
        }
        #endregion
    }
}
