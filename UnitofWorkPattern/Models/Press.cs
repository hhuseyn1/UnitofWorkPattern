namespace UnitofWorkPattern.Models;

public class Press : BaseEntity
{
    public string? Name { get; set; }
    // Navigation Property
    public List<Book>? Books { get; set; }
}
