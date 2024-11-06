namespace Pollfirst.Models
{
    using System;

    public class NewsPlatformInstagram
    {
        public int Id { get; set; }
        public string? InstagramId { get; set; }
        public DateTime PublishedAt { get; set; }
        public int MediaType { get; set; }
        public string? ProductType { get; set; }
        public string? ThumbnailUrl { get; set; }
        public string? Location { get; set; }
        public int CommentCount { get; set; }
        public bool CommentsDisabled { get; set; }
        public int LikeCount { get; set; }
        public int PlayCount { get; set; }
        public string? CaptionText { get; set; }
        public string? Usertags { get; set; }
        public string? SponsorTags { get; set; }
        public string? VideoUrl { get; set; }
        public int ViewCount { get; set; }
        public int VideoDuration { get; set; }
        public string? Title { get; set; }
        public string? Resources { get; set; }
        public string? Keyword { get; set; }
        public string? LeaderName { get; set; }
    }
}
