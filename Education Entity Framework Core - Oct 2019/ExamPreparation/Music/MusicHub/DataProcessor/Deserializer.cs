namespace MusicHub.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using MusicHub.Data.Models;
    using MusicHub.Data.Models.Enums;
    using MusicHub.DataProcessor.ImportDtos;
    using Newtonsoft.Json;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data";

        private const string SuccessfullyImportedWriter
            = "Imported {0}";
        private const string SuccessfullyImportedProducerWithPhone
            = "Imported {0} with phone: {1} produces {2} albums";
        private const string SuccessfullyImportedProducerWithNoPhone
            = "Imported {0} with no phone number produces {1} albums";
        private const string SuccessfullyImportedSong
            = "Imported {0} ({1} genre) with duration {2}";
        private const string SuccessfullyImportedPerformer
            = "Imported {0} ({1} songs)";

        public static string ImportWriters(MusicHubDbContext context, string jsonString)
        {

            var writersDto = JsonConvert.DeserializeObject<WritersImportDto[]>(jsonString);

            var sb = new StringBuilder();
            var validWriters = new List<Writer>();

            foreach (var item in writersDto)
            {
                if (!IsValid(item))
                {
                    sb.AppendLine(ErrorMessage);
                }

                else
                {
                    Writer writer = new Writer()
                    {
                        Name = item.Name,
                        Pseudonym = item.Pseudonym
                    };

                    validWriters.Add(writer);
                    sb.AppendLine(String.Format(SuccessfullyImportedWriter, item.Name));

                }
            }

            context.Writers.AddRange(validWriters);
            context.SaveChanges();

            return sb.ToString().TrimEnd();

        }

        public static string ImportProducersAlbums(MusicHubDbContext context, string jsonString)
        {

            var producersDto = JsonConvert.DeserializeObject<ProducersAlbumsImportDto[]>(jsonString);

            var sb = new StringBuilder();
            var validProducers = new List<Producer>();
            var validAlbums = new List<Album>();

            foreach (var item in producersDto)

                if (!IsValid(item) || !item.Albums.All(IsValid))
                {
                    sb.AppendLine(ErrorMessage);
                }

                else
                {
                    if (item.PhoneNumber == null)
                    {
                        Producer producer = new Producer()
                        {
                            Name = item.Name,
                            Pseudonym = item.Pseudonym,
                        };

                        validProducers.Add(producer);

                        foreach (var a in item.Albums)
                        {
                            Album album = new Album()
                            {
                                Name = a.Name,
                                ReleaseDate = DateTime.ParseExact(a.ReleaseDate, "dd/MM/yyyy", CultureInfo.InvariantCulture)

                            };

                            validAlbums.Add(album);
                        }

                        sb.AppendLine(String.Format(SuccessfullyImportedProducerWithNoPhone, producer.Name, item.Albums.Length));

                    }

                    else
                    {
                        Producer producer = new Producer()
                        {
                            Name = item.Name,
                            Pseudonym = item.Pseudonym,
                            PhoneNumber = item.PhoneNumber

                        };

                        validProducers.Add(producer);

                        foreach (var a in item.Albums)
                        {
                            Album album = new Album()
                            {
                                Name = a.Name,
                                ReleaseDate = DateTime.ParseExact(a.ReleaseDate, "dd/MM/yyyy", CultureInfo.InvariantCulture)


                            };

                            validAlbums.Add(album);
                        }

                        sb.AppendLine(String.Format(SuccessfullyImportedProducerWithPhone, producer.Name, producer.PhoneNumber, item.Albums.Length));
                    }


                }

            context.Producers.AddRange(validProducers);
            context.Albums.AddRange(validAlbums);
            context.SaveChanges();

            return sb.ToString().TrimEnd();

        }


        public static string ImportSongs(MusicHubDbContext context, string xmlString)
        {

            var xmlSerializer = new XmlSerializer(typeof(SongImportDto[]), new XmlRootAttribute("Songs"));
            var songDtos = (SongImportDto[])xmlSerializer.Deserialize(new StringReader(xmlString));

            var sb = new StringBuilder();
            var validSongs = new List<Song>();

            foreach (var song in songDtos)
            {
                if (!IsValid(song))
                {
                    sb.AppendLine(ErrorMessage);
                }

                else
                {
                    var genre = Enum.TryParse(song.Genre, out Genre genreResult);
                    var albumId = context.Albums.Any(a => a.Id == song.AlbumId);
                    var writerId = context.Writers.Any(w => w.Id == song.WriterId);
                    var songName = context.Songs.Any(s => s.Name == song.Name);

                    if (!genre || !albumId || !writerId || songName)
                    {
                        sb.AppendLine(ErrorMessage);
                    }

                    else
                    {

                        Song mappedSongs = AutoMapper.Mapper.Map<Song>(song);

                        validSongs.Add(mappedSongs);

                        sb.AppendLine(String.Format(SuccessfullyImportedSong, song.Name, song.Genre, song.Duration));

                    }

                }
            }

            context.Songs.AddRange(validSongs);
            context.SaveChanges();

            return sb.ToString().TrimEnd();

        }

        public static string ImportSongPerformers(MusicHubDbContext context, string xmlString)
        {

            var xmlSerializer = new XmlSerializer(typeof(PerformerImportDto[]), new XmlRootAttribute("Performers"));
            var songDtos = (PerformerImportDto[])xmlSerializer.Deserialize(new StringReader(xmlString));

            var sb = new StringBuilder();
            
            List<Performer> performersList = new List<Performer>();

            foreach (var songDto in songDtos)
            {
                if (!IsValid(songDto))  
                {
                    sb.AppendLine(ErrorMessage);
                }

                else
                {
                    int songsCount = context.Songs.Count(s => songDto.SongsList.Any(i => s.Id == i.Id));

                    if (songsCount != songDto.SongsList.Count())
                    {
                        sb.AppendLine(ErrorMessage);
                    }

                    else
                    {
                        var performer = AutoMapper.Mapper.Map<Performer>(songDto);
                        performersList.Add(performer);
                        sb.AppendLine(String.Format(SuccessfullyImportedPerformer, songDto.FirstName, songDto.SongsList.Length));
                    }
                }
            }

            context.Performers.AddRange(performersList);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        // Validator 

        private static bool IsValid(object entity)
        {
            var validationContext = new ValidationContext(entity);
            var validationResult = new List<ValidationResult>();

            var result = Validator.TryValidateObject(entity, validationContext, validationResult, true);

            return result;
        }
    }


}

