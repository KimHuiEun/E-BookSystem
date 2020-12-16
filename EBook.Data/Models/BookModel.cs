using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook.Data
{
    public class BookModel
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public int PublicationYear { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }
    }
}
