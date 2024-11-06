namespace Pollfirst.Models
{
    public class NewsPlatformArchive
    {
        public int Id { get; set; } // Primary key, not nullable

        public string? LeaderName { get; set; } // Nullable, optional field

        public string? Keyword { get; set; } // Nullable, optional field

        public string? Url { get; set; } // Nullable, optional field

        public string? Headline { get; set; } // Nullable, optional field

        public string? Description { get; set; } // Nullable, optional field

        public string? UserId { get; set; } // Nullable, optional field

        public string? NewsId { get; set; } // Nullable, optional field
    }
}
