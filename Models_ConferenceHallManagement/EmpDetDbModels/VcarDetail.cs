using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class VcarDetail
{
    public int Sno { get; set; }

    public string? Empno { get; set; }

    public int? PassSno { get; set; }

    public string? VehicleType { get; set; }

    public string? RegNo { get; set; }

    public string? RegNo1 { get; set; }

    public string? MakeVehicle { get; set; }

    public string? AlterNateNo { get; set; }

    public string? EmporNonEmp { get; set; }

    public string? ReferencedEmpno { get; set; }

    public int? IsDeleted { get; set; }

    public DateTime? DateOfIssue { get; set; }

    public string? NameofPassHolder { get; set; }

    public string? Expr1 { get; set; }

    public int? Expr2 { get; set; }

    public string? Expr3 { get; set; }

    public string? Expr4 { get; set; }

    public string? Expr5 { get; set; }

    public string? Expr6 { get; set; }

    public string? Expr7 { get; set; }
}
