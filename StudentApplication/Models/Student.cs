using System;
using System.Collections.Generic;

namespace StudentApplication.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public int? Age { get; set; }

    public int? Standard { get; set; }

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }
}
