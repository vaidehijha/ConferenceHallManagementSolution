using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class PwdResetComplete
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Otp { get; set; } = null!;

    public DateTime OtpGenerationTime { get; set; }

    public DateTime OtpValidTill { get; set; }

    public DateTime UpdatedOn { get; set; }

    public bool? IsSuccessFullyReset { get; set; }

    public string UpdatedFrom { get; set; } = null!;

    public DateTime? ResetOn { get; set; }
}
