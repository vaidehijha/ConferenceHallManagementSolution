using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class DiaryDepartmentsMaster
{
    public int Id { get; set; }

    public int DepartmentId { get; set; }

    public string DepartmentNameEn { get; set; } = null!;

    public string DepartmentNameHi { get; set; } = null!;

    public int RegionId { get; set; }

    public int DisplayOrder { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public int IsSuperDepartment { get; set; }

    public int? Status { get; set; }
}
