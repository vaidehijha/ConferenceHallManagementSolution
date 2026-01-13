using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class EofficeNodalOfcrDetail
{
    public string? EmpId { get; set; }

    public string? IsActive { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
