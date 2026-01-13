using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class DiaryFaxNo
{
    public int Id { get; set; }

    public string DepartmentEn { get; set; } = null!;

    public string DepartmentHi { get; set; } = null!;

    public string FaxNo { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public int RegionId { get; set; }

    public int Status { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }
}
