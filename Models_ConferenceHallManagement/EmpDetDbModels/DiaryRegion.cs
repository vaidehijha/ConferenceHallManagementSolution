using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class DiaryRegion
{
    public int Id { get; set; }

    public int RegionId { get; set; }

    public string RegionNameEn { get; set; } = null!;

    public string RegionNameHi { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public int Status { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public int? RegionType { get; set; }

    public int? Parent { get; set; }
}
