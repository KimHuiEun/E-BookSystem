using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook.Data
{
    public partial class Customer
    {
        public override string ToString()
        {
            return $"{CustomerId} / {Name} / {BirthYear} / {Gender} / {Phone}";
        }

       /* public int Age { get; set; }
        public int Decade { get; set; }*/
    }
}
