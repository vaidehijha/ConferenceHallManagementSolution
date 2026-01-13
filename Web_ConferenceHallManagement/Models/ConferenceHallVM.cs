using System.ComponentModel.DataAnnotations;

namespace Web_ConferenceHallManagement.Models
{
    public class ConferenceHallVM
    {
        [Key]
        [Display(Name = "Hall Id")]
        public int HallId { get; set; }
        [Required]
        [Display(Name = "Hall Name (English)")]
        [StringLength(200, ErrorMessage = "Hall name cannot exceed 200 characters.")]
        public string HallNameEn { get; set; } = null!;
        [Required]
        [Display(Name = "Hall Name (Hindi)")]
        [StringLength(200, ErrorMessage = "Hall name cannot exceed 200 characters.")]
        public string HallNameHi { get; set; } = null!;
        [Required]
        [Display(Name = "At Floor")]
        [StringLength(50, ErrorMessage = "Floor cannot exceed 50 characters.")]
        public string Floor { get; set; } = null!;
        [Required]
        [Display(Name = "Hall Capacity")]
        public int Capacity { get; set; }
        [Required]
        [Display(Name = "Region")]
        public int RegionId { get; set; }
        [Required]
        [Display(Name = "Location")]
        public int LocationId { get; set; }
        [Required]
        [Display(Name ="Is Admin Approval Required?")]
        public bool IsApprovalRequired { get; set; }
    }
}
