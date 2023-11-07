using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeWEBAPIJISAHW.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]

        public int Id { get; set; }
        [Required]

        public string? Name { get; set; }
        [Required]

        public int Salary { get; set; }
        [Required]

        public string? City { get; set; }


    }
}
