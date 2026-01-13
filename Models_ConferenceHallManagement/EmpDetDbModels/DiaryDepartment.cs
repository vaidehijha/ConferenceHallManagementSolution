using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class DiaryDepartment
{
    public int Id { get; set; }

    public int DepartmentId { get; set; }

    public string DepartmentNameEn { get; set; } = null!;

    public int Status { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public string? DepartmentNameHi { get; set; }
}
