using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace GoogleBookApp.Models
{
    public class ImageLinks
    {
        [JsonPropertyName("smallThumbnail")]
        public string SmallThumbnail { get; set; }

        [JsonPropertyName("thumbnail")]
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
