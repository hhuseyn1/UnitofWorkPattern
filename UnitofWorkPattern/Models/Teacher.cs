﻿using UnitofWorkPattern.Enums;

namespace UnitofWorkPattern.Models;

public class Teacher : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Id_Dep { get; set; }
    public  Gender Gender { get; set; }
    // Navigation Property
    public Department? Department { get; set; }
    public List<T_Card>? T_Cards { get; set; }
}
