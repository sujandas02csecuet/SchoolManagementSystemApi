using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementSystemApi.Models
{
    public class Employee
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string PresentAddress { get; set; }
        [Required]
        [StringLength(100)]

        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string NationalIdNo { get; set; }
        [Required]
        [StringLength(100)]
        public string EmployeeType { get; set; }

    }
}
