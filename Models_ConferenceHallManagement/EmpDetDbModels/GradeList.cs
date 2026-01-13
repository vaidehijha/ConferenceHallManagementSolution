using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class GradeList
{
    public int Id { get; set; }

    public string Grade { get; set; } = null!;

    public int GradeType { get; set; }
}
