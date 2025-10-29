using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STRATEGY.CLIENT.Models
{
    public class Plan
    {
        [Key]
        public int PlanID { get; set; }
        public string UserName { get; set; } = string.Empty;
        public int DepartmentID { get; set; }
        public int PillarID { get; set; }
        public int SOId { get; set; }
        public int DetailedId { get; set; }
        public int ProgramScheduleId { get; set; }
        public string Witness { get; set; } = string.Empty;

        public string StraKeyPerfIndicators { get; set; } = string.Empty;
        public string KeyPerfIndicatorsEvaluation { get; set; } = string.Empty;
        public string TargetGroup { get; set; } = string.Empty;
        public string Targeted { get; set; } = string.Empty;
        public string ActualPerformance { get; set; } = string.Empty;
        public string ActImpSteps { get; set; } = string.Empty;
        public string ExeActivityAnalysis { get; set; } = string.Empty;
        public string EntityResponsible { get; set; } = string.Empty;
        public string PartParties { get; set; } = string.Empty;
        public DateTime ImpStartDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public decimal ProposedCost { get; set; }
        public decimal EstimatedCost { get; set; }
        public decimal ActualCost { get; set; }
        public int InitiativeStatus { get; set; }
        public string Evidence { get; set; } = string.Empty;
        public string WitnessDetail { get; set; } = string.Empty;
        public string SectionComment { get; set; } = string.Empty;
        public string TeamComment { get; set; } = string.Empty;
        public string SupervisorReview { get; set; } = string.Empty;
        public bool StrategicObjectivesVisibility { get; set; }
        public bool DetailedStrategicObjectivesVisibility { get; set; }

        public DateTime CreateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
