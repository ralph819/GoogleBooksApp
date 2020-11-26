using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace GoogleBookApp.Models
{
    public class SearchInfo
    {
        [JsonPropertyName("textSnippet")]
        public string TextSnippet { get; set; }
    }
}
