using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class MasterLanguage
{
    public int Id { get; set; }

    public int LanguageId { get; set; }

    public string LanguageEn { get; set; } = null!;

    public string LanguageHi { get; set; } = null!;

    public int Status { get; set; }

    public int SortOrder { get; set; }
}
