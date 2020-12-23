using EBook.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook.ConsoleUI
{
    class Program
    {
        private static void PrintLog(string log)
        {
            Console.WriteLine(log);
        }

        static void Main(string[] args)
        {
            var rents = Dao.Rent.GetAll();

            //var periods = Dao.Rent.DaySearch(DateTime.Today);
            //var periods = Dao.Rent.BestsellerRank();
            var periods = Dao.Rent.NewBookRank();
            foreach (var period in periods)
            {
                Console.WriteLine(period);
            }
           
        }
    }
}