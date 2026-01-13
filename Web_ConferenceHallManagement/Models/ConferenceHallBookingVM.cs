using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Models_ConferenceHallManagement.AppDbModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_ConferenceHallManagement.Models
{
    public class ConferenceHallBookingVM
    {
        [Key]
        [Display(Name = "Booking Id")]
        public int BookingId { get; set; }
        [Required]
        [Display(Name = "Please Select a Hall")]
        public int HallId { get; set; }
        [Required]
        [Display(Name = "Select Seating Type")]
        public int RoomTypeId { get; set; }
        [Required]
        [Display(Name = "From Date")]
        [DisplayFormat(DataFormatString = "{0:ddd, dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "To Date")]
        [DisplayFormat(DataFormatString = "{0:ddd, dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }
        [Required]
        [Display(Name = "Enter Program Name")]
        [StringLength(500, ErrorMessage = "Program Name cannot be longer than 500 characters.")]
        public string ProgramName { get; set; } = null!;
        [Required]
        [Display(Name = "Enter Number of Attendees")]
        public int NoOfAttendees { get; set; }


        [Display(Name = "Remarks")]
        [MaxLength(2000, ErrorMessage = "Remarks cannot be longer than 2000 characters.")]
        [ValidateNever]
        public string Remarks { get; set; } = string.Empty;
        
        [ValidateNever]
        [Display(Name = "Please Select Sessions")]
        public List<OptionGroupViewModel> Groups { get; set; } = [];




        [ValidateNever]
        public virtual ICollection<ConferenceHallBookingSession> ConferenceHallBookingSessions { get; set; } = new List<ConferenceHallBookingSession>();
        [ValidateNever]
        public virtual ConferenceHall Hall { get; set; } = null!;
        [ValidateNever]
        public virtual MasterRoomType RoomType { get; set; } = null!;
        [ValidateNever]
        [Display(Name ="Booking Status")]
        public virtual MasterBookingStatusCode StatusNavigation { get; set; } = null!;


        
    }
}
