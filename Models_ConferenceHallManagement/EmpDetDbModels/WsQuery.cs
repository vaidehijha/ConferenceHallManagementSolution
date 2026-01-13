using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class WsQuery
{
    public int Id { get; set; }

    public string? Query { get; set; }

    public DateTime? QueryOn { get; set; }
}
