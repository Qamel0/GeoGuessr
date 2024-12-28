namespace SocialNetwork.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Context { get; set; } = null!;
        
        public int SenderId { get; set; }
        public User Sender { get; set; } = null!;

        public DateTime CreationTime { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletionTime { get; set; }
    }
}
