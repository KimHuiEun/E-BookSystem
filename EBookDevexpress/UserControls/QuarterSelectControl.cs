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
    public partial class QuarterSelectControl : UserControl
    {
        public QuarterSelectControl()
        {
            InitializeComponent();
        }

        /*private void btnQuarterSearch_Click(object sender, EventArgs e)
        {
           OnButtonQuarterSearch(quarter.Text);
        }
*/
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

        private void btnPeriod1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPeriod1.Checked == true)
            {
                //차트의 기간을 1분기로 기간선택하는 이벤트 발생
            }
        }

        private void btnPeriod2_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPeriod2.Checked == true)
            {

            }
        }

        private void btnPeriod3_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPeriod3.Checked == true)
            {

            }
        }

        private void btnPeriod4_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPeriod4.Checked == true)
            {

            }
        }
    }
}
