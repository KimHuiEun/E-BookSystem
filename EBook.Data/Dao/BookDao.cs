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

        public List<Book> GetByTitle(string title)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Books
                            where x.Title == title
                            select x;

                return query.ToList();
            }
        }

        public List<Book> GetByPublicationYear(int publicationYear)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Books
                            where x.PublicationYear == publicationYear
                            select x;

                return query.ToList();
            }
        }

        public List<Book> GetByGenre(string genre)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Books
                            where x.Genre == genre
                            select x;

                return query.ToList();
            }
        }


    }
}