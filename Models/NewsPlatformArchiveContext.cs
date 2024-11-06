using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pollfirst.Models
{
    public class NewsPlatformArchiveContext : DbContext
    {
        public NewsPlatformArchiveContext(DbContextOptions<NewsPlatformArchiveContext> options) : base(options) { }

        // Define DbSet for the NewsPlatformArchive table
        public DbSet<NewsPlatformArchive> NewsPlatformArchives { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewsPlatformArchive>()
                .ToTable("tbl_news_platforms_archives")   // Map to your existing table
                .HasKey(n => n.Id);  // Set primary key

            // Optional: Define column mappings if necessary
            modelBuilder.Entity<NewsPlatformArchive>().Property(n => n.Id).HasColumnName("id");
            modelBuilder.Entity<NewsPlatformArchive>().Property(n => n.LeaderName).HasColumnName("leader_name");
            modelBuilder.Entity<NewsPlatformArchive>().Property(n => n.Keyword).HasColumnName("keyword");
            modelBuilder.Entity<NewsPlatformArchive>().Property(n => n.Url).HasColumnName("url");
            modelBuilder.Entity<NewsPlatformArchive>().Property(n => n.Headline).HasColumnName("headline");
            modelBuilder.Entity<NewsPlatformArchive>().Property(n => n.Description).HasColumnName("description");
            modelBuilder.Entity<NewsPlatformArchive>().Property(n => n.UserId).HasColumnName("user_id");
            modelBuilder.Entity<NewsPlatformArchive>().Property(n => n.NewsId).HasColumnName("news_id");
        }

        // Example method to fetch archives by leader name
        public async Task<List<NewsPlatformArchive>> GetArchivesByLeaderNameAsync(string leaderName)
        {
            return await NewsPlatformArchives
                .Where(archive => archive.LeaderName != null && archive.LeaderName.Contains(leaderName))
                .OrderByDescending(archive => archive.Id) // Assuming you want to order by Id or other fields
                .ToListAsync();
        }
    }
}
