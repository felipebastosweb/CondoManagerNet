
namespace CondoManager.Api.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public string? Telephone { get; set; }
        public bool KeepConnected { get; set; }
        public DateTime LastAccess { get; set; }
    }
}