using SocialNetwork.Enums;

namespace SocialNetwork.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public PublicityType Type { get; set; }
        public DateTime CreationTime { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletionTime { get; set; }
    }
}
