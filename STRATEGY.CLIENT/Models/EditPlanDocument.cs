namespace STRATEGY.CLIENT.Models
{
    public class EditPlanDocument
    {
        public int PlanID { get; set; }
        public string UserName { get; set; } = string.Empty;
        public int DepartmentID { get; set; }
        public int PillarID { get; set; }
        public int SOId { get; set; }
        public int DetailedId { get; set; }
        public int ProgramScheduleId { get; set; }
        public string Witness { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
