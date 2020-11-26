using Newtonsoft.Json;

namespace GoogleBookApp.Models
{
    public class FileType
    {
        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonProperty("acsTokenLink")]
        public string AcsTokenLink { get; set; }
    }
}
