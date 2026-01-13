using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class Adu
{
    public int Id { get; set; }

    public string? Dn { get; set; }

    public string? Ou1 { get; set; }

    public string? Ou2 { get; set; }

    public string? Sam { get; set; }

    public string? EmpNo { get; set; }

    public string? SurName { get; set; }

    public string? Upn { get; set; }
}
