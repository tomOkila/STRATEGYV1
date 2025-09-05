using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STRATEGY.CLIENT.Models
{
    public class StrategicPlan
    {
        [Key]
        public int StrategicPlanID { get; set; }
        public string StrategicPlanName { get; set; } = string.Empty;
        public int PillarID { get; set; }
        public int SOId { get; set; }
        public int DetailedId { get; set; }
        public int ProgramScheduleId { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
