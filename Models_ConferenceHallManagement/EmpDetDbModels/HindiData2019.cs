using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class HindiData2019
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public string MotherLanguage { get; set; } = null!;

    public int HindiAsSubject { get; set; }

    public int HindiAsMedium { get; set; }

    public bool IsWorkingKnowledgeOfHindi { get; set; }

    public bool IsProficientInHindi { get; set; }

    public bool IsPassedAnyCourse { get; set; }

    public string LatestCourseName { get; set; } = null!;

    public int LatestCourseYear { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public string UpdatedFrom { get; set; } = null!;
}
