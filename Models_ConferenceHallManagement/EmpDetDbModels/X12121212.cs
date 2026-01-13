using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class X12121212
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public DateOnly DesgDate { get; set; }
}
