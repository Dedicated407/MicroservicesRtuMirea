using DeZon.Users.Infrastructure;

namespace DeZon.Users;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSwaggerGen();
        
        services.AddSingleton<IRepository, Repository>();
        
        services.AddControllers();
    }
    
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
        }
        
        app.UseRouting(); 
        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}