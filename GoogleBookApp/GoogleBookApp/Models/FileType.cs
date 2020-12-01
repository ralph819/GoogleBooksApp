using Newtonsoft.Json;

namespace GoogleBookApp.Models
{
    /// <summary>
    /// for Epub or Pdf Files information
    /// </summary>
    public class FileType
    {
        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonProperty("acsTokenLink")]
        public string AcsTokenLink { get; set; }

        [JsonProperty("downloadLink")]
        public string DownloadLink { get; set; }

        public string Link
        {
            get
            {
                string result = AcsTokenLink ?? DownloadLink;
                return IsAvailable ? result : string.Empty;
            }
        }
        public override string ToString()
        {
            return IsAvailable ? "Download" : "N/A";
        }
    }
}
