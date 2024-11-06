using Microsoft.EntityFrameworkCore;

namespace Pollfirst.Models
{
    public class NewsPlatformYouTubeContext : DbContext
    {
        public NewsPlatformYouTubeContext(DbContextOptions<NewsPlatformYouTubeContext> options)
            : base(options)
        {
        }

        public DbSet<NewsPlatformYouTube> NewsPlatformsYouTube { get; set; }  // Table representing YouTube articles

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewsPlatformYouTube>()
                .ToTable("tbl_news_platforms_youtube")  // Table name in the database
                .HasKey(e => e.Id);  // Set the primary key

            modelBuilder.Entity<NewsPlatformYouTube>()
                .Property(e => e.YtId)
                .HasColumnType("varchar(255)");  // Column type for yt_id

            modelBuilder.Entity<NewsPlatformYouTube>()
                .Property(e => e.LeaderName)
                .HasColumnType("nvarchar(500)");  // Column type for leader_name

            modelBuilder.Entity<NewsPlatformYouTube>()
                .Property(e => e.Keyword)
                .HasColumnType("nvarchar(255)");  // Column type for keyword

            modelBuilder.Entity<NewsPlatformYouTube>()
                .Property(e => e.Headline)
                .HasColumnType("nvarchar(MAX)");  // Column type for headline

            modelBuilder.Entity<NewsPlatformYouTube>()
                .Property(e => e.Description)
                .HasColumnType("nvarchar(MAX)");  // Column type for description

            modelBuilder.Entity<NewsPlatformYouTube>()
                .Property(e => e.Title)
                .HasColumnType("nvarchar(MAX)");  // Column type for title

            modelBuilder.Entity<NewsPlatformYouTube>()
                .Property(e => e.DatePublished)
                .HasColumnType("varchar(255)");  // Column type for date_published

            modelBuilder.Entity<NewsPlatformYouTube>()
                .Property(e => e.ViewsPrecise)
                .HasColumnType("varchar(255)");  // Column type for views_precise

            modelBuilder.Entity<NewsPlatformYouTube>()
                .Property(e => e.ViewsSimple)
                .HasColumnType("varchar(255)");  // Column type for views_simple

            modelBuilder.Entity<NewsPlatformYouTube>()
                .Property(e => e.ViewsApproximate)
                .HasColumnType("varchar(255)");  // Column type for views_approximate

            modelBuilder.Entity<NewsPlatformYouTube>()
                .Property(e => e.Thumbnail1)
                .HasColumnType("varchar(255)");  // Column type for thumbnail1

            modelBuilder.Entity<NewsPlatformYouTube>()
                .Property(e => e.Thumbnail2)
                .HasColumnType("varchar(255)");  // Column type for thumbnail2

            modelBuilder.Entity<NewsPlatformYouTube>()
                .Property(e => e.Link)
                .HasColumnType("varchar(MAX)");  // Column type for link

            modelBuilder.Entity<NewsPlatformYouTube>()
                .Property(e => e.Likes)
                .HasColumnType("varchar(MAX)");  // Column type for likes
        }
    }
}
