using EFLibrary;
using System;
using System.Linq.Expressions;

namespace EBook.Data.Dao
{
    public class CustomerDao : SingleKeyDao<Customer, int>
    {
        protected override Expression<Func<Customer, bool>> IsKey(int key)
        {
            return x => x.CustomerId == key;
        }

        protected override Expression<Func<Customer, int>> KeySelector
        {
            get
            {
                return x => x.CustomerId;
            }
        }

    }
}