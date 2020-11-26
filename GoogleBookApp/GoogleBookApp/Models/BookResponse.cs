using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleBookApp.Models
{
    /// <summary>
    /// Google Api Books Response
    /// </summary>
    public class BookResponse
    {
        /// <summary>
        /// Entity Filters for Google Api items
        /// </summary>
        [JsonProperty("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Count of Book by query titles
        /// </summary>
        [JsonProperty("totalItems")]
        public int TotalBooks { get; set; }

        /// <summary>
        /// List of Google Books Search by titles, and paginated.
        /// </summary>
        [JsonProperty("items")]
        public List<Book> Books { get; set; } = new List<Book>();
    }


}
