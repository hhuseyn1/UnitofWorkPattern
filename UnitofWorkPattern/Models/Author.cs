namespace UnitofWorkPattern.Models;

public class Author : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    // Navigation Property
    public List<Book>? Books { get; set; }
}
