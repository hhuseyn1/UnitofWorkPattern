namespace UnitofWorkPattern.Models;

public class Department : BaseEntity
{
    public string? Name { get; set; }
    // Navigation Property
    public List<Teacher>? Teachers { get; set; }
}
