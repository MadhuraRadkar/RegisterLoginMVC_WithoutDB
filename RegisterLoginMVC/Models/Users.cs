using System.ComponentModel.DataAnnotations;

namespace RegisterLoginMVC.Models
{
    public class Users
    {
        public string? Username { get; set; }
        [Required]
        // [RegularExpression("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:a-z0-9?\\\\.)+a-z0-9?$\r\n",ErrorMessage ="Email id should be in proper format")]

        // [RegularExpression("^[0-9A-Z]([-.\\w]*[0-9A-Z])*$",ErrorMessage ="Email should be in proper format")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password {  get; set; }
        [Required]
        public string? ConfirmPass {  get; set; }
    }
}
