using CapitalQuiz.Api.Data;
using CapitalQuiz.Api.Services;
using CapitalQuiz.Api.Models;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddSingleton<QuizService>();
builder.Services.AddSingleton<HighscoreService>();

// Allow frontend (React) to call API
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors();

// ----------------------
//      ENDPOINTS
// ----------------------

// Get 10 random questions
app.MapGet("/questions", (QuizService quizService) =>
{
    return quizService.GetRandomQuestions(10);
});

// Get highscores (for Start Page)
app.MapGet("/highscores", (HighscoreService hs) =>
{
    return hs.Load();
});

// Save highscore (from Result Page)
app.MapPost("/highscores", (HighscoreService hs, HighscoreEntry entry) =>
{
    hs.Add(entry.Name, entry.Score);
    return Results.Ok();
});

app.Run();