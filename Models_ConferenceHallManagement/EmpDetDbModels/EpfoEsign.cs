using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class EpfoEsign
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public string EmpName { get; set; } = null!;

    public DateOnly SignDate { get; set; }

    public int Status { get; set; }

    public DateTime InsertedOn { get; set; }
}
