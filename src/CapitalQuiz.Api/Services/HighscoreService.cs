using CapitalQuiz.Api.Models;

namespace CapitalQuiz.Api.Services;

public class HighscoreService
{
    private readonly string _filePath = "highscores.txt";

    public List<HighscoreEntry> Load()
    {
        if (!File.Exists(_filePath))
            return new List<HighscoreEntry>();

        return File.ReadAllLines(_filePath)
            .Select(line =>
            {
                var parts = line.Split(',');
                return new HighscoreEntry
                {
                    Name = parts[0],
                    Score = int.Parse(parts[1])
                };
            })
            .ToList();
    }

    public void Add(string name, int score)
    {
        var scores = Load();
        scores.Add(new HighscoreEntry { Name = name, Score = score });

        var sorted = scores
            .OrderByDescending(s => s.Score)
            .Take(10)
            .ToList();

        File.WriteAllLines(_filePath,
            sorted.Select(s => $"{s.Name},{s.Score}"));
    }
}