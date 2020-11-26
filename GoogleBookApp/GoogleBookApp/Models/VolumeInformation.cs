using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace GoogleBookApp.Models
{
    public class VolumeInformation
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("industryIdentifiers")]
        public List<IndustryIdentifier> IndustryIdentifiers { get; set; } = new List<IndustryIdentifier>();

        [JsonProperty("readingModes")]
        public ReadingModes ReadingModes { get; set; }

        [JsonProperty("printType")]
        public string PrintType { get; set; }

        [JsonProperty("averageRating")]
        public double AverageRating { get; set; }

        [JsonProperty("ratingsCount")]
        public int RatingsCount { get; set; }

        [JsonProperty("maturityRating")]
        public string MaturityRating { get; set; }

        [JsonProperty("allowAnonLogging")]
        public bool AllowAnonLogging { get; set; }

        [JsonProperty("contentVersion")]
        public string ContentVersion { get; set; }

        [JsonProperty("imageLinks")]
        public ImageLinks ImageLinks { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("previewLink")]
        public string PreviewLink { get; set; }

        [JsonProperty("infoLink")]
        public string InfoLink { get; set; }

        [JsonProperty("canonicalVolumeLink")]
        public string CanonicalVolumeLink { get; set; }

        [JsonProperty("authors")]
        public List<string> Authors { get; set; }

        public string AuthorsFormated
        {
            get
            {
                if (Authors != null && Authors.Any())
                    return string.Join(", ", Authors);
                else
                    return "N/A";
            }
        }

        [JsonProperty("publishedDate")]
        public string PublishedDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("pageCount")]
        public int? PageCount { get; set; }

        [JsonProperty("categories")]
        public List<string> Categories { get; set; } = new List<string>();

        [JsonProperty("panelizationSummary")]
        public PanelizationSummary PanelizationSummary { get; set; }
    }
}
