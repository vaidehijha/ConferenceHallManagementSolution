using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class Covid19
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public bool Q1 { get; set; }

    public bool Q2 { get; set; }

    public bool Q3 { get; set; }

    public bool Q4 { get; set; }

    public DateOnly DeclarationDate { get; set; }

    public int Status { get; set; }

    public string InsertedBy { get; set; } = null!;

    public DateTime InsertedOn { get; set; }

    public string InsertedFrom { get; set; } = null!;
}
