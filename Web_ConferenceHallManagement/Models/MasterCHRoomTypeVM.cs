using System.ComponentModel.DataAnnotations;

namespace Web_ConferenceHallManagement.Models
{
    public class MasterCHRoomTypeVM
    {
        [Key]
        [Display(Name = "Room Type Id")]
        public int RoomTypeId { get; set; }
        [Required]
        [Display(Name = "Room Type Text (English)")]
        [StringLength(500, ErrorMessage = "Room Type text cannot exceed 500 characters.")]
        public string? RoomTypeEn { get; set; }
        [Required]
        [Display(Name = "Room Type Text (Hindi)")]
        [StringLength(500, ErrorMessage = "Room Type text cannot exceed 500 characters.")]
        public string? RoomTypeHi { get; set; }
    }
}
