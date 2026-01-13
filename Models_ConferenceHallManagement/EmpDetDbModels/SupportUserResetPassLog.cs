using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class SupportUserResetPassLog
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public string? UpdatedFrom { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string Message { get; set; } = null!;
}
