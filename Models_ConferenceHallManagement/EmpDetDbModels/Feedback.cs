using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class Feedback
{
    public int Id { get; set; }

    public string FeedbackDetails { get; set; } = null!;

    public string Updatedby { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public string UpdatedFrom { get; set; } = null!;
}
