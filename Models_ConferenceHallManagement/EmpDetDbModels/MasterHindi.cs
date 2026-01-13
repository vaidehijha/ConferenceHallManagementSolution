using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class MasterHindi
{
    public int Id { get; set; }

    public string TextEn { get; set; } = null!;

    public string TextHi { get; set; } = null!;

    public int Status { get; set; }
}
