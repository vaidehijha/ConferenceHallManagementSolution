using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class VcDetail
{
    public string EmpId { get; set; } = null!;

    public string? VcId { get; set; }

    public string IsActive { get; set; } = null!;
}
