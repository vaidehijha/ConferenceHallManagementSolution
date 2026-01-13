using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class DistrictList
{
    public int Id { get; set; }

    public int DistrictId { get; set; }

    public int StateId { get; set; }

    public string DistrictNameEn { get; set; } = null!;

    public string? DistrictNameHi { get; set; }
}
