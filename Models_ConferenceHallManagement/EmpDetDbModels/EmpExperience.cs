using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class EmpExperience
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Company { get; set; }

    public string? Desg { get; set; }

    public string? Level { get; set; }

    public string? Department { get; set; }

    public string? Region { get; set; }

    public string? Location { get; set; }

    public string? Action { get; set; }

    public DateTime? InsertedOn { get; set; }

    public string? Reason { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
