using System;
using System.Collections.Generic;

namespace ZH2_UWRH74.Models;

public partial class Employement
{
    public string EmployementId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Instructor> Instructors { get; } = new List<Instructor>();
}
