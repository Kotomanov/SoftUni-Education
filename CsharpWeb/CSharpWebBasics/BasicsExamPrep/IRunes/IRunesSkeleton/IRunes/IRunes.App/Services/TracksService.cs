using IRunes.App.ViewModels.Tracks;
using IRunes.Data;
using IRunes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IRunes.App.Services
{
    public class TracksService : ITracksService
    {
        private readonly RunesDbContext db;
        public TracksService(RunesDbContext db)
        {
            this.db = db;
        }
        public void CreateTrack(string albumId, string name, string link, decimal price)
        {
            Track track = new Track
            {
                AlbumId = albumId,
                Name = name,
                Link = link,
                Price = price,

            };

            this.db.Tracks.Add(track);

            var allTracksPricesSum = this.db.Tracks
                                   .Where(t => t.AlbumId == albumId)
                                   .Sum(t => t.Price) + price;
                                    

            var album = this.db.Albums.Find(albumId);
            album.Price = allTracksPricesSum* 0.87m; 



            this.db.SaveChanges();
        }

        public DetailsViewModel Details(string trackId)
        {
            var track = this.db
                .Tracks
                .Where(t => t.Id == trackId)
                .Select(t => new DetailsViewModel
                {
                    Name = t.Name,
                    AlbumId = t.AlbumId,
                    Link = t.Link,
                    Price = t.Price,
                })
                .FirstOrDefault();

                return track;
        }
    }
}
