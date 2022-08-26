using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spotiflix001.TypesOfData;

namespace Spotiflix001
{
    internal class Data
    {
        //Saves data here
        public List<Movie> MovieList { get; set; } = new();
        public List<Series> SeriesList { get; set; } = new();
        public List<Music> MusicList { get; set; } = new();

    }
}
