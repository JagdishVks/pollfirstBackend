namespace Pollfirst.Models
{
    using System;

    public class NewsArticle
    {
        public int Id { get; set; }
        public string? Publisher { get; set; }
        public string? Url { get; set; }
        public string? Headline { get; set; }
        public string? Description { get; set; }
        public string? DatePublished { get; set; }  // Changed to string
        public string? Body { get; set; }
        public string? Author { get; set; }
        public string? Link { get; set; }
        public string? Images { get; set; }
        public string? FeaturedImage { get; set; }
        public string? Keyword { get; set; }
        public string? LeaderName { get; set; }
        public DateTime? PublishedAt { get; set; }
    }
}
