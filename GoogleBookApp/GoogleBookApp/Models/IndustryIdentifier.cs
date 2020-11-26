using Newtonsoft.Json;

namespace GoogleBookApp.Models
{
    public class IndustryIdentifier
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }
    }
}
