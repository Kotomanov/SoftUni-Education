﻿namespace MusicHub
{
    using AutoMapper;
    using MusicHub.Data.Models;
    using MusicHub.DataProcessor.ImportDtos;
    using System;
    using System.Globalization;

    public class MusicHubProfile : Profile
    {
        // Configure your AutoMapper here if you wish to use it. If not, DO NOT DELETE THIS CLASS
        public MusicHubProfile()
        {
            
            this.CreateMap<SongImportDto, Song>()
                .ForMember(t => t.Duration, y => y.MapFrom(k => TimeSpan.ParseExact(k.Duration, @"hh\:mm\:ss", CultureInfo.InvariantCulture)))
                .ForMember(t => t.CreatedOn, y => y.MapFrom(k => DateTime.ParseExact(k.CreatedOn, @"dd/MM/yyyy", CultureInfo.InvariantCulture)));

            this.CreateMap<PerformerImportDto, Performer>();
            this.CreateMap<SongIdImportDto, SongPerformer>()
                .ForMember(t => t.SongId, y => y.MapFrom(k => k.Id));


        }
    }
}
