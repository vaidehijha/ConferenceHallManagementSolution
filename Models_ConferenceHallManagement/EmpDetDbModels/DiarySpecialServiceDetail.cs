using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class DiarySpecialServiceDetail
{
    public int Id { get; set; }

    public int SpecialServiceId { get; set; }

    public string ServiceNameEn { get; set; } = null!;

    public string ServiceNameHi { get; set; } = null!;

    public string InterCom { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public int Status { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }
}
