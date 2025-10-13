using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STRATEGY.CLIENT.Models
{
    public class PlanDocuments
    {
        [Key]
        public int PlanDocumentId { get; set; }
        public int PlanID { get; set; }
        [ForeignKey(nameof(PlanID))]
        public Plan? Plan { get; set; }
        public string DocumentName { get; set; }=string.Empty;
        public string DocumentPath { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
