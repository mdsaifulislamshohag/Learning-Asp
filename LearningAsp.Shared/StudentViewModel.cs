using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LearningAsp.Shared
{
    public class StudentViewModel
    {
        [Required]
        [Display(Name = "Full name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Full name")]
        public int Batch { get; set; }
        [Required]
        [Display(Name = "Full name")]
        public string Email { get; set; }
    }
}
