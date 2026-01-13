using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class VDreamsUser
{
    public string EightDigitEmpNo { get; set; } = null!;

    public string? Empname { get; set; }

    public DateTime? Dob { get; set; }

    public string? Department { get; set; }

    public string? Cellno { get; set; }

    public string? Pgemail { get; set; }

    public string? Sex { get; set; }

    public string? Designation { get; set; }

    public string? Grade { get; set; }

    public string? Region { get; set; }

    public string? Location { get; set; }
}
