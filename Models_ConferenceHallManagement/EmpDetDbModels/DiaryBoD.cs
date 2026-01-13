using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class DiaryBoD
{
    public int Id { get; set; }

    public string NameEn { get; set; } = null!;

    public string NameHi { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public string OffAddress { get; set; } = null!;

    public string ResAddress { get; set; } = null!;

    public string? OffPhone { get; set; }

    public string? ResPhone { get; set; }

    public string? Email { get; set; }

    public int Status { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public int? DisplayOrder { get; set; }

    public string? DesignationHi { get; set; }

    public string? ResAddressHi { get; set; }
}
