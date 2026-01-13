using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class VE1
{
    public string EightDigitEmpNo { get; set; } = null!;

    public string? Empname { get; set; }

    public DateTime? Dob { get; set; }

    public string? Department { get; set; }

    public string? Designation { get; set; }

    public string? Grade { get; set; }

    public string? Region { get; set; }

    public string? Location { get; set; }

    public bool? Active { get; set; }

    public DateOnly? ExitDate { get; set; }

    public string? ExitReason { get; set; }
}
