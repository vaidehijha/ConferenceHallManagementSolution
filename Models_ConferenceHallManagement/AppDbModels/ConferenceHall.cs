using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models_ConferenceHallManagement.AppDbModels;

public partial class ConferenceHall
{
    [Key]
    public int HallId { get; set; }

    // --- NEW PROPERTIES (Added to fix your errors) ---
    [NotMapped]
    public string HallName { get; set; } = string.Empty;
    
    [NotMapped]
    public string Location { get; set; } = string.Empty;

    // --- EXISTING PROPERTIES ---
    public string HallNameEn { get; set; } = null!;

    public string HallNameHi { get; set; } = null!;

    public string Floor { get; set; } = null!;

    public int Capacity { get; set; }

    public int RegionId { get; set; }

    public int LocationId { get; set; }

    public bool Status { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedFrom { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public string UpdatedFrom { get; set; } = null!;

    public bool IsApprovalRequired { get; set; }

    // --- NAVIGATION PROPERTIES ---
    public virtual ICollection<ConferenceHallBookingSession> ConferenceHallBookingSessions { get; set; } = new List<ConferenceHallBookingSession>();

    public virtual ICollection<ConferenceHallBooking> ConferenceHallBookings { get; set; } = new List<ConferenceHallBooking>();

    public virtual ICollection<ConferenceHallSession> ConferenceHallSessions { get; set; } = new List<ConferenceHallSession>();
}