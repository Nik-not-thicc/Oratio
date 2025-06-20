using BlazorApp1.Components.Pages.Models;

namespace BlazorApp1.Services;

public class QuestionService
{
    private List<Question> questions = [
        new Question()
            {
                QuestionState = QuestionState.Unanswered,
                QuestionType = QuestionType.FreeText,
                QuestionNumber = 0,  
                QuestionText = "Write a Python function named is_even that takes an integer as input and returns True if the number is even, and False otherwise."
            },
        new Question()
        {
            QuestionState = QuestionState.Unanswered,
            QuestionType = QuestionType.RadioButton,
            QuestionNumber = 1,  
            QuestionText = "Which of the following is a correct way to define a list in Python?",
            AnswerOptions = ["list = (1, 2, 3, 4)", "list = {1, 2, 3, 4}", "list = [1, 2, 3, 4]", "list = <1, 2, 3, 4>"]
        },
        new Question()
        {
            QuestionState = QuestionState.Unanswered,
            QuestionType = QuestionType.FreeText,
            QuestionNumber = 2,  
            QuestionText = "Describe the difference between a for loop and a while loop in programming. Provide an example of when you might use each."
        }];
    
    public IEnumerable<Question> GetQuestions() => questions;
    
    public Question GetQuestion(int questionNumber) => questions.FirstOrDefault(q => q.QuestionNumber == questionNumber);
    
    public void SetAnswer(int questionNumber, string answer) => GetQuestion(questionNumber).AnswerText = answer;
    
    public void DeleteAnswer(int questionNumber)
    {
        var question = GetQuestion(questionNumber);
        question.QuestionState = QuestionState.Unanswered;
        question.AnswerText = string.Empty;
    }
    
    public void MarkAnswerAsAnswered(int questionNumber) => GetQuestion(questionNumber).QuestionState = QuestionState.Answered;
    
    public void MarkAnswerAsUnsure(int questionNumber) => GetQuestion(questionNumber).QuestionState = QuestionState.Unsure;
}