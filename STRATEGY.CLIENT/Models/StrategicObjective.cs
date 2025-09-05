using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace STRATEGY.CLIENT.Models
{
    public class StrategicObjective
    {
        [Key]
        public int SOId { get; set; }
        public string TargetName { get; set; } = string.Empty;
        public int PillarId { get; set; }

        [ForeignKey(nameof(PillarId))]
        public Pillar? Pillars { get; set; }
        public DateTime GoalScoreDate { get; set; }
        public string GoalScorerName { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
