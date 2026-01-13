using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class ExEmpDetailLog
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public string? EmpName { get; set; }

    public string Password { get; set; } = null!;

    public string? Region { get; set; }

    public string? Location { get; set; }

    public string? Email { get; set; }

    public string? CellNo { get; set; }

    public string? Designation { get; set; }

    public string? Grade { get; set; }

    public string? Department { get; set; }

    public DateOnly? DoB { get; set; }

    public string? Sex { get; set; }

    public string? BloodGroup { get; set; }

    public string? ResidencePhoneNo { get; set; }

    public string? CurrentState { get; set; }

    public string? CurrentCity { get; set; }

    public string? CurrentAddress { get; set; }

    public int Status { get; set; }

    public DateTime? RegisteredOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public DateTime? PasswordChangedOn { get; set; }

    public string? RegisteredFrom { get; set; }

    public DateTime? LoggedOn { get; set; }

    public string? LoggedBy { get; set; }

    public string? UpdatedFrom { get; set; }

    public string? SpouseName { get; set; }

    public string? SpouseGender { get; set; }

    public DateOnly? SpouseDob { get; set; }

    public string? SpouseBloodGroup { get; set; }
}
