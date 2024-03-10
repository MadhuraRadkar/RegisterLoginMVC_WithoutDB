using System.ComponentModel.DataAnnotations;

namespace RegisterLoginMVC.Models
{
    public class Users
    {
        public string? Username { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password {  get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirm Password do not match.")]
        public string? ConfirmPass {  get; set; }
    }
}
