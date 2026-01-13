using System.ComponentModel.DataAnnotations;

namespace Web_ConferenceHallManagement.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "User Name is required.")]
        [Display(Name = "User Name")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        public string? Captcha { get; set; }
    }
}
