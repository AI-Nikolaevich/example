var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Пробуем всё что можно");
    c.RoutePrefix = string.Empty;
});


app.MapGet("/test", () => "Hello World!");

app.Run();
