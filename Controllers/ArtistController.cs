using Microsoft.EntityFrameworkCore;
using TunaPiano.Models;

namespace TunaPiano.Controllers
{
    public class ArtistController
    {
        public static void Map(WebApplication app)
        {
            // get all artists
            app.MapGet("/artists", (TunaPianoDbContext db) =>
            {
                return db.Artists.ToList();
            });

            // get a single artist + artist's songs
            app.MapGet("/artists/{id}", (TunaPianoDbContext db, int id) =>
            {
                Artist artist = db.Artists
                                .Include(artist => artist.Songs)
                                .SingleOrDefault(artist => artist.Id == id);

                if (artist == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(artist);
            });

            // create an artist
            app.MapPost("/artists", (TunaPianoDbContext db, Artist newArtist) =>
            {
                db.Artists.Add(newArtist);
                db.SaveChanges();
                return Results.Created($"artists/{newArtist.Id}", newArtist);
            });

            // update an artist
            app.MapPut("/artists/{id}", (TunaPianoDbContext db, int id, Artist artist) =>
            {
                Artist artistToUpdate = db.Artists.SingleOrDefault(artist => artist.Id == id);

                if (artistToUpdate == null)
                {
                    return Results.NotFound();
                }

                artistToUpdate.Name = artist.Name;
                artistToUpdate.Age = artist.Age;
                artistToUpdate.Bio = artist.Bio;

                db.SaveChanges();
                return Results.Ok(artistToUpdate);
            });

            // delete an artist
            app.MapDelete("/artists/{id}", (TunaPianoDbContext db, int id) =>
            {
                Artist artist = db.Artists.SingleOrDefault(artist => artist.Id == id);

                if (artist == null)
                {
                    return Results.NotFound();
                }

                db.Artists.Remove(artist);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}