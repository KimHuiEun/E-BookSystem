using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook.Data.Models
{
    public class BookCategory
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public static List<BookCategory> Create()
        {
            List<BookCategory> list = new List<BookCategory>();
            list.Add(new BookCategory { Id = 1, Name = "문학" });
            list.Add(new BookCategory { Id = 2, Name = "경제" });
            list.Add(new BookCategory { Id = 3, Name = "경영" });
            list.Add(new BookCategory { Id = 4, Name = "문학" });

            return list;
        }
    }
}
