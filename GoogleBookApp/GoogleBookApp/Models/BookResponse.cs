using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace GoogleBookApp.Models
{
    public class BookResponse
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("totalItems")]
        public int TotalItems { get; set; }

        [JsonPropertyName("items")]
        public List<Book> Items { get; set; } = new List<Book>();
    }


}
