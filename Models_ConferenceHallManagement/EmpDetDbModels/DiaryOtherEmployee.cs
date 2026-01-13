using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class DiaryOtherEmployee
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public string SuperEmpNo { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public int RegionId { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public int? Status { get; set; }
}
