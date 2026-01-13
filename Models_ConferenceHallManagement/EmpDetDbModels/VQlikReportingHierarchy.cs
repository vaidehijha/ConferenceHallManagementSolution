using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class VQlikReportingHierarchy
{
    public string EightDigitEmpNo { get; set; } = null!;

    public string? Reportingoffr { get; set; }

    public string? Reviewingoffr { get; set; }

    public string? Department { get; set; }
}
