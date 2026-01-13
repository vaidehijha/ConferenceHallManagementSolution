using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class EmpQualification
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public string? Course { get; set; }

    public string? Branch { get; set; }

    public string? Year { get; set; }

    public string? Percentage { get; set; }

    public string? Division { get; set; }

    public string? University { get; set; }

    public string? Institute { get; set; }

    public DateTime? InsertedOn { get; set; }
}
