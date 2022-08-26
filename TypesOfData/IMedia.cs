using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotiflix001.TypesOfData
{
    public interface IMedia
    {

        public string? Title { get; set; }

        public string? Genre { get; set; }

        public string? WWW { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime Length { get; set; }

        public string GetLength()
        {
            return Length.ToString("hh:mm");
        }
        public string GetReleaseDate()
        {
            return ReleaseDate.ToString("D");
        }
    }
}
