using BookStore.Application.Profiles;
using BookStore.Application.Services.AuthorService;
using BookStore.Application.Services.CategoryService;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(cfg => { },
            typeof(AuthorProfile),
            typeof(BookProfile),
            typeof(CategoryProfile));
        services.AddScoped<IAuthorService, AuthorService>();
        services.AddScoped<ICategoryService, CategoryService>();
        return services;
    }
}
