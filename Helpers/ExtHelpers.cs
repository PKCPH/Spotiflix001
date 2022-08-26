//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Spotiflix001.Helpers
//{
//    internal class ExtHelpers
//    {
//        //ext methods

//        private DateTime GetLength()
//        {
//            DateTime time;
//            do
//            {
//                Console.Write("Length (hh:mm:ss): ");
//            }
//            while (!DateTime.TryParse("0001-01-01 " + Console.ReadLine(), out time));
//            return time;
//        }

//        private DateTime GetReleaseDate()
//        {
//            DateTime date;
//            do
//            {
//                Console.Write("Release Date (dd/mm/yyyy): ");
//            }
//            while (!DateTime.TryParse(Console.ReadLine(), out date));
//            return date;
//        }

//        private string GetString(string type)
//        {
//            string? input;
//            do
//            {
//                Console.Write(type);
//                input = Console.ReadLine();
//            }
//            while (input == null || input == "");
//            return input;
//        }
//    }
//}
