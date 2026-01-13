using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class Datastatuslog
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

    public string? UpdatedBy { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public DateTime? ReportingDateFrom { get; set; }

    public DateTime? ReportingDateTo { get; set; }

    public string? Updby { get; set; }

    public int? DefaultLanguage { get; set; }

    public string? ReviewingOffr2 { get; set; }

    public string? ReviewingOffr3 { get; set; }

    public string? CounterSigningOffr { get; set; }

    public string? EpmsReportingOffr { get; set; }

    public int Id { get; set; }
}
