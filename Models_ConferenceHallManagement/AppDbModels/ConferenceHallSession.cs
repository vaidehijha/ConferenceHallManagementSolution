using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models_ConferenceHallManagement.AppDbModels;

public partial class ConferenceHallSession
{
    [Key]
    public int SessionId { get; set; }

    // Foreign Key linking back to the Hall
    public int HallId { get; set; }

    // --- NEW PROPERTIES (Helper properties for UI - not mapped to database) ---
    [NotMapped]
    public string SessionName { get; set; } = string.Empty;
    
    [NotMapped]
    public TimeSpan StartTime { get; set; }
    
    [NotMapped]
    public TimeSpan EndTime { get; set; }
    
    [NotMapped]
    public decimal Price { get; set; }

    // --- EXISTING PROPERTIES (Actual database columns) ---
    public string SessionEn { get; set; } = null!;

    public string SessionHi { get; set; } = null!;

    public bool Status { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedFrom { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public string UpdatedFrom { get; set; } = null!;

    // --- NAVIGATION PROPERTIES ---
    public virtual ICollection<ConferenceHallBookingSession> ConferenceHallBookingSessions { get; set; } = new List<ConferenceHallBookingSession>();

    [ForeignKey("HallId")]
    public virtual ConferenceHall Hall { get; set; } = null!;
}