using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class StatesByRegion
{
    public int Id { get; set; }

    public int RegionId { get; set; }

    public int StateId { get; set; }
}
