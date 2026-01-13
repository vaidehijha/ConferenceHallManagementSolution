using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class VigTshirtElegibleEmployee
{
    public int Id { get; set; }

    public string EmployeeNo { get; set; } = null!;

    public int Status { get; set; }
}
