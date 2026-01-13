using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class EmpPran
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public string Pran { get; set; } = null!;

    public DateTime InsertedOn { get; set; }
}
