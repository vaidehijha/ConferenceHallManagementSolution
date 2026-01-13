using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class DiaryGradeOrder
{
    public int Id { get; set; }

    public string Grade { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public int Status { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }
}
