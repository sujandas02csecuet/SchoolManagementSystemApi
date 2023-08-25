using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementSystemApi.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string PresentAddress { get; set; }
        [Required]
        [StringLength(100)]
        public string RollNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string ContactNo { get; set; }
    }
}
