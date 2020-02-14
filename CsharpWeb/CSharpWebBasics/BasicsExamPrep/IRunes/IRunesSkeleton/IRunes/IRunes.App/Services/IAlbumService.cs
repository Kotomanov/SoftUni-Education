using IRunes.App.ViewModels.Albums;
using System;
using System.Collections.Generic;
using System.Text;

namespace IRunes.App.Services
{
    public interface IAlbumService
    {
        void CreateAlbum(string name, string cover);

        IEnumerable<AlbumInfoViewModel> GetAllAlbums();

        AlbumDetailsViewModel Getdetails(string albumId);
    }
}
