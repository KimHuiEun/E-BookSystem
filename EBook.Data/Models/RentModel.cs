using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook.Data
{
    public class RentModel
    {
        public DateTime RentDate { get; set; } //TODO : 시간안나오고 날짜만 나오는 데이터형식 찾기.

        public int CustomerCount { get; set; }

        public int BookCount { get; set; }

        public DateTime ReturnDate { get; set; }
    }
}
