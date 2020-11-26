using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace GoogleBookApp.Models
{
    public class ReadingModes
    {
        [JsonPropertyName("text")]
        public bool Text { get; set; }

        [JsonPropertyName("image")]
        public bool Image { get; set; }
    }
}
