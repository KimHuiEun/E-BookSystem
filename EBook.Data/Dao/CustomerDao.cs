using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace EBook.Data
{
    public class CustomerDao : SingleKeyDao<Customer, int>
    {

        protected override Expression<Func<Customer, int>> KeySelector => x => x.CustomerId;

        public List<Customer> GetByGender(string gender)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Customers
                            where x.Gender == gender
                            select x;

                return query.ToList();
            }
        }
    }
}