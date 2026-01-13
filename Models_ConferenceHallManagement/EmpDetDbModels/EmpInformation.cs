using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class EmpInformation
{
    public string EmpNo { get; set; } = null!;

    public string? Empname { get; set; }

    public string? Pgemail { get; set; }

    public string? Officeseat { get; set; }

    public string? Officeraxno { get; set; }

    public string? Cellno { get; set; }
}
