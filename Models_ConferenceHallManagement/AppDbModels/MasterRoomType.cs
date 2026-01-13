using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.AppDbModels;

public partial class MasterRoomType
{
    public int Id { get; set; }

    public int RoomTypeId { get; set; }

    public string RoomTypeEn { get; set; } = null!;

    public string RoomTypeHi { get; set; } = null!;

    public bool Status { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedFrom { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public string UpdatedFrom { get; set; } = null!;

    public virtual ICollection<ConferenceHallBooking> ConferenceHallBookings { get; set; } = new List<ConferenceHallBooking>();
}
