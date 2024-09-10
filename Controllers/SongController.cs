using Microsoft.EntityFrameworkCore;
using TunaPiano.Models;

namespace TunaPiano.Controllers
{
    public class SongController
    {
        public static void Map(WebApplication app)
        {
            // get all songs
            app.MapGet("/songs", (TunaPianoDbContext db) =>
            {
                return db.Songs.ToList();
            });

            // get a single song + genres and artist details
            app.MapGet("/songs/{id}", (TunaPianoDbContext db, int id) =>
            {
                Song song = db.Songs
                                .Include(song => song.Artist)
                                .Include(song => song.Genres)
                                .SingleOrDefault(song => song.Id == id);

                if (song == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(song);
            });

            // create a song
            app.MapPost("/songs", (TunaPianoDbContext db, Song newSong) =>
            {
                db.Songs.Add(newSong);
                db.SaveChanges();
                return Results.Created($"songs/{newSong.Id}", newSong);
            });

            // update a song
            app.MapPut("/songs/{id}", (TunaPianoDbContext db, int id, Song song) =>
            {
                Song songToUpdate = db.Songs.SingleOrDefault(song => song.Id == id);

                if (songToUpdate == null)
                {
                    return Results.NotFound();
                }

                songToUpdate.Title = song.Title;
                songToUpdate.ArtistId = song.ArtistId;
                songToUpdate.Album = song.Album;
                songToUpdate.Length = song.Length;

                db.SaveChanges();
                return Results.Ok(songToUpdate);
            });

            // delete a song
            app.MapDelete("/songs/{id}", (TunaPianoDbContext db, int id) =>
            {
                Song song = db.Songs.SingleOrDefault(song => song.Id == id);

                if (song == null)
                {
                    return Results.NotFound();
                }

                db.Songs.Remove(song);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}