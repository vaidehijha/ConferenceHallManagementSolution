using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class VendorTraining
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? TrainingRegion { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EmdDate { get; set; }

    public string? TrainingType { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
