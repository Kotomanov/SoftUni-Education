﻿namespace EGovernment.Web.ViewModels.AppViewModels.VideoViewModels
{
    using System.Text.RegularExpressions;

    public class YouTubeVideoViewModel
    {
        public string Link { get; set; }

        public string IFrameSource
        {
            get
            {
                if (this.Link.Contains("youtube"))
                {
                    var regex = new Regex(@"youtu(?:\.be|be\.com)/(?:(.*)v(/|=)|(.*/)?)(?<id>[a-zA-Z0-9-_]+)", RegexOptions.IgnoreCase);

                    var videoId = regex.Match(this.Link).Groups["id"];

                    return $"https://www.youtube.com/embed/{videoId}";
                }
                else
                {
                    return this.Link;
                }
            }
        }
    }
}
