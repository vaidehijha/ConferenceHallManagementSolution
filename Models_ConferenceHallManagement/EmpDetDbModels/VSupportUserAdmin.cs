using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class VSupportUserAdmin
{
    public string Username { get; set; } = null!;

    public string AuthorisedUserEmpno { get; set; } = null!;

    public string? Empname { get; set; }

    public string? Department { get; set; }

    public string? Designation { get; set; }

    public string? Grade { get; set; }

    public string? Region { get; set; }

    public string? Location { get; set; }
}
