

namespace DataAccess;

public class Note
{
    public int Id { get; init; }
    public string? Text { get; set; }
    public DateTime Created { get; set; }
    public DateTime UpDate {get; set;}
}