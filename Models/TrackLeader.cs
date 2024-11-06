namespace Pollfirst.Models
{
    public class TrackLeader
    {
        public int Id { get; set; }
        public string? UserId { get; set; }           // nvarchar(500)
        public string? LeaderName { get; set; }       // nvarchar(500)
        public string? Keywords { get; set; }          // nvarchar(500)
        public string? HashTag { get; set; }           // nvarchar(500)
        public string? TwitterHandle { get; set; }     // nvarchar(500)
        public string? FacebookId { get; set; }        // nvarchar(500)
        public string? InstagramId { get; set; }       // nvarchar(500)
        public string? YoutubeId { get; set; }         // nvarchar(500)
        public string? FrequencyUpdate { get; set; }   // nvarchar(500)
        public DateTime? Timestamp { get; set; }       // datetime
        public string? IpAddress { get; set; }         // nvarchar(500)
    }
}

