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
    public partial class DaySelectControl : UserControl
    {
        public DaySelectControl()
        {
            InitializeComponent();
        }

        private void btnDaySearch_Click(object sender, EventArgs e)
        {
            OnButtonDaySearch(day.Text);
        }

        #region ButtonDaySearch event things for C# 3.0
        public event EventHandler<ButtonDaySearchEventArgs> ButtonDaySearch;

        protected virtual void OnButtonDaySearch(ButtonDaySearchEventArgs e)
        {
            if (ButtonDaySearch != null)
                ButtonDaySearch(this, e);
        }

        private ButtonDaySearchEventArgs OnButtonDaySearch(string daySelect)
        {
            ButtonDaySearchEventArgs args = new ButtonDaySearchEventArgs(daySelect);
            OnButtonDaySearch(args);

            return args;
        }

        private ButtonDaySearchEventArgs OnButtonDaySearchForOut()
        {
            ButtonDaySearchEventArgs args = new ButtonDaySearchEventArgs();
            OnButtonDaySearch(args);

            return args;
        }

        public class ButtonDaySearchEventArgs : EventArgs
        {
            public string DaySelect { get; set; }

            public ButtonDaySearchEventArgs()
            {
            }

            public ButtonDaySearchEventArgs(string daySelect)
            {
                DaySelect = daySelect;
            }
        }
        #endregion
    }
}
