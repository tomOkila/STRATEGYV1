namespace STRATEGY.CLIENT.Models
{
    public class PlanResponse
    {
        public int PlanID { get; set; }
        public string UserName { get; set; } = string.Empty;
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public int PillarID { get; set; }
        public string PillarName { get; set; } = string.Empty;
        public int SOId { get; set; }
        public string TargetName { get; set; } = string.Empty;
        public int DetailedId { get; set; }
        public string DetailedTargetName { get; set; } = string.Empty;
        public int ProgramScheduleId { get; set; }
        public string ProgramRegistrarName { get; set; } = string.Empty;
        public string Witness { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
