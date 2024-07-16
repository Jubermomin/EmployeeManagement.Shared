using System;
using System.Collections.Generic;

namespace EmployeeManagement.Shared.Models;

public partial class Report
{
    public int ReportId { get; set; }

    public string ReportName { get; set; } = null!;

    public string ReportData { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
