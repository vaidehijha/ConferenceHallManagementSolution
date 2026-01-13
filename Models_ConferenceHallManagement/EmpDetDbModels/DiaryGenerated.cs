using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class DiaryGenerated
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public string Regions { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }
}
