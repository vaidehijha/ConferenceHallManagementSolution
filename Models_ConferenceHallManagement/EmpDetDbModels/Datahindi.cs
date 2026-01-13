using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class Datahindi
{
    public int Id { get; set; }

    public string? Empno { get; set; }

    public string? Hindiname { get; set; }

    public string? Hindidesign { get; set; }

    public string? Hindilocation { get; set; }

    public string? Hindidepart { get; set; }

    public string? Hindiregion { get; set; }

    public string? Hindilevel { get; set; }
}
