﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace GoogleBookApp.Models
{
    public class IndustryIdentifier
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }
    }

    public class ReadingModes
    {
        [JsonPropertyName("text")]
        public bool Text { get; set; }

        [JsonPropertyName("image")]
        public bool Image { get; set; }
    }

    public class ImageLinks
    {
        [JsonPropertyName("smallThumbnail")]
        public string SmallThumbnail { get; set; }

        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; }

        public Uri ThumbnailUri
        {
            get
            {
                return new Uri(this.Thumbnail);
            }
        }
    }

    public class PanelizationSummary
    {
        [JsonPropertyName("containsEpubBubbles")]
        public bool ContainsEpubBubbles { get; set; }

        [JsonPropertyName("containsImageBubbles")]
        public bool ContainsImageBubbles { get; set; }
    }

    public class VolumeInfo
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }

        [JsonPropertyName("industryIdentifiers")]
        public List<IndustryIdentifier> IndustryIdentifiers { get; set; }

        [JsonPropertyName("readingModes")]
        public ReadingModes ReadingModes { get; set; }

        [JsonPropertyName("printType")]
        public string PrintType { get; set; }

        [JsonPropertyName("averageRating")]
        public double AverageRating { get; set; }

        [JsonPropertyName("ratingsCount")]
        public int RatingsCount { get; set; }

        [JsonPropertyName("maturityRating")]
        public string MaturityRating { get; set; }

        [JsonPropertyName("allowAnonLogging")]
        public bool AllowAnonLogging { get; set; }

        [JsonPropertyName("contentVersion")]
        public string ContentVersion { get; set; }

        [JsonPropertyName("imageLinks")]
        public ImageLinks ImageLinks { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("previewLink")]
        public string PreviewLink { get; set; }

        [JsonPropertyName("infoLink")]
        public string InfoLink { get; set; }

        [JsonPropertyName("canonicalVolumeLink")]
        public string CanonicalVolumeLink { get; set; }

        [JsonPropertyName("authors")]
        public List<string> Authors { get; set; }

        public string AuthorsFormated
        {
            get
            {
                return string.Join(", ", Authors);
            }
        }

        [JsonPropertyName("publishedDate")]
        public string PublishedDate { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("pageCount")]
        public int? PageCount { get; set; }

        [JsonPropertyName("categories")]
        public List<string> Categories { get; set; }

        [JsonPropertyName("panelizationSummary")]
        public PanelizationSummary PanelizationSummary { get; set; }
    }

    public class SaleInfo
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("saleability")]
        public string Saleability { get; set; }

        [JsonPropertyName("isEbook")]
        public bool IsEbook { get; set; }
    }

    public class Epub
    {
        [JsonPropertyName("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonPropertyName("acsTokenLink")]
        public string AcsTokenLink { get; set; }
    }

    public class Pdf
    {
        [JsonPropertyName("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonPropertyName("acsTokenLink")]
        public string AcsTokenLink { get; set; }
    }

    public class AccessInfo
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("viewability")]
        public string Viewability { get; set; }

        [JsonPropertyName("embeddable")]
        public bool Embeddable { get; set; }

        [JsonPropertyName("publicDomain")]
        public bool PublicDomain { get; set; }

        [JsonPropertyName("textToSpeechPermission")]
        public string TextToSpeechPermission { get; set; }

        [JsonPropertyName("epub")]
        public Epub Epub { get; set; }

        [JsonPropertyName("pdf")]
        public Pdf Pdf { get; set; }

        [JsonPropertyName("webReaderLink")]
        public string WebReaderLink { get; set; }

        [JsonPropertyName("accessViewStatus")]
        public string AccessViewStatus { get; set; }

        [JsonPropertyName("quoteSharingAllowed")]
        public bool QuoteSharingAllowed { get; set; }
    }

    public class SearchInfo
    {
        [JsonPropertyName("textSnippet")]
        public string TextSnippet { get; set; }
    }

    public class Book
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("etag")]
        public string Etag { get; set; }

        [JsonPropertyName("selfLink")]
        public string SelfLink { get; set; }

        [JsonPropertyName("volumeInfo")]
        public VolumeInfo VolumeInfo { get; set; }

        [JsonPropertyName("saleInfo")]
        public SaleInfo SaleInfo { get; set; }

        [JsonPropertyName("accessInfo")]
        public AccessInfo AccessInfo { get; set; }

        [JsonPropertyName("searchInfo")]
        public SearchInfo SearchInfo { get; set; }
    }

    public class BookResponse
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("totalItems")]
        public int TotalItems { get; set; }

        [JsonPropertyName("items")]
        public List<Book> Items { get; set; }
    }


}
