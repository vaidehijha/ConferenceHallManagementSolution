using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class PolicyPerceptionSurvey
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public int EmpType { get; set; }

    public Guid Guid { get; set; }

    public int Status { get; set; }

    public DateTime InsertedOn { get; set; }

    public DateTime EnteredOn { get; set; }
}
