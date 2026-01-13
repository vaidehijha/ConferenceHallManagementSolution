using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class Datacrit
{
    public string Empno { get; set; } = null!;

    public string? Empname { get; set; }

    public string? UserPass { get; set; }

    public DateTime? Dob { get; set; }

    public string? Mars { get; set; }

    public string? Sex { get; set; }

    public string? Religion { get; set; }

    public string? Empstate { get; set; }

    public DateTime? Lefton { get; set; }

    public string? Discipline { get; set; }

    public string? Bloodgroup { get; set; }

    public bool? Block { get; set; }

    public DateTime? PassChangedAt { get; set; }

    public DateTime? Updat { get; set; }

    public string? Updfrom { get; set; }

    public string? EmpStatusChangedBy { get; set; }

    public string? EpmsPass { get; set; }

    public int? EmpStatus { get; set; }

    public string? PassChangedBy { get; set; }

    public bool? PassChanged { get; set; }

    public bool? IsIntranetAdmin { get; set; }

    public bool? IsHradmin { get; set; }

    public string? ResidenceAddress { get; set; }

    public string? EmpPass { get; set; }

    public string? EmpNameHi { get; set; }

    public string? Theme { get; set; }

    public DateTime? Insertedon { get; set; }

    public string? CurState { get; set; }

    public string? MainDisc { get; set; }

    public string? JobDisc { get; set; }

    public string? PwdCateg { get; set; }

    public string? PwdSubCateg { get; set; }

    public string? IsExServiceMan { get; set; }

    public DateOnly? ExitDate { get; set; }

    public string? ExitReason { get; set; }
}
