using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class LogDreamsExtUser
{
    public int Id { get; set; }

    public int ExtUserId { get; set; }

    public int EmpNoId { get; set; }

    public string EmpNo { get; set; } = null!;

    public string EmpName { get; set; } = null!;

    public string Department { get; set; } = null!;

    public string CellNo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Sex { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public string Grade { get; set; } = null!;

    public string Region { get; set; } = null!;

    public string Location { get; set; } = null!;

    public int Status { get; set; }

    public string InsertedBy { get; set; } = null!;

    public DateTime InsertedOn { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public string UpdatedFrom { get; set; } = null!;

    public string LogInsertedBy { get; set; } = null!;

    public DateTime LogInsertedOn { get; set; }

    public string LogInsertedFrom { get; set; } = null!;
}
