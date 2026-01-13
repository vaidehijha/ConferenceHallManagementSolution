using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class Training
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public string? TrainingRegion { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? TrainingType { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
