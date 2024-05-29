using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylShop.first
{
    public class LP : Vinyl
    {
        public int NumberOfTrack { get; set; }
        public LP(string title, string artist, string genre, int year, int numberOfTracks) : base(title, artist, genre, year)
        {
            NumberOfTrack = numberOfTracks;
        }
        public override string ToString()
        {
            return $"[LP] Title: {Title}, Artist: {Artist}, Genre: {Genre}, Year: {Year}, Tracks: {NumberOfTrack}";
        }

    }
}
