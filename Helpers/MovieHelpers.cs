//using Spotiflix001.TypesOfData;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Spotiflix001.Helpers
//{
//    internal class MovieHelpers
//    {
//        Data data = new Data();

//        ///////////////////MOVIES/////////////////////
//        internal void MovieMenu()
//        {
//            Console.WriteLine("\nMOVIE MENU\n1 for list of movies\n2 for search movies\n3 for add new movie");

//            switch (Console.ReadKey(true).Key)
//            {
//                case ConsoleKey.NumPad1:
//                case ConsoleKey.D1:
//                    ShowMovieList();
//                    break;
//                case ConsoleKey.NumPad2:
//                case ConsoleKey.D2:
//                    SearchMovie();
//                    break;
//                case ConsoleKey.NumPad3:
//                case ConsoleKey.D3:
//                    AddMovie();
//                    break;
//                default:
//                    break;
//            }
//        }

//        private void AddMovie()
//        {
//            Movie movie = new Movie();
//            movie.Title = GetString("Title: ");
//            movie.Length = GetLength();
//            movie.Genre = GetString("Genre: ");
//            movie.ReleaseDate = GetReleaseDate();
//            movie.WWW = GetString("WWW: ");

//            ShowMovie(movie);
//            Console.WriteLine("Confirm adding to list (Y/N)");
//            if (Console.ReadKey().Key == ConsoleKey.Y) data.MovieList.Add(movie);
//        }

//        private void SearchMovie()
//        {
//            Console.Write("Search: ");
//            string? search = Console.ReadLine();
//            foreach (Movie movie in data.MovieList)
//            {
//                if (search != null)
//                {
//                    if (movie.Title.Contains(search) || movie.Genre.Contains(search))
//                        ShowMovie(movie);
//                }
//            }
//        }
//        private void ShowMovie(Movie m)
//        {
//            Console.WriteLine($"{m.Title} {m.GetLength()} {m.Genre} {m.GetReleaseDate()} {m.WWW}");
//        }

//        private void ShowMovieList()
//        {
//            foreach (Movie m in data.MovieList)
//            {
//                ShowMovie(m);
//            }
//        }
//    }
//}
