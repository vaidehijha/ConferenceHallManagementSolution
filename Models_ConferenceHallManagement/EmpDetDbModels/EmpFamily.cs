using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class EmpFamily
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public string? Name { get; set; }

    public string? Relationship { get; set; }

    public string? Gender { get; set; }

    public string? Birthdate { get; set; }

    public int? Age { get; set; }

    public string? MedicalDependent { get; set; }

    public string? Ltcdependent { get; set; }

    public string? Challenged { get; set; }

    public string? Dependent { get; set; }

    public DateTime? InsertedOn { get; set; }
}
