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
        public string? GameImageIconURL { get; set; }
        public string? GameBanerImageURL { get; set; }
        public List<string>? GameScreenShootImageURLs { get; set; }
        public string? GameLinkDownloadURL { get; set; }
    }
}
