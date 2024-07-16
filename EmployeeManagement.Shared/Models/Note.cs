using System;
using System.Collections.Generic;

namespace EmployeeManagement.Shared.Models;

public partial class Note
{
    public int NoteId { get; set; }

    public int TaskId { get; set; }

    public string Content { get; set; } = null!;

    public int CreatedByUserId { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual User CreatedByUser { get; set; } = null!;

    public virtual EmployeeTask Task { get; set; } = null!;
}
