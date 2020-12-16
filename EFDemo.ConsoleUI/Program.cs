using EFLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.ConsoleUI
{
    class Program
    {
        private static void PrintLog(string log)
        {
            Console.WriteLine(log);
        }

        static void Main(string[] args)
        {
            //ChinookEntities chinook = DbContextCreator.Create();

            /*List<ArtistModel> models = Dao.Artist.GetModels();
            foreach (ArtistModel model in models)
            {
                Console.WriteLine($"{model.Name} / {model.AlbumCount}");
            }*/
        }
    }
}
