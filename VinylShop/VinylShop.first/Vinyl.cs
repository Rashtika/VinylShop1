using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylShop.first
{
    public abstract class Vinyl
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public Vinyl(string title, string artist, string genre, int year)
        {
            Title = title;
            Artist = artist;
            Genre = genre;
            Year = year;
        }
        public abstract override string ToString();

    }
}
