using ExceptionMiddleware.ExceptionMiddlewares;

namespace ExceptionMiddleware.Exception;

internal static class Startup
{
    internal static IServiceCollection AddExceptionMiddleware(this IServiceCollection services) =>
        services.AddScoped<ExceptionHandlingMiddleware>();

    internal static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder app) =>
        app.UseMiddleware<ExceptionHandlingMiddleware>();
}