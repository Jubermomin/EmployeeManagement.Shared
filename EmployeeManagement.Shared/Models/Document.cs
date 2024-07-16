using System;
using System.Collections.Generic;

namespace EmployeeManagement.Shared.Models;

public partial class Document
{
    public int DocumentId { get; set; }

    public int TaskId { get; set; }

    public string FilePath { get; set; } = null!;

    public virtual EmployeeTask Task { get; set; } = null!;
}
