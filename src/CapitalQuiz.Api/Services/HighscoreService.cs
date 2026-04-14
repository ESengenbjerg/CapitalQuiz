using CapitalQuiz.Api.Models;

namespace CapitalQuiz.Api.Services;


public class HighscoreService
{
    //private readonly string _filePath = Path.Combine(AppContext.BaseDirectory, "highscore.txt");
    private readonly string _filePath = Path.Combine(Directory.GetCurrentDirectory(), "highscore.txt");


    public List<HighscoreEntry> Load()
    {
        
        if (!File.Exists(_filePath))
        {
            return new List<HighscoreEntry>();
        }

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
            .Take(30)
            .ToList();

        // Write to the project-level highscore.txt and handle IO errors so the server doesn't crash
        try
        {
            File.WriteAllLines(_filePath, sorted.Select(s => $"{s.Name},{s.Score}"));
            System.Console.WriteLine($"Wrote highscores to {_filePath} (count {sorted.Count})");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Could not write highscores to {_filePath}: {ex}");
        }
        //File.WriteAllLines(_filePath,
        //    sorted.Select(s => $"{s.Name},{s.Score}"));
    }
}