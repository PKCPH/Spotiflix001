using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spotiflix001.TypesOfData;

namespace Spotiflix001
{
    internal class Gui
    {
        Data data = new Data();

        private string path = Path.GetFullPath(@"..\\..\\SpotiflixData.json");
        public Gui()
        {
            while (true)
            {
                Menu();
            }
        }

        private void Menu()
        {
            Console.WriteLine("\nMENU\n1: Movies\n2: Series\n3: Music\n4: Save data\n5: Load data");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    MovieMenu();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    SeriesMenu();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    MusicMenu();
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    SaveData();
                    break;
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
                    LoadData();
                    break;
                case ConsoleKey.NumPad6:
                case ConsoleKey.D6:
                    Search();
                    break;
                default:
                    break;
            }
        }

        
        ///////////////////MOVIES/////////////////////
        private void MovieMenu()
        {
            Console.WriteLine("\nMOVIE MENU\n1: Show All Movies\n2: Search for Movie\n3: Add Movies");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    ShowMovieList();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    SearchMovie();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    AddMovie();
                    break;
                default:
                    break;
            }
        }

        private void AddMovie()
        {
            Movie movie = new Movie();
            movie.Title = GetString("Title: ");
            movie.Length = GetLength();
            movie.Genre = GetString("Genre: ");
            movie.ReleaseDate = GetReleaseDate();
            movie.WWW = GetString("WWW: ");

            ShowMovie(movie);
            Console.WriteLine("Confirm adding to list (Y/N)");
            if (Console.ReadKey().Key == ConsoleKey.Y) data.MovieList.Add(movie);
        }

        private void SearchMovie()
        {
            Console.Write("Search: ");
            string? search = Console.ReadLine();
            foreach (Movie movie in data.MovieList)
            {
                if (search != null)
                {
                    if (movie.Title.Contains(search) || movie.Genre.Contains(search))
                        ShowMovie(movie);
                }
            }
        }
        private void ShowMovie(Movie m)
        {
            Console.WriteLine($"{m.Title} {m.GetLength()} {m.Genre} {m.GetReleaseDate()} {m.WWW}");
        }

        private void ShowMovieList()
        {
            foreach (Movie m in data.MovieList)
            {
                ShowMovie(m);
            }
        }

        //////////////SERIES/////////////////////
       
        private void SeriesMenu()
        {
            Console.WriteLine("\nMOVIE MENU\n1: Show All Series\n2: Search\n3: Add Series");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    ShowSeriesList();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    SearchSeries();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    AddSeries();
                    break;
                default:
                    break;
            }
        }

        private void AddSeries()
        {
            Series series = new Series();
            series.Title = GetString("Title: ");
            series.Length = GetLength();
            series.Genre = GetString("Genre: ");
            series.ReleaseDate = GetReleaseDate();
            series.WWW = GetString("WWW: ");

            Console.WriteLine("Add a serie? (Y/N)");
            if (Console.ReadKey().Key == ConsoleKey.Y) data.SeriesList.Add(series);
            do
            {
                AddEpisode(series);
                Console.WriteLine("Add another episode? (Y/N)");
            }
            while (Console.ReadKey().Key == ConsoleKey.Y);
        }

        /// <summary>
        /// AddEpisode() in do while
        /// </summary>
        /// 
        private void AddEpisode(Series series)
        {
            Episode episode = new();
            Console.WriteLine("Add episode? (Y/N)");
            if (Console.ReadKey().Key == ConsoleKey.Y) series.Episodes.Add(episode);
        }

        private void SearchSeries()
        {
            Console.Write("Search: ");
            string? search = Console.ReadLine();
            foreach (Series series in data.SeriesList)
            {
                if (search != null)
                {
                    if (series.Title.Contains(search) || series.Genre.Contains(search))
                        ShowSeries(series);
                }
            }
        }

        private void ShowSeries(Series s)
        {
            Console.WriteLine($"{s.Title} {s.Episodes} {s.GetLength()} {s.Genre} {s.GetReleaseDate()} {s.WWW}");
        }

        private void ShowSeriesList()
        {
            foreach (Series s in data.SeriesList)
            {
                ShowSeries(s);
            }
        }

        /// <summary>
        /// ///////////MUSIC/////////////////////
        /// </summary>

        private void MusicMenu()
        {
            Console.WriteLine("\nMOVIE MENU\n1: Show All Music\n2: Search\n3: Add Music");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    ShowMusicList();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    SearchMusic();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    AddMusic();
                    break;
                default:
                    break;
            }
        }


        private void AddMusic()
        {
            Music music = new Music();
            music.Title = GetString("Title: ");
            music.Length = GetLength();
            music.Genre = GetString("Genre: ");
            music.ReleaseDate = GetReleaseDate();
            music.WWW = GetString("WWW: ");

            ShowMusic(music);
            Console.WriteLine("Confirm adding to list (Y/N)");
            if (Console.ReadKey().Key == ConsoleKey.Y) data.MusicList.Add(music);
        }

        private void SearchMusic()
        {
            Console.Write("Search: ");
            string? search = Console.ReadLine();
            foreach (Music music in data.MusicList)
            {
                if (search != null)
                {
                    if (music.Title.Contains(search) || music.Genre.Contains(search))
                        ShowMusic(music);
                }
            }
        }
        private void ShowMusic(Music m)
        {
            Console.WriteLine($"{m.Title} {m.GetLength()} {m.Genre} {m.GetReleaseDate()} {m.WWW}");
        }

        private void ShowMusicList()
        {
            foreach (Movie m in data.MovieList)
            {
                ShowMovie(m);
            }
        }


        //////////////OTHER METHODS//////////////////////

        private void SaveData()
        {
            string json = System.Text.Json.JsonSerializer.Serialize(data);
            File.WriteAllText(path, json);
            Console.WriteLine("File saved succesfully at " + path);
        }

        private void LoadData()
        {
            string json = File.ReadAllText(path);
            //TODO Does File Exists?
            data = System.Text.Json.JsonSerializer.Deserialize<Data>(json);
            Console.WriteLine("File loaded succesfully from " + path);
        }


        private DateTime GetLength()
        {
            DateTime time;
            do
            {
                Console.Write("Length (hh:mm:ss): ");
            }
            while (!DateTime.TryParse("0001-01-01 " + Console.ReadLine(), out time));
            return time;
        }

        private DateTime GetReleaseDate()
        {
            DateTime date;
            do
            {
                Console.Write("Release Date (dd/mm/yyyy): ");
            }
            while (!DateTime.TryParse(Console.ReadLine(), out date));
            return date;
        }

        private string GetString(string type)
        {
            string? input;
            do
            {
                Console.Write(type);
                input = Console.ReadLine();
            }
            while (input == null || input == "");
            return input;
        }

        private void Search()
        {
            Console.Write("Search: ");
            SearchMovie();
            SearchMusic();
            SearchSeries();

        }
    }

    
}

