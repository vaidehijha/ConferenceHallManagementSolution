using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class VRtiUserList
{
    public string EmpNo { get; set; } = null!;

    public string? EmpName { get; set; }

    public DateTime? Dob { get; set; }

    public string? Cellno { get; set; }

    public string? Pgemail { get; set; }

    public string Address { get; set; } = null!;

    public string? Designation { get; set; }

    public bool? Active { get; set; }

    public string? Grade { get; set; }

    public string? Region { get; set; }

    public string? Location { get; set; }

    public string? Department { get; set; }
}
