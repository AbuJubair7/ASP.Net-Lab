using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace validation.Models
{

    public class SignUp
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Name must be between 4 and 50 characters")]
        [RegularExpression(@"^[A-Za-z\s\.\-]+$", ErrorMessage = "Name can only contain letters, spaces, '.', and '-'")]
        public string Name { get; set; }

        [Required(ErrorMessage = "User ID is required")]
        [StringLength(12, MinimumLength = 4, ErrorMessage = "User ID must be between 4 and 12 characters")]
        [RegularExpression(@"^[A-Za-z0-9_-]+$", ErrorMessage = "User ID can only contain letters, numbers, '-', and '_'")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "ID is required")]
        [RegularExpression(@"^\d{2}-\d{5}-\d$", ErrorMessage = "ID must be in the format 'xx-xxxxx-x' and contain only numbers.")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^\d{2}-\d{5}-\d@student.aiub.edu$", ErrorMessage = "Email must be in the format 'xx-xxxxx-x@student.aiub.edu'")]
        public string Email { get; set; }
    }
}