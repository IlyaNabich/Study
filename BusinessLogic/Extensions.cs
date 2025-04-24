using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic;

public static class Extensions
{
    public static IServiceCollection AddBusinessLogic(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<INoteService, NoteService>();
        serviceCollection.AddScoped<IBookService, BookService>();
        return serviceCollection;
    }
}