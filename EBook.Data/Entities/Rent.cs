using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook.Data
{
    public partial class Rent
    {
        public override string ToString()
        {
            return $"{RentId} / {RentDate} / {CustomerId} / {BookId} / {ReturnedDate}";
        }

        public int Decade
        {
            get
            {
                return (DateTime.Now.Year - BirthYear) / 10 * 10;
            }
        }

        public int BirthYear { get; set; }

        public string Genre { get; set; }
    }
}
