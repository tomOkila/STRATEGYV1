using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace STRATEGY.CLIENT.Models
{
    public class ProgramSchedule
    {
        [Key]
        public int ProgramScheduleId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string ProgramRegistrarName { get; set; } = string.Empty;
        public int DetailedId { get; set; }

        [ForeignKey(nameof(DetailedId))]
        public DetailedSO? DetailedSO { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
