using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class ItcoordList
{
    public int Id { get; set; }

    public string? EmpNo { get; set; }

    public string? Ss { get; set; }

    public int? Region { get; set; }

    public int? IsAdmin { get; set; }
}
