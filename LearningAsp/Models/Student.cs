using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearningAsp.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name="Full name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Batch")]
        public int Batch { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

    }
}
