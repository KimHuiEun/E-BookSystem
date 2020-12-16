using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace EBook.Data
{
    public class CustomerDao : SingleKeyDao<Customer, int>
    {

        protected override Expression<Func<Customer, int>> KeySelector
        {
            get
            {
                return x => x.CustomerId;
            }
        }
    }
}