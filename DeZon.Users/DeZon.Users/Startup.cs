using DeZon.Users.Infrastructure;

namespace DeZon.Users;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddSwaggerGen();

        services.AddSingleton<IRepository, Repository>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app
                .UseSwagger()
                .UseSwaggerUI(options => { options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"); });
        }

        app.UseRouting();

        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}