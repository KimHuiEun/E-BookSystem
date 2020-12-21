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

        //이벤트 핸들러 선언
        public event EventHandler<ItemClickedEventArgs> ItemClicked; 

        private void CheckBox_ItemCheck(object sender, EventArgs e)
        {
            for (int i = 0; i <= (clGenre.Items.Count - 1); i++)
            {
                if (clGenre.GetItemChecked(i))
                {
                    string s = clGenre.Items[i].ToString();
                    ItemClickedEventArgs args = new ItemClickedEventArgs();
                    args.Text = s;

                    if (ItemClicked != null)
                    {
                        ItemClicked(this, args);
                    }
                }                 
            }            
        }
    }

    public class ItemClickedEventArgs : EventArgs
    {
        public string Text { get; set; }
    }
}
