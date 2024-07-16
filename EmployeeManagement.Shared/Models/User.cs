using System;
using System.Collections.Generic;

namespace EmployeeManagement.Shared.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string Role { get; set; } = null!;

    public int? TeamId { get; set; }

    public virtual ICollection<EmployeeTask> EmployeeTaskAssignedToUsers { get; set; } = new List<EmployeeTask>();

    public virtual ICollection<EmployeeTask> EmployeeTaskCreatedByUsers { get; set; } = new List<EmployeeTask>();

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();
}
