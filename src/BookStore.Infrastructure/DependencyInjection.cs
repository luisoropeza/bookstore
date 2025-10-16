using BookStore.Application.Common.Abstractions.Repositories;
using BookStore.Infrastructure.Context;
using BookStore.Infrastructure.Repostories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure (this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IAuthorRepository, AuthorRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IBookRepository, BookRepository>();
        services.AddDbContext<BookStoreDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        return services;
    }
}
