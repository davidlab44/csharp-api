using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DfvApiPrueba.Models.dfv2Context>(
    options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("dfv2"));
    });

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
