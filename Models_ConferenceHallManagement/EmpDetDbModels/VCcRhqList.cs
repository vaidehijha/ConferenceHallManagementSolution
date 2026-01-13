using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class VCcRhqList
{
    public int RegionId { get; set; }

    public int LocationId { get; set; }

    public string LocationName { get; set; } = null!;

    public string? LocationNameHi { get; set; }

    public string RegionName { get; set; } = null!;

    public string RegionValue { get; set; } = null!;

    public string? RegionNameHi { get; set; }
}
