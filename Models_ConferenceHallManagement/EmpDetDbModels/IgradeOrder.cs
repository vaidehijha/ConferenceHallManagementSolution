using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class IgradeOrder
{
    public int Id { get; set; }

    public string Grade { get; set; } = null!;

    public int GradeOrder { get; set; }

    public int Status { get; set; }
}
