var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Endpoints to return simple text
app.MapGet("get-example", () => "Hello from GET");
app.MapPost("post-example", () => "Hello from POST");

// Endpoint to return OK 200
app.MapGet("ok-object", () => Results.Ok(new
{
    Name = "Bob Smith"
}));

// Endpoint with async code
app.MapGet("slow-request", async () =>
{
    await Task.Delay(1000); // Add delay
    return Results.Ok(new
    {
        Name = "Bob Smith"
    });
});

app.Run();