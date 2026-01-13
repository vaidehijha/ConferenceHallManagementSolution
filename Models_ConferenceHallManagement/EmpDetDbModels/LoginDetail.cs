using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class LoginDetail
{
    public int Id { get; set; }

    public string? EmpNo { get; set; }

    public string? ValidatedThrough { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedFrom { get; set; }
}
