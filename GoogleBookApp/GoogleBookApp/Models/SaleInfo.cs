using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace GoogleBookApp.Models
{
    public class SaleInfo
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("saleability")]
        public string Saleability { get; set; }

        [JsonPropertyName("isEbook")]
        public bool IsEbook { get; set; }
    }
}
