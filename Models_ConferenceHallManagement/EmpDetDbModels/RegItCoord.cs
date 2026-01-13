using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class RegItCoord
{
    public int Id { get; set; }

    public string EmpId { get; set; } = null!;

    public bool IsActive { get; set; }
}
