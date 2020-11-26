using Newtonsoft.Json;

namespace GoogleBookApp.Models
{
    public class PanelizationSummary
    {
        [JsonProperty("containsEpubBubbles")]
        public bool ContainsEpubBubbles { get; set; }

        [JsonProperty("containsImageBubbles")]
        public bool ContainsImageBubbles { get; set; }
    }
}
