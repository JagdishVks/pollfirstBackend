using Microsoft.EntityFrameworkCore;

namespace Pollfirst.Models
{
    public class NewsPlatformFacebookContext : DbContext
    {
        public NewsPlatformFacebookContext(DbContextOptions<NewsPlatformFacebookContext> options) : base(options)
        {
        }

        public DbSet<NewsPlatformFacebook> NewsPlatformsFacebook { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewsPlatformFacebook>(entity =>
            {
                entity.ToTable("tbl_news_platforms_facebook");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.LeaderName).HasColumnName("leader_name").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Keyword).HasColumnName("keyword").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Url).HasColumnName("url").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Headline).HasColumnName("headline").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Description).HasColumnName("description").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Author).HasColumnName("author").HasMaxLength(int.MaxValue);
                entity.Property(e => e.DatePublished).HasColumnName("date_published").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Views).HasColumnName("views").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Comments).HasColumnName("comments").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Likes).HasColumnName("likes").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Shares).HasColumnName("shares").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Link).HasColumnName("link").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Text).HasColumnName("text").HasMaxLength(int.MaxValue);
                entity.Property(e => e.PublishedAt).HasColumnName("published_at").HasMaxLength(int.MaxValue);
                entity.Property(e => e.Images).HasColumnName("images").HasMaxLength(int.MaxValue);
                entity.Property(e => e.ExternalLinks).HasColumnName("external_links").HasMaxLength(int.MaxValue);
            });
        }
    }
}
