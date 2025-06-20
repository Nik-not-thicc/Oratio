namespace BlazorApp1.Components.Pages.Models;

public class Question
{
    public string QuestionText { get; set; }

    public string AnswerText { get; set; }
    
    public int QuestionNumber { get; set; }
    
    public QuestionState QuestionState { get; set; }

    public QuestionType QuestionType { get; set; }

    public string[] AnswerOptions { get; set; }
}