using Microsoft.EntityFrameworkCore;

namespace Pollfirst.Models
{
    public class InstagramPlatformContext : DbContext
    {
        public InstagramPlatformContext(DbContextOptions<InstagramPlatformContext> options) : base(options)
        {
        }

        // DbSet for Instagram Platform Articles
        public DbSet<NewsPlatformInstagram> InstagramArticles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewsPlatformInstagram>(entity =>
            {
                entity.ToTable("tbl_news_platforms_instagram");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                      .HasColumnName("id");

                entity.Property(e => e.InstagramId)
                      .HasColumnName("instagram_id")
                      .HasMaxLength(int.MaxValue)
                      .IsUnicode(false);

                entity.Property(e => e.PublishedAt)
                      .HasColumnName("published_at");

                entity.Property(e => e.MediaType)
                      .HasColumnName("media_type");

                entity.Property(e => e.ProductType)
                      .HasColumnName("product_type")
                      .HasMaxLength(int.MaxValue);

                entity.Property(e => e.ThumbnailUrl)
                      .HasColumnName("thumbnail_url")
                      .HasMaxLength(int.MaxValue);

                entity.Property(e => e.Location)
                      .HasColumnName("location")
                      .HasMaxLength(int.MaxValue);

                entity.Property(e => e.CommentCount)
                      .HasColumnName("comment_count");

                entity.Property(e => e.CommentsDisabled)
                      .HasColumnName("comments_disabled");

                entity.Property(e => e.LikeCount)
                      .HasColumnName("like_count");

                entity.Property(e => e.PlayCount)
                      .HasColumnName("play_count");

                entity.Property(e => e.CaptionText)
                      .HasColumnName("caption_text")
                      .HasMaxLength(int.MaxValue);

                entity.Property(e => e.Usertags)
                      .HasColumnName("usertags")
                      .HasMaxLength(int.MaxValue);

                entity.Property(e => e.SponsorTags)
                      .HasColumnName("sponsor_tags")
                      .HasMaxLength(int.MaxValue);

                entity.Property(e => e.VideoUrl)
                      .HasColumnName("video_url")
                      .HasMaxLength(int.MaxValue);

                entity.Property(e => e.ViewCount)
                      .HasColumnName("view_count");

                entity.Property(e => e.VideoDuration)
                      .HasColumnName("video_duration");

                entity.Property(e => e.Title)
                      .HasColumnName("title")
                      .HasMaxLength(int.MaxValue);

                entity.Property(e => e.Resources)
                      .HasColumnName("resources")
                      .HasMaxLength(int.MaxValue);

                entity.Property(e => e.Keyword)
                      .HasColumnName("keyword")
                      .HasMaxLength(int.MaxValue);

                entity.Property(e => e.LeaderName)
                      .HasColumnName("leader_name")
                      .HasMaxLength(int.MaxValue);
            });
        }
    }
}
