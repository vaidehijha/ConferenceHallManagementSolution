using System.ComponentModel.DataAnnotations;

namespace ConferenceHallManagement.Web.ViewModels
{
    public class MasterRoomTypeVM
    {
        public int Id { get; set; }
        
        public int RoomTypeId { get; set; }

        [Required(ErrorMessage = "Room Type (English) is required")]
        [StringLength(100, ErrorMessage = "Room Type cannot exceed 100 characters")]
        public string RoomTypeEn { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "Room Type (Hindi) cannot exceed 100 characters")]
        public string RoomTypeHi { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
