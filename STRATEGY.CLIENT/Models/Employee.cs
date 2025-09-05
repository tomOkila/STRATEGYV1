using System.ComponentModel.DataAnnotations;

namespace STRATEGY.CLIENT.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string IDNumber { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; }
        public int DepartmentID { get; set; }
        public Department? Departments { get; set; }

        public DateTime CreateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
