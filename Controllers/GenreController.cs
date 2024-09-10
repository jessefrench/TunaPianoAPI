using Microsoft.EntityFrameworkCore;
using TunaPiano.Models;

namespace TunaPiano.Controllers
{
    public class GenreController
    {
        public static void Map(WebApplication app)
        {
            // get all genres
            app.MapGet("/genres", (TunaPianoDbContext db) =>
            {
                return db.Genres.ToList();
            });

            // get a single genre + genre's songs
            app.MapGet("/genres/{id}", (TunaPianoDbContext db, int id) =>
            {
                Genre genre = db.Genres
                                .Include(genre => genre.Songs)
                                .SingleOrDefault(genre => genre.Id == id);

                if (genre == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(genre);
            });

            // create a genre
            app.MapPost("/genres", (TunaPianoDbContext db, Genre newGenre) =>
            {
                db.Genres.Add(newGenre);
                db.SaveChanges();
                return Results.Created($"genres/{newGenre.Id}", newGenre);
            });

            // update a genre
            app.MapPut("/genres/{id}", (TunaPianoDbContext db, int id, Genre genre) =>
            {
                Genre genreToUpdate = db.Genres.SingleOrDefault(genre => genre.Id == id);

                if (genreToUpdate == null)
                {
                    return Results.NotFound();
                }

                genreToUpdate.Description = genre.Description;

                db.SaveChanges();
                return Results.Ok(genreToUpdate);
            });

            // delete a genre
            app.MapDelete("/genres/{id}", (TunaPianoDbContext db, int id) =>
            {
                Genre genre = db.Genres.SingleOrDefault(genre => genre.Id == id);

                if (genre == null)
                {
                    return Results.NotFound();
                }

                db.Genres.Remove(genre);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}