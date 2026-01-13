using System.ComponentModel.DataAnnotations;

namespace Web_ConferenceHallManagement.Models
{
    public class ConferenceHallSessionVM
    {
        [Key]
        [Display(Name = "Hall Session Id")]
        public int SessionId { get; set; }
        [Required]
        [Display(Name = "Hall Id")]
        public int HallId { get; set; }     
        [Required]
        [Display(Name = "Session Name (English)")]
        public string SessionEn { get; set; } = null!;
        [Required]
        [Display(Name = "Session Name (Hindi)")]
        public string SessionHi { get; set; } = null!;
    }
}
