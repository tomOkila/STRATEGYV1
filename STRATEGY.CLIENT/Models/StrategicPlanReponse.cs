namespace STRATEGY.CLIENT.Models
{
    public class StrategicPlanReponse
    {
        public int StrategicPlanID { get; set; }
        public string StrategicPlanName { get; set; } = string.Empty;
        public int PillarID { get; set; }
        public string PillarName { get; set; } = string.Empty;
        public int SOId { get; set; }
        public string TargetName { get; set; } = string.Empty;
        public int DetailedId { get; set; }
        public string DetailedTargetName { get; set; } = string.Empty;
        public int ProgramScheduleId { get; set; }
        public string ProgramRegistrarName { get; set; } = string.Empty;

    }
}
