using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace EBook.Data
{
    public class BookDao : SingleKeyDao<Book, int>
    {
        protected override Expression<Func<Book,int>> KeySelector => x => x.BookId;

    }
}