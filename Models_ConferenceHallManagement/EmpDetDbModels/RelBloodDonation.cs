using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class RelBloodDonation
{
    public int Sno { get; set; }

    public string? Empno { get; set; }

    public string? Empname { get; set; }

    public string? Empdeptt { get; set; }

    public string? RelativeName { get; set; }

    public string? Relation { get; set; }

    public string? RelBloodGroup { get; set; }

    public DateTime? RelDob { get; set; }

    public string? RelAddress { get; set; }

    public string? RelMobileNo { get; set; }

    public string? RelLandLineNo { get; set; }

    public string? RelDisease { get; set; }

    public DateTime? RelLastDonationDate { get; set; }

    public string? Empmob { get; set; }

    public string? EmpDesignation { get; set; }
}
