using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class HrEmpDatum
{
    public int Id { get; set; }

    public string? EmpNo { get; set; }

    public string? EmpName { get; set; }

    public string? Grade { get; set; }

    public string? Designation { get; set; }

    public string? Department { get; set; }

    public string? Region { get; set; }

    public string? Location { get; set; }
}
