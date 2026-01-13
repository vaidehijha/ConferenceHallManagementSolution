using System.ComponentModel.DataAnnotations;

namespace ConferenceHallManagement.web.ViewModels
{
    // PARENT MODEL: The Hall
    public class HallConfigurationVM
    {
        [Required(ErrorMessage = "Please enter the Hall Name")]
        [StringLength(100, ErrorMessage = "Name is too long")]
        public string HallName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; } = string.Empty;

        [Range(1, 10000, ErrorMessage = "Capacity must be greater than 0")]
        public int Capacity { get; set; }

        // CHILD LIST: The Sessions (This drives the dynamic table in your UI)
        // We initialize it with 'new List...' so it's never null
        public List<SessionConfigVM> Sessions { get; set; } = new List<SessionConfigVM>();
    }

    // CHILD MODEL: The Sessions inside the Hall
    public class SessionConfigVM
    {
        [Required(ErrorMessage = "Session Name is required (e.g. Morning)")]
        public string SessionName { get; set; } = string.Empty;

        [Required]
        public DateTime StartTime { get; set; } = DateTime.Today;

        [Required]
        public DateTime EndTime { get; set; } = DateTime.Today;

        [Range(0, double.MaxValue, ErrorMessage = "Price cannot be negative")]
        public decimal Price { get; set; }
    }
}