using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class SupportUserResetPassPermission
{
    public int Id { get; set; }

    public string AuthorisedUserEmpno { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public int Status { get; set; }
}
