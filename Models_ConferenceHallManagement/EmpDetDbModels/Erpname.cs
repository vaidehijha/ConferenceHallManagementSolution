using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class Erpname
{
    public string? EmpNo { get; set; }

    public string? Ename { get; set; }

    public string? Designation { get; set; }

    public string? Grade { get; set; }

    public string? Department { get; set; }

    public string? Location { get; set; }

    public string? Email { get; set; }

    public string? MobNo { get; set; }

    public string? NameSuggestion { get; set; }

    public DateTime? ErpnameDate { get; set; }

    public int Id { get; set; }
}
