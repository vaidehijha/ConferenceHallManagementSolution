using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class StateList
{
    public int StateId { get; set; }

    public string StateNameEn { get; set; } = null!;

    public string? StatenameHi { get; set; }
}
