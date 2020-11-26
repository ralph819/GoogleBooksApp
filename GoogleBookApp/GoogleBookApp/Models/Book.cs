using Newtonsoft.Json;

namespace GoogleBookApp.Models
{
    /// <summary>
    /// Book Model with All Book Information.
    /// </summary>
    public class Book
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Book Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("selfLink")]
        public string SelfLink { get; set; }

        /// <summary>
        /// Book Volume Information.
        /// </summary>
        [JsonProperty("volumeInfo")]
        public VolumeInfo VolumeInformation { get; set; }

        /// <summary>
        /// Book Sale Information.
        /// </summary>
        [JsonProperty("saleInfo")]
        public SaleInfo SaleInformation { get; set; }

        /// <summary>
        /// Book Access Information
        /// </summary>
        [JsonProperty("accessInfo")]
        public AccessInfo AccessInformation { get; set; }

        [JsonProperty("searchInfo")]
        public SearchInfo SearchInformation { get; set; }
    }
}
