using System.ComponentModel.DataAnnotations;

namespace Lab6.Models
{
    public class StudentBase
    {
        [StringLength(50, MinimumLength = 1)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength =1)]
        [Required]
        public string LastName { get; set; }  

        [StringLength(50, MinimumLength =1)]
        [Required]
        public string Program { get; set; }
    }
}
