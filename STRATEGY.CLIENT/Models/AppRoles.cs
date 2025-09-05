using System.ComponentModel.DataAnnotations;

namespace STRATEGY.CLIENT.Models
{
    public class AppRoles
    {
        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
