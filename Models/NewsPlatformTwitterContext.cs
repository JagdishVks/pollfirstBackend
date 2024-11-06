using Microsoft.EntityFrameworkCore;

namespace Pollfirst.Models
{
    public class NewsPlatformTwitterContext : DbContext
    {
        public NewsPlatformTwitterContext(DbContextOptions<NewsPlatformTwitterContext> options)
            : base(options)
        {
        }

        public DbSet<NewsPlatformTwitter> NewsPlatformsTwitter { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewsPlatformTwitter>(entity =>
            {
                entity.ToTable("tbl_news_platforms_twitter");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.LeaderName).HasColumnName("leader_name").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Keyword).HasColumnName("keyword").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Url).HasColumnName("url").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Headline).HasColumnName("headline").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Description).HasColumnName("description").HasMaxLength(int.MaxValue);
                entity.Property(e => e.CreatedAt).HasColumnName("created_at").HasMaxLength(100);  // varchar(100)
                entity.Property(e => e.Users).HasColumnName("users").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Text).HasColumnName("text").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Lang).HasColumnName("lang").HasMaxLength(50);  // varchar(50)
                entity.Property(e => e.InReplyTo).HasColumnName("in_reply_to");
                entity.Property(e => e.IsQuoteStatus).HasColumnName("is_quote_status");
                entity.Property(e => e.Quote).HasColumnName("quote").HasMaxLength(int.MaxValue);
                entity.Property(e => e.RetweetedTweet).HasColumnName("retweeted_tweet").HasMaxLength(int.MaxValue);
                entity.Property(e => e.PossiblySensitive).HasColumnName("possibly_sensitive");
                entity.Property(e => e.PossiblySensitiveEditable).HasColumnName("possibly_sensitive_editable");
                entity.Property(e => e.QuoteCount).HasColumnName("quote_count");
                entity.Property(e => e.Media).HasColumnName("media").HasMaxLength(int.MaxValue);
                entity.Property(e => e.ReplyCount).HasColumnName("reply_count");
                entity.Property(e => e.FavoriteCount).HasColumnName("favorite_count");
                entity.Property(e => e.ViewCount).HasColumnName("view_count");
                entity.Property(e => e.RetweetCount).HasColumnName("retweet_count");
                entity.Property(e => e.EditableUntilMsecs).HasColumnName("editable_until_msecs");
                entity.Property(e => e.IsTranslatable).HasColumnName("is_translatable");
                entity.Property(e => e.Hashtags).HasColumnName("hashtags").HasMaxLength(int.MaxValue);
                entity.Property(e => e.FullText).HasColumnName("full_text").HasMaxLength(int.MaxValue);
                entity.Property(e => e.DatePublished).HasColumnName("date_published").HasMaxLength(int.MaxValue);  // varchar(MAX)
                entity.Property(e => e.PublishedAt).HasColumnName("published_at").HasColumnType("datetime");
            });
        }
    }
}
