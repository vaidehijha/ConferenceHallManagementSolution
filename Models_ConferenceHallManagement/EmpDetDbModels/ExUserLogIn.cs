using System;
using System.Collections.Generic;

namespace Models_ConferenceHallManagement.EmpDetDbModels;

public partial class ExUserLogIn
{
    public int Id { get; set; }

    public string EmpNo { get; set; } = null!;

    public string? RawUrl { get; set; }

    public string? RequestType { get; set; }

    public string? ApplicationPath { get; set; }

    public string? AppRelativeCurrentExecutionFilePath { get; set; }

    public string? ContentEncoding { get; set; }

    public int? ContentLength { get; set; }

    public string? CurrentExecutionFilePath { get; set; }

    public bool? IsLocal { get; set; }

    public bool? IsSecureConnection { get; set; }

    public string? Path { get; set; }

    public string? PathInfo { get; set; }

    public string? PhysicalApplicationPath { get; set; }

    public string? PhysicalPath { get; set; }

    public int? TotalBytes { get; set; }

    public string? Url { get; set; }

    public string? UrlReferrer { get; set; }

    public string? UserAgent { get; set; }

    public string UserHostAddress { get; set; } = null!;

    public string UserHostName { get; set; } = null!;

    public string WebBrowser { get; set; } = null!;

    public string? HttpMethod { get; set; }

    public string? FilePath { get; set; }

    public DateTime LoggedIn { get; set; }

    public string? SessionId { get; set; }

    public DateTime? LoggedOut { get; set; }
}
