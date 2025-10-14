﻿using BookStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure (this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BookStoreDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        return services;
    }
}
