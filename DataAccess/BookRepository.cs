using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
namespace DataAccess;

internal class BookRepository(AppContext context) : IBookRepository
{
    public async Task CreateAsync(Book book, CancellationToken cancellationToken = default)
    {
        book.UploadDate = DateTime.UtcNow;
        await context.Books.AddAsync(book, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
        
    }

    public async Task UpdateAsync(Book book, CancellationToken cancellationToken = default)
    {
        context.Books.Update(book);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(Book book, CancellationToken cancellationToken = default)
    {
        context.Books.Remove(book);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task<Book?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await context.Books.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<List<Book>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await context.Books.ToListAsync(cancellationToken);
    }
}