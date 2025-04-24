using DataAccess.Models;

namespace DataAccess.Interfaces;

public interface INoteRepository
{
    public Task CreateAsync(Note note, CancellationToken cancellationToken = default);
    
    public Task<Note?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    
    public Task UpdateAsync(Note note, CancellationToken cancellationToken = default);
    
    public Task DeleteAsync(Note note, CancellationToken cancellationToken = default);
}