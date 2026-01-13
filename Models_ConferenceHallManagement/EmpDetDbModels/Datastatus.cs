using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class Datastatus
{
    public string Empno { get; set; } = null!;

    public string? Designation { get; set; }

    public string? Grade { get; set; }

    public string? Position { get; set; }

    public string? Region { get; set; }

    public string? Location { get; set; }

    public string? Oldregion { get; set; }

    public string? Oldlocation { get; set; }

    public string? Department { get; set; }

    public string? Section { get; set; }

    public string? Responsibilities { get; set; }

    public string? Transferredto { get; set; }

    public bool? Active { get; set; }

    public string? Reportingoffr { get; set; }

    public string? Reviewingoffr { get; set; }

    public string? Basicpay { get; set; }

    public string? Perspay { get; set; }

    public string? Salaryaccount { get; set; }

    public string? Salarybank { get; set; }

    public string? Hometown { get; set; }

    public string? Railwaystation { get; set; }

    public string? Ou { get; set; }

    public DateTime? Updat { get; set; }

    public string? Updfrom { get; set; }

    public DateTime? ReportingDatefrom { get; set; }

    public DateTime? Doj { get; set; }

    public DateTime? ReportingDateTo { get; set; }

    public string? Updby { get; set; }

    public int? DefaultLanguage { get; set; }

    public string? ReviewingOffr2 { get; set; }

    public string? ReviewingOffr3 { get; set; }

    public string? CounterSigningOffr { get; set; }

    public string? EpmsReportingOffr { get; set; }

    public DateTime? Doeg { get; set; }

    public string? SeparationCause { get; set; }

    public string? AadharNumber { get; set; }

    public DateTime? InsertedOn { get; set; }

    public string? PhType { get; set; }

    public string? Category { get; set; }

    public DateOnly? Pdoeg { get; set; }

    public DateOnly? DojP { get; set; }

    public DateOnly? DojR { get; set; }

    public DateOnly? DojL { get; set; }

    public DateOnly? DojD { get; set; }

    public string? Emode { get; set; }

    public string? Previousgrade { get; set; }

    public string TotpSecret { get; set; } = null!;

    public bool IsTotpEnabled { get; set; }

    public DateTime? TotpChangedOn { get; set; }

    public bool? IsO365user { get; set; }

    public string? O365license { get; set; }

    public DateOnly? DojDesignation { get; set; }

    public DateOnly? DoReg { get; set; }

    public string? OrgUnit { get; set; }

    public string? PersonalArea { get; set; }

    public string? OrgUnitName { get; set; }

    public string? OrgGrp { get; set; }

    public string? AddOrg { get; set; }

    public string? Ltadet { get; set; }
}
