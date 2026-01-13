using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models_ConferenceHallManagement.AppDbModels;

public partial class MasterBookingStatusCode
{    
    public int Id { get; set; }

    public int MasterBookingStatusId { get; set; }

    public string StatusTextEn { get; set; } = null!;

    public string StatusTextHi { get; set; } = null!;

    public bool Status { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedFrom { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public string UpdatedFrom { get; set; } = null!;

    public virtual ICollection<ConferenceHallBookingSession> ConferenceHallBookingSessions { get; set; } = new List<ConferenceHallBookingSession>();

    public virtual ICollection<ConferenceHallBooking> ConferenceHallBookings { get; set; } = new List<ConferenceHallBooking>();
}
