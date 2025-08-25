namespace VideoGameAPI.Model
{
    public class UserProfile
    {
        public Guid Id { get; set; }
        public Guid Client_Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public string? AvatarUrl { get; set; }
    }
}
