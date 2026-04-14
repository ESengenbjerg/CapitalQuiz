using CapitalQuiz.Api.Data;
using CapitalQuiz.Api.Models;

namespace CapitalQuiz.Api.Services;

public class QuizService
{
    public List<CountryQuestion> GetRandomQuestions(int count)
    {
        return CountryData.GetAll()
            .OrderBy(x => Guid.NewGuid())
            .Take(count)
            .ToList();
    }
}