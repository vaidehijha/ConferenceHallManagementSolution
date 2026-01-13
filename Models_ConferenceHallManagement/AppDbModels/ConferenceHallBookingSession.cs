using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.AppDbModels;

public partial class ConferenceHallBookingSession
{
    public int Id { get; set; }

    public int BookingId { get; set; }

    public int HallId { get; set; }

    public int SessionId { get; set; }

    public DateTime BookingDate { get; set; }

    public int Status { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedFrom { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public string UpdatedFrom { get; set; } = null!;

    public virtual ConferenceHallBooking Booking { get; set; } = null!;

    public virtual ConferenceHall Hall { get; set; } = null!;

    public virtual ConferenceHallSession Session { get; set; } = null!;

    public virtual MasterBookingStatusCode StatusNavigation { get; set; } = null!;
}
