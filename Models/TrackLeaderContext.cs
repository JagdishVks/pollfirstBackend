using Microsoft.EntityFrameworkCore;

namespace Pollfirst.Models
{
    public class TrackLeaderContext : DbContext
    {
        public TrackLeaderContext(DbContextOptions<TrackLeaderContext> options) : base(options) { }

        public DbSet<TrackLeader> TrackLeaders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrackLeader>()
                .ToTable("tbl_track_leader")  // Map to your existing table
                .HasKey(t => t.Id);           // Set primary key

            // Define column mappings
            modelBuilder.Entity<TrackLeader>().Property(t => t.Id).HasColumnName("id");
            modelBuilder.Entity<TrackLeader>().Property(t => t.UserId).HasColumnName("user_id");
            modelBuilder.Entity<TrackLeader>().Property(t => t.LeaderName).HasColumnName("leader_name");
            modelBuilder.Entity<TrackLeader>().Property(t => t.Keywords).HasColumnName("keywords");
            modelBuilder.Entity<TrackLeader>().Property(t => t.HashTag).HasColumnName("hsh_tag");
            modelBuilder.Entity<TrackLeader>().Property(t => t.TwitterHandle).HasColumnName("twiter_handle");
            modelBuilder.Entity<TrackLeader>().Property(t => t.FacebookId).HasColumnName("facebook_id");
            modelBuilder.Entity<TrackLeader>().Property(t => t.InstagramId).HasColumnName("instagram_id");
            modelBuilder.Entity<TrackLeader>().Property(t => t.YoutubeId).HasColumnName("youtube_id");
            modelBuilder.Entity<TrackLeader>().Property(t => t.FrequencyUpdate).HasColumnName("frequency_update");
            modelBuilder.Entity<TrackLeader>().Property(t => t.Timestamp).HasColumnName("timestamp");
            modelBuilder.Entity<TrackLeader>().Property(t => t.IpAddress).HasColumnName("ip_address");
        }
    }
}

