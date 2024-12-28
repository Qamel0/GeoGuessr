using Microsoft.EntityFrameworkCore;
using SocialNetwork.Enums;
using SocialNetwork.Models;

namespace SocialNetwork.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        DbSet<User> Users { get; set; }
        DbSet<Message> Messages { get; set; }
        DbSet<Chat> Chats { get; set; }
        DbSet<Friendship> Friendships { get; set; }
        DbSet<ChatUser> ChatUsers { get; set; }
        DbSet<ChatMessage> ChatMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chat>()
                .Property(c => c.Type)
                .HasConversion(
                v => v.ToString(),
                v => (PublicityType)Enum.Parse(typeof(PublicityType), v));



            modelBuilder.Entity<Friendship>()
                .Property(f => f.Status)
                .HasConversion(
                v => v.ToString(),
                v => (Status)Enum.Parse(typeof(Status), v));

            modelBuilder.Entity<Friendship>()
                .HasOne(f => f.UserOne)
                .WithMany()
                .HasForeignKey(f => f.UserOneId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Friendship>()
                .HasOne(f => f.UserTwo)
                .WithMany()
                .HasForeignKey(f => f.UserTwoId)
                .OnDelete(DeleteBehavior.Cascade);



            modelBuilder.Entity<ChatUser>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChatUser>()
                .HasOne(c => c.Chat)
                .WithMany()
                .HasForeignKey(c => c.ChatId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChatUser>()
                .Property(c => c.Role)
                .HasConversion(
                v => v.ToString(),
                v => (Role)Enum.Parse(typeof(Role), v));


            modelBuilder.Entity<ChatMessage>()
                .HasKey(c => new { c.ChatId, c.MessageId });

            modelBuilder.Entity<ChatMessage>()
                .HasOne(c => c.Message)
                .WithMany()
                .HasForeignKey(c => c.MessageId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChatMessage>()
                .HasOne(c => c.Chat)
                .WithMany()
                .HasForeignKey(c => c.ChatId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
