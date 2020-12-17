using EBook.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrary
{
    public class DbContextCreator
    {
        private const string ConnectionString = "metadata=res://*/EBook.csdl|res://*/EBook.ssdl|res://*/EBook.msl;provider=System.Data.SqlClient;provider connection string=\"data source=cn76.ipdisk.co.kr,3423;initial catalog=_E-Book;persist security info=True;user id=8F;password=1;MultipleActiveResultSets=True;App=EntityFramework\"";

        public static EBookEntities Create()
        {
            EBookEntities context = new EBookEntities(ConnectionString);

            context.Configuration.ProxyCreationEnabled = false;

            return context;
        }
    }
}

namespace EBook.Data
{
    public partial class EBookEntities
    {
        public EBookEntities(string connectionString) : base(connectionString)
        {
        }
    }
}

