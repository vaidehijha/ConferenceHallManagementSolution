using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class VigSize
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public string Size { get; set; } = null!;

    public int Status { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string UpdatedFrom { get; set; } = null!;
}
