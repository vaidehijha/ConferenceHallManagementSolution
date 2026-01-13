using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class VHindiDatum
{
    public string MotherLanguage { get; set; } = null!;

    public bool IsWorkingKnowledgeOfHindi { get; set; }

    public bool IsProficientInHindi { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public string UpdatedFrom { get; set; } = null!;

    public int HindiAsSubject { get; set; }

    public bool IsPassedAnyCourse { get; set; }

    public string LatestCourseName { get; set; } = null!;

    public int LatestCourseYear { get; set; }

    public int HindiAsMedium { get; set; }

    public string Message { get; set; } = null!;

    public string Parangat { get; set; } = null!;

    public string ParangatYesNo { get; set; } = null!;

    public string EmpNo { get; set; } = null!;

    public string? Empname { get; set; }

    public string? Department { get; set; }

    public string? Cellno { get; set; }

    public string? Pgemail { get; set; }

    public string? Designation { get; set; }

    public string? Region { get; set; }

    public string? Location { get; set; }

    public string? EmpNameHi { get; set; }

    public string? Grade { get; set; }

    public string? Officeraxno { get; set; }

    public string? Sex { get; set; }

    public int ParangatYear { get; set; }

    public string WorkingKnowledgePercent { get; set; } = null!;

    public string SubmissionFinYear { get; set; } = null!;
}
