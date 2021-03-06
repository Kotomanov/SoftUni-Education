﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MusicHub.DataProcessor.ImportDtos
{
    [XmlType("Song")]
    public class ExportSongDto
    {
        [XmlElement("SongName")]
        public string Name { get; set; }

        [XmlElement("Writer")]
        public string Writer { get; set; }

        [XmlElement("Performer")]
        public string Performer { get; set; }

        [XmlElement("AlbumProducer")]
        public string Producer { get; set; } // ?

        [XmlElement("Duration")]
        public string Duration { get; set; } //???
    }
}
