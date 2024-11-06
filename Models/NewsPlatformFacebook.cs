namespace Pollfirst.Models
{
    using System;

    public class NewsPlatformFacebook
    {
        public long Id { get; set; }
        public string? LeaderName { get; set; }  // nvarchar(MAX)
        public string? Keyword { get; set; }  // nvarchar(MAX)
        public string? Url { get; set; }  // nvarchar(MAX)
        public string? Headline { get; set; }  // nvarchar(MAX)
        public string? Description { get; set; }  // nvarchar(MAX)
        public string? Author { get; set; }  // nvarchar(MAX)
        public string? DatePublished { get; set; }  // nvarchar(MAX)
        public string? Views { get; set; }  // nvarchar(MAX)
        public string? Comments { get; set; }  // nvarchar(MAX)
        public string? Likes { get; set; }  // nvarchar(MAX)
        public string? Shares { get; set; }  // nvarchar(MAX)
        public string? Link { get; set; }  // nvarchar(MAX)
        public string? Text { get; set; }  // nvarchar(MAX)
        public string? PublishedAt { get; set; }  // nvarchar(MAX)
        public string? Images { get; set; }  // nvarchar(MAX)
        public string? ExternalLinks { get; set; }  // nvarchar(MAX)
    }
}
