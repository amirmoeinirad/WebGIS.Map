internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        
        // =================================
        // Add services to the DI container.     
        // =================================

        
        // Add OpenAPI/Swagger support
        builder.Services.AddOpenApi();


        var app = builder.Build();
        

        // ====================================
        // Configure the HTTP request pipeline.
        // ====================================


        if (app.Environment.IsDevelopment())
        {
            // Enable OpenAPI/Swagger middleware
            app.MapOpenApi();
        }

        // Enable HTTPS redirection middleware
        // This means that all HTTP requests will be redirected to HTTPS.
        app.UseHttpsRedirection();

        // Run the application
        app.Run();
    }
}
