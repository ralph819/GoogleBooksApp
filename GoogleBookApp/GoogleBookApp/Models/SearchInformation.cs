using Newtonsoft.Json;

namespace GoogleBookApp.Models
{
    public class SearchInformation
    {
        [JsonProperty("textSnippet")]
        public string TextSnippet { get; set; }
    }
}
