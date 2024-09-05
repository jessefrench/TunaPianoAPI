using TunaPianoAPI.Models;

namespace TunaPianoAPI.Data
{
    public class GenreData
    {
        public static List<Genre> Genres = new()
        {
            new() { Id = 1, Description = "Indie" },
            new() { Id = 2, Description = "Midwest Emo" },
            new() { Id = 3, Description = "Shoegaze" },
            new() { Id = 4, Description = "Hip Hop" },
            new() { Id = 5, Description = "Rap" },
            new() { Id = 6, Description = "R&B" },
            new() { Id = 7, Description = "Japanese Math Rock" }
        };
    }
}