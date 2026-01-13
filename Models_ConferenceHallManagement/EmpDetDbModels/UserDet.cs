using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class UserDet
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

    public string? Designation { get; set; }

    public string? Grade { get; set; }

    public string? Position { get; set; }

    public string? Region { get; set; }

    public string? Department { get; set; }

    public string? Section { get; set; }

    public string? Reportingoffr { get; set; }

    public string? Reviewingoffr { get; set; }

    public string? Hometown { get; set; }

    public string? Ou { get; set; }

    public string? Pgemail { get; set; }

    public string? Officephoneno { get; set; }

    public string? Residencephoneno { get; set; }

    public string? Cellno { get; set; }

    public string? Extemail { get; set; }

    public DateTime? PassChangedAt { get; set; }

    public bool? Active { get; set; }

    public string? Expr1 { get; set; }

    public string? Expr3 { get; set; }

    public string? Scalemin { get; set; }

    public string? Scalemax { get; set; }

    public bool? Block { get; set; }

    public string? Expr2 { get; set; }

    public string? Posting { get; set; }

    public string? Location { get; set; }

    public string? EmpPass { get; set; }
}
