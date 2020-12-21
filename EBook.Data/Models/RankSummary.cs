using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook.Data.Models
{
    public class RankSummary
    {
        public int Rank { get; set; }

        public int BookCountRank { get; set; }

        public int NewBookRank { get; set; }

        public int BestsellerRank { get; set; }

        public string Title { get; set; }

    }
}
