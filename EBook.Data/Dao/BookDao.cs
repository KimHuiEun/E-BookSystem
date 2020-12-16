using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EBook.Data
{
    public class BookDao : SingleKeyDao<Customer, int>
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

        public List<Book> GetByTitle(string title)
        {
            using(EBookEntities context = (EBookEntities)DbContextCreator.Context())
            {
                var query = from x in context.Books
                            where x.Title.Contains(title)
                            select x;

                return query.ToList();
            }
        }

    }
}