using IRunes.App.ViewModels.Albums;
using IRunes.App.ViewModels.Tracks;
using IRunes.Data;
using IRunes.Models;
using System.Collections.Generic;
using System.Linq;

namespace IRunes.App.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly RunesDbContext db;
        public AlbumService(RunesDbContext db)
        {
            this.db = db;
        }
        public void CreateAlbum(string name, string cover)
        {
            Album album = new Album
            {
                Name = name,
                Cover = cover,
                Price = 0.0M,
            };

            this.db.Albums.Add(album);
            this.db.SaveChanges();

        }

        public IEnumerable<AlbumInfoViewModel> GetAllAlbums()
        {
            var allAlbums = this.db.Albums
                .Select(a => new AlbumInfoViewModel
            {
                Id = a.Id,
                Name = a.Name,

            })
                .ToList();

            return allAlbums; 
        }

        public AlbumDetailsViewModel Getdetails(string albumId)
        {
            var album = this.db.Albums.Where(a => a.Id == albumId)
                .Select(a => new AlbumDetailsViewModel
            {
                Id = a.Id,
                Name = a.Name,
                Cover = a.Cover,
                Price = a.Price,
                Tracks = a.Tracks.Select(t => new TrackInfoViewModel
                {
                    Id = t.Id,
                    Name = t.Name,
                })
                })
                .FirstOrDefault();

            return album; 
        }
    }
}
