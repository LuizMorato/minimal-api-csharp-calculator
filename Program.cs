// Minimal API de Calculadora Simples

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/soma", (double a, double b) => Results.Ok(a + b));
app.MapGet("/subtracao", (double a, double b) => Results.Ok(a - b));
app.MapGet("/multiplicacao", (double a, double b) => Results.Ok(a * b));
app.MapGet("/divisao", (double a, double b) =>
{
    if (b == 0) return Results.BadRequest("Não é possível dividir por zero.");
    return Results.Ok(a / b);
});

app.Run();
