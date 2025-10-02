using System.ComponentModel.DataAnnotations;

namespace STRATEGY.CLIENT.Models
{
    public class Permissions
    {
        [Key]
        public int PermissionId { get; set; }
        public string PermissionName { get; set; } = string.Empty;
        public int Create { get; set; }
        public int Update { get; set; }
        public int Delete { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
