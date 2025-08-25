namespace VideoGameAPI.Model
{
    public class VideoGame
    {
        public int Id { get; set; }
        public Guid Client_Id { get; set; }
        public string? Title { get; set; }
        public string? Platform { get; set; }
        public string? Developer { get; set; }
        public string? Publisher { get; set; }
        public string? GameImageURL { get; set; }
        public string? GameLinkDownloadURL { get; set; }
    }
}
