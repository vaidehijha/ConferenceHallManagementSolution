using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class VSupportUserPasswordChangeLog
{
    public string UserName { get; set; } = null!;

    public string EightDigitEmpNo { get; set; } = null!;

    public string? Empname { get; set; }

    public string? Department { get; set; }

    public string? Designation { get; set; }

    public string? Grade { get; set; }

    public string? Region { get; set; }

    public string? Location { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string? UpdatedFrom { get; set; }

    public string Message { get; set; } = null!;
}
