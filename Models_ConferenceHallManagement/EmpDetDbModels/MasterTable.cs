using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class MasterTable
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public string? TextEnglish { get; set; }

    public string? TextHindi { get; set; }

    public int? Value { get; set; }

    public int? Sorder { get; set; }

    public bool? IsActive { get; set; }
}
