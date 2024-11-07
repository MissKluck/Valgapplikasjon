var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

VotingService votingService = new VotingService();

app.MapGet("/health", () => "Healthy"); // asking the server if it's alive

app.MapPost("/valg", () =>
{
    Election newElection = votingService.AddNewElection();
    return Results.Ok(new { id = $"/valg/{newElection.id}" });
});

app.Run();
