using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylShop.first
{
    public class Single : Vinyl
    {
        public string BSide { get; set; }
        public  Single(string title, string artist, string genre, int year, string bSide) : base(title, artist, genre, year)
        {
            BSide = bSide;
        }
        public override string ToString()
        {
            return $"[LP] Title: {Title}, Artist: {Artist}, Genre: {Genre}, Year: {Year}, B-Side: {BSide}";
        }
    }
}
