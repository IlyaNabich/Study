

namespace DataAccess.Models;

public class Book
{
    public int Id { get; init; }
    public string? Name { get; set; }
    public string? Author { get; set; }
    public string? Publisher { get; set; }
    public DateTime PublishDate { get; set; }
    public DateTime UploadDate { get; set; }
    
}