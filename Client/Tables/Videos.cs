using System;
using System.Text.Json.Serialization;

namespace RadzenBlazorAzureStaticWebApp.Tables 
{
    public class Videos
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        public string? Channel { get; set; }
        public DateTime? Published { get; set; }
        public string? Duration { get; set; }
        public string? Url { get; set; }
    }
}