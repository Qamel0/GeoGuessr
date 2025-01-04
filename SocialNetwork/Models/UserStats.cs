using System.ComponentModel.DataAnnotations;

namespace GeoGuessr.Models
{
    public class UserStats
    {
        [Key]
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int RecordDistance;

    }
}
