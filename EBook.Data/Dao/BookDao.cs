using EFLibrary;
using System;
using System.Linq.Expressions;

namespace EBook.Data.Dao
{
    public class BookDao : SingleKeyDao<Customer, int>
    {
        protected override Expression<Func<Customer, int>> KeySelector

            get
            {
                return x => x.CustomerId;
            }
                return query.ToList();
            }


    }
}