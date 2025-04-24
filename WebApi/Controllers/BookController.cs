using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("Book")]
public class BookController(IBookService bookService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync(string name, string author, string publisher, DateTime publishDate)
    {
        await bookService.CreateAsync(name, author, publisher, publishDate);
        return NoContent();
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetBookAsync([FromRoute] int id)
    {
        var result = await bookService.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateBookAsync([FromRoute] int id, string newText)
    {
        await bookService.UpdateAsync(id, newText);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteBookAsync([FromRoute] int id)
    {
        await bookService.DeleteAsync(id);
        return NoContent();
    }

    [HttpGet]
    public async Task<IActionResult> GetAllBooksAsync()
    {
        var result = await bookService.GetAllAsync();
        return Ok(result);
    }
}