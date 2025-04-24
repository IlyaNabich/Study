using DataAccess;

namespace BusinessLogic;

public interface IBookService
{
    Task CreateAsync(string name, string publisher,string author, DateTime dateTime, CancellationToken cancellationToken = default);
    
    Task<string?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
     
    Task UpdateAsync(int id, string newText, CancellationToken cancellationToken = default);
    
    Task DeleteAsync(int id, CancellationToken cancellationToken = default);
    
    Task<List<Book>> GetAllAsync(CancellationToken cancellationToken = default);
}