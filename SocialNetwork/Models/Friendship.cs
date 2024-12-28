using SocialNetwork.Enums;

namespace SocialNetwork.Models
{
    public class Friendship
    {
        public int Id { get; set; }

        public int UserOneId { get; set; }
        public User UserOne { get; set; } = null!;

        public int UserTwoId { get; set; }
        public User UserTwo { get; set; } = null!;

        public Status Status { get; set; }

        public DateTime? AcceptanceDate { get; set; }
    }
}
