using System.ComponentModel.DataAnnotations;

namespace Web_ConferenceHallManagement.Models
{
    public class MasterCHBookingStatusVM
    {
        public int MasterBookingStatusId { get; set; }

        [Required(ErrorMessage = "Status Text (English) is required")]
        public string StatusTextEn { get; set; } = string.Empty;

        [Required(ErrorMessage = "Status Text (Hindi) is required")]
        public string StatusTextHi { get; set; } = string.Empty;

        public bool Status { get; set; } = true;

        public string CreatedBy { get; set; } = string.Empty;

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public string CreatedFrom { get; set; } = string.Empty;

        public string UpdatedBy { get; set; } = string.Empty;

        public DateTime UpdatedOn { get; set; } = DateTime.Now;

        public string UpdatedFrom { get; set; } = string.Empty;
    }
}
