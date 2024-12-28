using Microsoft.EntityFrameworkCore;

namespace SocialNetwork.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
