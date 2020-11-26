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
        public VolumeInformation VolumeInformation { get; set; }

        /// <summary>
        /// Book Sale Information.
        /// </summary>
        [JsonProperty("saleInfo")]
        public SaleInformation SaleInformation { get; set; }

        /// <summary>
        /// Book Access Information
        /// </summary>
        [JsonProperty("accessInfo")]
        public AccessInformation AccessInformation { get; set; }

        [JsonProperty("searchInfo")]
        public SearchInformation SearchInformation { get; set; }
    }
}
