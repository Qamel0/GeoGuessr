namespace SocialNetwork.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nickname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool EmailConfirmed { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletionTime { get; set; }
    }
}
