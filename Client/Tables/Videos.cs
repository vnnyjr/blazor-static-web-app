using System;
using System.Text.Json.Serialization;

namespace RadzenBlazorAzureStaticWebApp.Tables 
{
        public class Thumbnail
    {
        public ThumbnailUrl? Default { get; set; }
        public ThumbnailUrl? Medium { get; set; }
        public ThumbnailUrl? High { get; set; }
        public ThumbnailUrl? Standard { get; set; }
        public ThumbnailUrl? Maxres { get; set; }
    }

    public class ThumbnailUrl
    {
        public string? Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
    public class Videos
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        public string? Channel { get; set; }
        public DateTime? Published { get; set; }
        public string? Duration { get; set; }
        public string? Url { get; set; }
        public Thumbnail? Thumbnail { get; set; }
    }
}