using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class VGetUserDetail
{
    public string Empno { get; set; } = null!;

    public string? Designation { get; set; }

    public string? Grade { get; set; }

    public string? Position { get; set; }

    public string? Region { get; set; }

    public string? Location { get; set; }

    public string? Department { get; set; }

    public bool? Active { get; set; }

    public string? Reportingoffr { get; set; }

    public string? Reviewingoffr { get; set; }

    public string? Empname { get; set; }

    public string? UserPass { get; set; }

    public DateTime? Dob { get; set; }

    public int? EmpStatus { get; set; }

    public DateTime? ReportingDatefrom { get; set; }

    public DateTime? Doj { get; set; }

    public string? EmpStatusChangedBy { get; set; }

    public string? Mars { get; set; }

    public string? Sex { get; set; }

    public string? Religion { get; set; }

    public string? Empstate { get; set; }

    public string? Discipline { get; set; }

    public string? Bloodgroup { get; set; }

    public DateTime? Updat { get; set; }

    public string? Updfrom { get; set; }

    public string? Extemail { get; set; }

    public string? Cellno { get; set; }

    public string? EpmsPass { get; set; }

    public string? Pgemail { get; set; }

    public string? Officephoneno { get; set; }

    public string? Officeraxno { get; set; }

    public bool? ContactDetailsEpms { get; set; }

    public DateTime? ReportingDateTo { get; set; }

    public string? EpmsReportingOffr { get; set; }

    public DateTime? Doeg { get; set; }
}
