namespace Pollfirst.Models
{
    using System;

    public class NewsPlatformYouTube
    {
        public int Id { get; set; }  // int
        public string? YtId { get; set; }  // varchar(255), nullable
        public string? LeaderName { get; set; }  // nvarchar(500), nullable
        public string? Keyword { get; set; }  // nvarchar(255), nullable
        public string? Headline { get; set; }  // nvarchar(MAX), nullable
        public string? Description { get; set; }  // nvarchar(MAX), nullable
        public string? Title { get; set; }  // nvarchar(MAX), nullable
        public string? DatePublished { get; set; }  // varchar(255), nullable
        public string? ViewsPrecise { get; set; }  // varchar(255), nullable
        public string? ViewsSimple { get; set; }  // varchar(255), nullable
        public string? ViewsApproximate { get; set; }  // varchar(255), nullable
        public string? Thumbnail1 { get; set; }  // varchar(255), nullable
        public string? Thumbnail2 { get; set; }  // varchar(255), nullable
        public string? Link { get; set; }  // varchar(MAX), nullable
        public string? Likes { get; set; }  // varchar(MAX), nullable
    }
}
