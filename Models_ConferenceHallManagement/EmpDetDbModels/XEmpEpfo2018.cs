using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class XEmpEpfo2018
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public string EmpName { get; set; } = null!;

    public string FatherName { get; set; } = null!;

    public string Uan { get; set; } = null!;

    public string Eps { get; set; } = null!;
}
