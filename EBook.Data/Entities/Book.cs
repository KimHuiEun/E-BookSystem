using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook.Data
{
    public partial class Book
    {
        public override string ToString()
        {
            return $"{BookId} / {Title} / {Author} / {Publisher} / {PublicationDate} / {Genre}";
        }

        public bool IsNewBook
        {
            get
            {
                return PublicationDate >= DateTime.Today.AddMonths(-3);
            }
        }
    }
}
