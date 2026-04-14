namespace CapitalQuiz.Api.Models;

public class CountryQuestion
{
    public string Country { get; set; }
    public string CorrectCapital { get; set; }
    public List<string> WrongCapitals { get; set; }

    public List<string> GetShuffledOptions()
    {
        var options = new List<string>(WrongCapitals) { CorrectCapital };
        return options.OrderBy(x => Guid.NewGuid()).ToList();
    }

    public bool IsCorrect(string answer)
    {
        return answer == CorrectCapital;
    }
}