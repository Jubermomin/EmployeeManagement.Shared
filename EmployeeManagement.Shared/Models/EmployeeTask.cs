using System;
using System.Collections.Generic;

namespace EmployeeManagement.Shared.Models;

public partial class EmployeeTask
{
    public int TaskId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int AssignedToUserId { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime DueDate { get; set; }

    public bool IsCompleted { get; set; }

    public virtual User AssignedToUser { get; set; } = null!;

    public virtual User CreatedByUser { get; set; } = null!;

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();
}
