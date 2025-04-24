using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using DataAccess.Models;

namespace BusinessLogic.Servicies;

public class BookService (IBookRepository bookRepository) : IBookService
{
    public async Task CreateAsync(string name, string publisher,string author, DateTime dateTime, CancellationToken cancellationToken = default)
    {
        var book = new Book
        {
            Name = name,
            Publisher = publisher,
            Author = author,
            PublishDate = dateTime,
            UploadDate = DateTime.UtcNow
        };
        await bookRepository.CreateAsync(book, cancellationToken);
    }

    public async Task<string?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var book = await bookRepository.GetByIdAsync(id, cancellationToken);
        if(book is null)
            throw new Exception("Book not found");
        return book.Name;
    }

    public async Task UpdateAsync(int id, string newText, CancellationToken cancellationToken = default)
    {
        var book = await bookRepository.GetByIdAsync(id, cancellationToken);
        if(book is null)
            throw new Exception("Note not found");
        
        book.Name = newText;
        await bookRepository.UpdateAsync(book, cancellationToken);
    }

    public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
    {
        var book = await bookRepository.GetByIdAsync(id, cancellationToken);
        if(book is null)
            throw new Exception("Book not found");
        await bookRepository.DeleteAsync(book, cancellationToken);
    }

    public async Task<List<Book>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var books = await bookRepository.GetAllAsync(cancellationToken);
        return books;
    }
}