using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.AppDbModels;

public partial class TempEmployeeRole
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;//form

    public int ApplicationId { get; set; }

    public int RegionId { get; set; }//drop static

    public int LocationId { get; set; }//sta
    //drop
    public int DepartmentId { get; set; }//drop
    //dept static
    public int RoleId { get; set; }
    //drop
    public bool IsAllowWrite { get; set; }//checkbox

    public bool Status { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedFrom { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public string UpdatedFrom { get; set; } = null!;
}
