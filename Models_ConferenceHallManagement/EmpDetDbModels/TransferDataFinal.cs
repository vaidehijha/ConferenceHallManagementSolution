using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class TransferDataFinal
{
    public int Sno { get; set; }

    public string? Empname { get; set; }

    public string? Empno { get; set; }

    public string? Designation { get; set; }

    public string? Level { get; set; }

    public string? Dept { get; set; }

    public string? Location { get; set; }

    public string? Region { get; set; }

    public DateTime? DojDept { get; set; }

    public DateTime? DojPlace { get; set; }

    public DateTime? DojRegion { get; set; }

    public string? EmpDesg { get; set; }

    public string? EmpLevel { get; set; }

    public string? DeptFrom { get; set; }

    public string? LocnFrom { get; set; }

    public string? RegnFrom { get; set; }

    public string? DeptTo { get; set; }

    public string? LocnTo { get; set; }

    public string? RegnTo { get; set; }

    public string? ReportingOfficer { get; set; }

    public string? TxOrderNo { get; set; }

    public DateTime? TxOrderDate { get; set; }

    public DateTime? TxwefDate { get; set; }

    public string? TxAuthority { get; set; }

    public string? TxStatus { get; set; }

    public string? RxOrderNo { get; set; }

    public DateTime? RxOrderDate { get; set; }

    public DateTime? RxwefDate { get; set; }

    public string? JxOrderNo { get; set; }

    public DateTime? JxOrderDate { get; set; }

    public DateTime? JxWefDate { get; set; }

    public string? JxDept { get; set; }

    public string? JxLocn { get; set; }

    public string? JxRegn { get; set; }

    public string? ReviewingOfficer { get; set; }

    public string? Hierarchy1 { get; set; }

    public string? Hierarchy2 { get; set; }

    public string? CoutersigningOfficer { get; set; }

    public DateTime? RepDtFrm { get; set; }

    public int? Block { get; set; }

    public bool? UpdStatus { get; set; }

    public string? OldReportingOfficer { get; set; }

    public string? DataCamefromRegion { get; set; }
}
