using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class Hr
{
    public string? Empno { get; set; }

    public string? Empname { get; set; }

    public string? Region { get; set; }

    public string? AdminPassword { get; set; }

    public string? Ipaddress { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
