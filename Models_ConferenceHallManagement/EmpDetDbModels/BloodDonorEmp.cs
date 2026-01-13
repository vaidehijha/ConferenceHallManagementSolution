using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class BloodDonorEmp
{
    public int Sno { get; set; }

    public string EmpNo { get; set; } = null!;

    public string EmpName { get; set; } = null!;

    public string? BloodGroup { get; set; }

    public string? Deptt { get; set; }

    public string? Designation { get; set; }

    public DateTime? Dob { get; set; }

    public string? Address { get; set; }

    public string? LandLineNo { get; set; }

    public string? MobileNo { get; set; }

    public string? Disease { get; set; }

    public DateTime? LastDonationDate { get; set; }

    public string? EmpRelation { get; set; }
}
