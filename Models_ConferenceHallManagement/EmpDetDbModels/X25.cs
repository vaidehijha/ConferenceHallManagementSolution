using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class X25
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public string? CellNo { get; set; }

    public string? PgEmail { get; set; }

    public string? ExtEmail { get; set; }
}
