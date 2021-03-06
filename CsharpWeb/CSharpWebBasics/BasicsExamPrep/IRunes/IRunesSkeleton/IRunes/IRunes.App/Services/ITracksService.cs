﻿using IRunes.App.ViewModels.Tracks;
using System;
using System.Collections.Generic;
using System.Text;

namespace IRunes.App.Services
{
    public interface ITracksService
    {
        void CreateTrack(string albumId, string name, string link, decimal price);

        DetailsViewModel Details(string trackId); 
    }
}
