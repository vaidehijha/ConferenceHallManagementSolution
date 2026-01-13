using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class Datadirect
{
    public string Empno { get; set; } = null!;

    public string? Pgemail { get; set; }

    public string? Extemail { get; set; }

    public string? Website { get; set; }

    public string? Officeseat { get; set; }

    public string? Officephoneno { get; set; }

    public string? Officeraxno { get; set; }

    public string? Residencephoneno { get; set; }

    public string? Residenceaddress { get; set; }

    public string? Cellno { get; set; }

    public string? Lanid { get; set; }

    public bool? Ipphone { get; set; }

    public DateTime? Updat { get; set; }

    public string? Updfrom { get; set; }

    public string? Residencecity { get; set; }

    public bool? ContactDetailsUpdated { get; set; }

    public bool? ContactDetailsEpms { get; set; }

    public DateTime? InsertedOn { get; set; }

    public bool? IsOnZimbra { get; set; }

    public DateTime? IsOnZimbraUpdatedOn { get; set; }

    public Guid Empimgguid { get; set; }
}
