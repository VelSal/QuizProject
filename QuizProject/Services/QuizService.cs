using Microsoft.EntityFrameworkCore;
using QuizProject.Data;
using QuizProject.Models;
using QuizProject.ViewModels;

namespace QuizProject.Services
{
    public class QuizService
    {
        private readonly QuizContext _context;
        private List<Question> _questions;
        private int _currentQuestionIndex;
        public QuizService(QuizContext context) 
        { 
            _context = context;
            _questions = new List<Question>();
            _currentQuestionIndex = 0;
        }

        public async Task CopyAndRandomizeQuestionsAsync()
        {
            _questions = await _context.Questions
                .OrderBy(q => Guid.NewGuid())   //Generate a random Guid and order them by this Guid = random
                .ToListAsync();
        }

        // Get next question if there is one otherwise, return null
        public Question GetNextQuestion()
        {
            if (_currentQuestionIndex >= _questions.Count)
            {
                return _questions[_currentQuestionIndex++];
            }
            return null;
        }

        // Is the answer to the question correct?
        public bool IsCorrectAnswer(Question question, string selectedAnswer)
        {
            return question.CorrectAnswer == selectedAnswer;
        }

        // Is there other questions to ask?
        public bool HasMoreQuestions()
        {
            return _currentQuestionIndex < _questions.Count;
        }
       
    }
}
