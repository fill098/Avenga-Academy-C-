using PizzaApp.Api.Extensions;
using PizzaApp.DataAccess;
using PizzaApp.Mappers;
using PizzaApp.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddDataAccess(builder.Configuration)
    .AddMappers()
    .AddServices()
    .AddApi(builder.Configuration);


builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

app.UseExceptionHandler(_ => { });

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapApiDocs(); // /openapi/v1.json + Scalar UI at /scalar
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
