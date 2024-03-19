using SQLite;

namespace CondoManager.App.Data.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique, NotNull, MaxLength(25)]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool KeepConnected { get; set; }
        public DateTime LastAccess { get; set; }
    }

    public class UserSession
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime LastAccess { get; set; }
    }
}