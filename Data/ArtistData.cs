using TunaPiano.Models;

namespace TunaPiano.Data
{
    public class ArtistData
    {
        public static List<Artist> Artists = new()
        {
            new() { Id = 1, Name = "Tame Impala", Age = 37, Bio = "An Australian music project led by multi-instrumentalist Kevin Parker, known for blending psychedelic rock with indie pop." },
            new() { Id = 2, Name = "American Football", Age = 46, Bio = "An American rock band from Illinois, known for pioneering the Midwest Emo genre." },
            new() { Id = 3, Name = "My Bloody Valentine", Age = 61, Bio = "An Irish-English rock band formed in 1983, credited with popularizing the shoegaze genre." },
            new() { Id = 4, Name = "Kendrick Lamar", Age = 37, Bio = "An American rapper, songwriter, and record producer known for his socially conscious lyrics and storytelling." },
            new() { Id = 5, Name = "Drake", Age = 37, Bio = "A Canadian rapper, singer, and songwriter, known for blending rap and R&B in his music." },
            new() { Id = 6, Name = "SZA", Age = 34, Bio = "An American singer and songwriter, known for her alternative R&B sound and introspective lyrics." },
            new() { Id = 7, Name = "Tricot", Age = 34, Bio = "A Japanese math rock band known for their complex rhythms and technical guitar work." }
        };
    }
}