using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace GoogleBookApp.Models
{
    public class PanelizationSummary
    {
        [JsonPropertyName("containsEpubBubbles")]
        public bool ContainsEpubBubbles { get; set; }

        [JsonPropertyName("containsImageBubbles")]
        public bool ContainsImageBubbles { get; set; }
    }
}
