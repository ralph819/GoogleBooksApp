using Newtonsoft.Json;

namespace GoogleBookApp.Models
{
    public class SearchInfo
    {
        [JsonProperty("textSnippet")]
        public string TextSnippet { get; set; }
    }
}
