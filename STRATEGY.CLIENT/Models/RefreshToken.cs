using System.ComponentModel.DataAnnotations;

namespace STRATEGY.CLIENT.Models
{
    public class RefreshToken
    {
        [Key]
        public int Id { get; set; }
        public string UserID { get; set; } = string.Empty;
        public string? Token { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
