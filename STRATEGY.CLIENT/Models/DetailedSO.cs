using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace STRATEGY.CLIENT.Models
{
    public class DetailedSO
    {
        [Key]
        public int DetailedId { get; set; }
        public string DetailedTargetName { get; set; } = string.Empty;
        public string DetailedTargetHistory { get; set; } = string.Empty;
        public string DetailedScorerName { get; set; } = string.Empty;
        public int SOId { get; set; }

        [ForeignKey(nameof(SOId))]
        public StrategicObjective? StrategicObjective { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
