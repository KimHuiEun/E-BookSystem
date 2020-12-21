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
            OnGenreSelected(clGenre.Text);
        }

        #region GenreSelected event things for C# 3.0
        public event EventHandler<GenreSelectedEventArgs> GenreSelected;

        protected virtual void OnGenreSelected(GenreSelectedEventArgs e)
        {
            if (GenreSelected != null)
                GenreSelected(this, e);
        }

        private GenreSelectedEventArgs OnGenreSelected(string genre)
        {
            GenreSelectedEventArgs args = new GenreSelectedEventArgs(genre);
            OnGenreSelected(args);

            return args;
        }

        private GenreSelectedEventArgs OnGenreSelectedForOut()
        {
            GenreSelectedEventArgs args = new GenreSelectedEventArgs();
            OnGenreSelected(args);

            return args;
        }

        public class GenreSelectedEventArgs : EventArgs
        {
            public string Genre { get; set; }

            public GenreSelectedEventArgs()
            {
            }

            public GenreSelectedEventArgs(string genre)
            {
                Genre = genre;
            }
        }
        #endregion
    }

}
