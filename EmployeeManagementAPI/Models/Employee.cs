using System.ComponentModel.DataAnnotations;
namespace EmployeeManagementAPI.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

    }
}
