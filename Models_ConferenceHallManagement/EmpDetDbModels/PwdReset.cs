using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class PwdReset
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public string UpdatedFrom { get; set; } = null!;
}
