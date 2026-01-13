using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class Totp
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public string? TotpSecret { get; set; }
}
