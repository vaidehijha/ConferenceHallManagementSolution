using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class ZEmpUanMemDatum
{
    public string EmpNo { get; set; } = null!;

    public string Uan { get; set; } = null!;

    public DateOnly? EntryDate { get; set; }

    public string? MemberId { get; set; }
}
