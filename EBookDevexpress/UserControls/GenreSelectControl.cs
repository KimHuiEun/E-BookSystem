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
    public partial class GenreSelectControl : UserControl
    {
        public GenreSelectControl()
        {
            InitializeComponent();
        }
       
        private void clGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSelectedIndexClicked();
        }

        #region 교수님 예제를 보고 수정한 이벤트 핸들러 코드
        public event EventHandler<SelectedIndexClickedEventArgs> SelectedIndexClicked;

        protected virtual void OnSelectedIndexClicked(SelectedIndexClickedEventArgs e)
        {
            if (SelectedIndexClicked != null)
                SelectedIndexClicked(this, e);
        }

        private SelectedIndexClickedEventArgs OnSelectedIndexClicked(string clGenreText)
        {
            SelectedIndexClickedEventArgs args = new SelectedIndexClickedEventArgs(clGenreText);
            OnSelectedIndexClicked(args);

            return args;
        }
        public class SelectedIndexClickedEventArgs : EventArgs
        {
            public string clGenreText { get; set; }

            public SelectedIndexClickedEventArgs()
            {

            }

            public SelectedIndexClickedEventArgs(string clGenreText)
            {
                clGenreText = clGenreText;
            }
        }
        #endregion
    }
}
