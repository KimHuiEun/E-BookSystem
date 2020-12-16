using EFLibrary;
using System;
using System.Linq.Expressions;

namespace EBook.Data
{
    public class RentDao : SingleKeyDao<Rent, int>
    {
        protected override Expression<Func<Rent, int>> KeySelector
        {
            get
            {
                return x => x.RentId;
            }
        }
        
    }
}