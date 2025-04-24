using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static class Extensions
{
    public static IServiceCollection AddDataAccess(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<INoteRepository, NoteRepository>();
        serviceCollection.AddScoped<IBookRepository, BookRepository>();
        serviceCollection.AddDbContext<AppContext>(x =>
        {
            x.UseNpgsql("Host=localhost;Database=NoteDb;Port=5432;Username=postgres;Password=123");

        });
        return serviceCollection;
    }
}