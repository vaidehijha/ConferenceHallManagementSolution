using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class X9009
{
    public int Id { get; set; }

    public string? EmpNo { get; set; }

    public string? Email { get; set; }

    public int? Status { get; set; }
}
