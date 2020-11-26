using Newtonsoft.Json;

namespace GoogleBookApp.Models
{
    public class ReadingModes
    {
        [JsonProperty("text")]
        public bool Text { get; set; }

        [JsonProperty("image")]
        public bool Image { get; set; }
    }
}
