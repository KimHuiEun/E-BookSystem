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

            /*            var periods = Dao.Rent.DaySearch(DateTime.Today);
                        foreach (var period in periods)
                        {
                            Console.WriteLine(period);
                        }*/

            var periods = Dao.Rent.BestsellerRank();
            foreach (var period in periods)
            {
                Console.WriteLine(period);
            }
        }
    }
}