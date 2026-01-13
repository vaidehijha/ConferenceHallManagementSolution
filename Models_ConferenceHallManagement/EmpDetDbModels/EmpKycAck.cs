using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class EmpKycAck
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public DateOnly AckDate { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string UpdatedFrom { get; set; } = null!;

    public string? EmpNameInAadhar { get; set; }
}
