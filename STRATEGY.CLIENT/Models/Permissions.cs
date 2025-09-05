using System.ComponentModel.DataAnnotations;

namespace STRATEGY.CLIENT.Models
{
    public class Permissions
    {
        [Key]
        public int PermissionId { get; set; }
        public string PermissionName { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
