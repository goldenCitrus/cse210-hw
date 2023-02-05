public class QuestionGenerator
{
public string GenerateQuestion()
{
    var questions = new List<string> {"What cho favorite color?", "Can you do a little dance XD??", "Has your social security number changed, and if so what is it?"};
    int count = questions.Count;
    var r = new Random();
    int list_index = r.Next(count);
    
    string _question = questions[list_index];
    return _question;
}
}