using Microsoft.EntityFrameworkCore;

namespace Pollfirst.Models
{
    public class NewsArticleContext : DbContext
    {
        public NewsArticleContext(DbContextOptions<NewsArticleContext> options) : base(options) { }

        public DbSet<NewsArticle> NewsArticles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewsArticle>()
                .ToTable("tbl_news_platforms_articles")   // Map to your existing table
                .HasKey(n => n.Id);  // Set primary key

            // Optional: Define column mappings if necessary
            modelBuilder.Entity<NewsArticle>().Property(n => n.Id).HasColumnName("id");
            modelBuilder.Entity<NewsArticle>().Property(n => n.Publisher).HasColumnName("publisher");
            modelBuilder.Entity<NewsArticle>().Property(n => n.Url).HasColumnName("url");
            modelBuilder.Entity<NewsArticle>().Property(n => n.Headline).HasColumnName("headline");
            modelBuilder.Entity<NewsArticle>().Property(n => n.Description).HasColumnName("description");
            modelBuilder.Entity<NewsArticle>().Property(n => n.DatePublished).HasColumnName("date_published");
            modelBuilder.Entity<NewsArticle>().Property(n => n.Body).HasColumnName("body");
            modelBuilder.Entity<NewsArticle>().Property(n => n.Author).HasColumnName("author");
            modelBuilder.Entity<NewsArticle>().Property(n => n.Link).HasColumnName("link");
            modelBuilder.Entity<NewsArticle>().Property(n => n.Images).HasColumnName("images");
            modelBuilder.Entity<NewsArticle>().Property(n => n.FeaturedImage).HasColumnName("featured_image");
            modelBuilder.Entity<NewsArticle>().Property(n => n.Keyword).HasColumnName("keyword");
            modelBuilder.Entity<NewsArticle>().Property(n => n.LeaderName).HasColumnName("leader_name");
            modelBuilder.Entity<NewsArticle>().Property(n => n.PublishedAt).HasColumnName("published_at");
        }
        public async Task<List<NewsArticle>> GetArticlesByLeaderNameAsync(string leaderName)
        {
            return await NewsArticles
                .Where(article => article.LeaderName != null && article.LeaderName.Contains(leaderName))
                .OrderByDescending(article => article.PublishedAt)
                .ToListAsync();
        }
    }

}
