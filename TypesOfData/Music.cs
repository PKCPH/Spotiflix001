namespace Spotiflix001.TypesOfData
{
    internal class Music
    {
        public string? Title { get; set; }

        public string? Artist { get; set; }

        public string? Album { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime Length { get; set; }

        public string? Genre { get; set; }

        public string? WWW { get; set; }

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
