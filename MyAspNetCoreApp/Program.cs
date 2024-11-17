using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async (context) =>
{
    try
    {
        // Asynchronously read a file
        var data = await File.ReadAllTextAsync("example.txt");
        context.Response.ContentType = "text/plain";
        await context.Response.WriteAsync(data);
    }
    catch
    {
        context.Response.StatusCode = 500;
        await context.Response.WriteAsync("Server Error");
    }
});

app.Run("http://localhost:3001");
