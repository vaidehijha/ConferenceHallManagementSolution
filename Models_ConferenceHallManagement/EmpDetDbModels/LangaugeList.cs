using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class LangaugeList
{
    public int Id { get; set; }

    public string Language { get; set; } = null!;

    public int LanguageId { get; set; }
}
