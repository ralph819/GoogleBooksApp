using Newtonsoft.Json;
using System;

namespace GoogleBookApp.Models
{
    public class ImageLinks
    {
        [JsonProperty("smallThumbnail")]
        public string SmallThumbnail { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        public Uri ThumbnailUri
        {
            get
            {
                return new Uri(this.Thumbnail);
            }
        }
    }
}
