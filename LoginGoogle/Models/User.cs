namespace LoginGoogle.Models
{
    public class User
    {
        public Guid UserId { get; set; } = new Guid();
        public string Email { get; set; }
        public string? Password { get; set; }
        public string Name { get; set; }
    }
}
