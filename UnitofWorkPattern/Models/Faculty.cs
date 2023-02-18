using System.Text.RegularExpressions;

namespace UnitofWorkPattern.Models;

public class Faculty : BaseEntity
{
    public string? Name { get; set; }

    // Navigation Property
    public List<Group>? Groups { get; set; }
}
