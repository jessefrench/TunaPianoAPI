using TunaPianoAPI.Models;

namespace TunaPianoAPI.Data
{
    public class SongData
    {
        public static List<Song> Songs = new()
        {
            new() { Id = 1, Title = "The Less I Know The Better", ArtistId = 1, Album = "Currents", Length = 216 },
            new() { Id = 2, Title = "Never Meant", ArtistId = 2, Album = "American Football", Length = 258 },
            new() { Id = 3, Title = "Only Shallow", ArtistId = 3, Album = "Loveless", Length = 276 },
            new() { Id = 4, Title = "HUMBLE.", ArtistId = 4, Album = "DAMN.", Length = 177 },
            new() { Id = 5, Title = "Hotline Bling", ArtistId = 5, Album = "Views", Length = 267 },
            new() { Id = 6, Title = "Good Days", ArtistId = 6, Album = "Good Days - Single", Length = 271 },
            new() { Id = 7, Title = "Melon Soda", ArtistId = 7, Album = "A N D", Length = 223 }
        };
    }
}