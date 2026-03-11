var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    // Make XML the default response format for all endpoints
    options.Filters.Add(new Microsoft.AspNetCore.Mvc.ProducesAttribute("application/xml"));
})
.AddXmlSerializerFormatters();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi("/api");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
