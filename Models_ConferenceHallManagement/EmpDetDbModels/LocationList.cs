using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class LocationList
{
    public int LocationId { get; set; }

    public string LocationName { get; set; } = null!;

    public string RegionName { get; set; } = null!;

    public string? LocationNameHi { get; set; }

    public int? RegionId { get; set; }
}
