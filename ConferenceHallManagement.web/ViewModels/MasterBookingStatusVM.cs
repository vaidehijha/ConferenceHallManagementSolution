using System.ComponentModel.DataAnnotations;

namespace ConferenceHallManagement.Web.ViewModels
{
    public class MasterBookingStatusVM
    {
        public int Id { get; set; }
        
        public int StatusId { get; set; }

        [Required(ErrorMessage = "Status Name (English) is required")]
        [StringLength(100, ErrorMessage = "Status Name cannot exceed 100 characters")]
        public string StatusName { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "Status Name (Hindi) cannot exceed 100 characters")]
        public string StatusNameHindi { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
