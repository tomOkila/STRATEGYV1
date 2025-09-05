using System.ComponentModel.DataAnnotations;

namespace STRATEGY.CLIENT.Models
{
    public class Pillar
    {
        [Key]
        public int PillarID { get; set; }
        public string PillarName { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; }
        public string PillarRecorder { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
