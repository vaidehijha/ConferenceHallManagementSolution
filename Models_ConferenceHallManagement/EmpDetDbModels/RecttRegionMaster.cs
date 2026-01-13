using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class RecttRegionMaster
{
    public int Id { get; set; }

    public string Region { get; set; } = null!;

    public int RegionCode { get; set; }
}
