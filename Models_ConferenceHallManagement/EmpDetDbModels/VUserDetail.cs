using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class VUserDetail
{
    public string Empno { get; set; } = null!;

    public string? Empname { get; set; }

    public string? Designation { get; set; }

    public string? Department { get; set; }

    public string? Reportingoffr { get; set; }
}
