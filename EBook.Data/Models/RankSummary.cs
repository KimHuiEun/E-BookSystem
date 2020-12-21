using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook.Data.Models
{
    public class RankSummary
    {
        public string Title { get; set; }

        public int BestsellerRank { get; set; }

        public int NewBookRank { get; set; }

        public int Count { get; set; }

    }
}
