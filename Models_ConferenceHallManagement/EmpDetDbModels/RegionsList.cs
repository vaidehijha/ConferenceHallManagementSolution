using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class RegionsList
{
    public int RegionId { get; set; }

    public string RegionName { get; set; } = null!;

    public string RegionValue { get; set; } = null!;

    public string? RegionNameHi { get; set; }

    public int? SortOrder { get; set; }
}
