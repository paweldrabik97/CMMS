using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;

namespace CMMS_Shared.Data.Models
{
    public class Registration
    {
        public Registration() { }
        
        
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType (DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Password and Confirm Password fields do not match")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
