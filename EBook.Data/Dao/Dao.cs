using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook.Data
{
    class Dao
    {
        public static BookDao Book = new BookDao();

        public static CustomerDao Customer = new CustomerDao();

        public static RentDao Rent = new RentDao();
    }

}
