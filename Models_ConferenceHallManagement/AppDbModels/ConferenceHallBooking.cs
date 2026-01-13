using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.AppDbModels;

public partial class ConferenceHallBooking
{
    public int BookingId { get; set; }

    public int HallId { get; set; }

    public int RoomTypeId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string ProgramName { get; set; } = null!;

    public int NoOfAttendees { get; set; }

    public string Remarks { get; set; } = null!;

    public int Status { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedFrom { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public string UpdatedFrom { get; set; } = null!;

    public virtual ICollection<ConferenceHallBookingSession> ConferenceHallBookingSessions { get; set; } = new List<ConferenceHallBookingSession>();

    public virtual ConferenceHall Hall { get; set; } = null!;

    public virtual MasterRoomType RoomType { get; set; } = null!;

    public virtual MasterBookingStatusCode StatusNavigation { get; set; } = null!;
}
