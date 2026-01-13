using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class DiaryConsLocation
{
    public int Id { get; set; }

    public int LocationId { get; set; }

    public int RegionId { get; set; }

    public string LocationNameEn { get; set; } = null!;

    public string LocationNameHi { get; set; } = null!;

    public string EmpLocation { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string StdCode { get; set; } = null!;

    public int Status { get; set; }

    public int DisplayOrder { get; set; }

    public string Email { get; set; } = null!;

    public string Misc { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public int? Type { get; set; }
}
