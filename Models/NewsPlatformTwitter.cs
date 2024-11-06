namespace Pollfirst.Models
{
    using System;

    public class NewsPlatformTwitter
    {
        public long Id { get; set; }
        public string? LeaderName { get; set; }
        public string? Keyword { get; set; }
        public string? Url { get; set; }
        public string? Headline { get; set; }
        public string? Description { get; set; }
        public string? CreatedAt { get; set; }  // Stored as varchar(100)
        public string? Users { get; set; }
        public string? Text { get; set; }
        public string? Lang { get; set; }
        public long? InReplyTo { get; set; }
        public bool? IsQuoteStatus { get; set; }
        public string? Quote { get; set; }
        public string? RetweetedTweet { get; set; }
        public bool? PossiblySensitive { get; set; }
        public bool? PossiblySensitiveEditable { get; set; }
        public int? QuoteCount { get; set; }
        public string? Media { get; set; }
        public int? ReplyCount { get; set; }
        public int? FavoriteCount { get; set; }
        public int? ViewCount { get; set; }
        public int? RetweetCount { get; set; }
        public long? EditableUntilMsecs { get; set; }
        public bool? IsTranslatable { get; set; }
        public string? Hashtags { get; set; }
        public string? FullText { get; set; }
        public string? DatePublished { get; set; }  // Stored as varchar(MAX)
        public DateTime? PublishedAt { get; set; }
    }
}
