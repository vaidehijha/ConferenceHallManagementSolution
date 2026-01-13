using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class Emptree
{
    public string Empno { get; set; } = null!;

    public string? Empname { get; set; }

    public string? Reportingoffr { get; set; }

    public string? Grade { get; set; }

    public string? Reviewingoffr { get; set; }
}
