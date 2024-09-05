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

        // Reset everything
        public void Reset()
        {
            _questions = new List<Question>();
            _currentQuestionIndex = 0;
            Console.WriteLine("Quiz reset");
        }
        public async Task CopyAndRandomizeQuestionsAsync()
        {
            Reset();
            _questions = await _context.Questions
                .OrderBy(q => Guid.NewGuid())   //Generate a random Guid and order them by this Guid = random
                .ToListAsync();

            Console.WriteLine($"{_questions.Count} questions loaded");

            if (_questions.Count == 0)
            {
                Console.WriteLine("Error: No questions loaded");
            }
        }

        public void IncrementQuestionsIndex()
        {
            if (_currentQuestionIndex < _questions.Count - 1)
            {
				_currentQuestionIndex++;
                Console.WriteLine($"Index incremented to {_currentQuestionIndex}");
            }
            else
            {
                Console.WriteLine("Every questions has been asked");
            }
        }
        // Get next question if there is one otherwise, return null
        public Question GetCurrentQuestion()
        {
			#region Old code
			//if (_currentQuestionIndex < _questions.Count)
			//{
			//    Console.WriteLine($"Question {_currentQuestionIndex + 1} of {_questions.Count}");
			//    return _questions[_currentQuestionIndex];
			//}
			//Console.WriteLine("No more questions");
			//return null;
			#endregion

            if (_questions == null || _questions.Count == 0)
            {
                Console.WriteLine("Error: questions list empty or not initialized");
                return null;
            }
            if (_currentQuestionIndex < 0 || _currentQuestionIndex >= _questions.Count)
            {
                Console.WriteLine($"Error: Invalid index {_currentQuestionIndex} oob");
                return null;
            }
            Console.WriteLine($"Current question: {_currentQuestionIndex + 1} of {_questions.Count}");
			return _questions[_currentQuestionIndex];
		}

		// Is the answer to the question correct?
		public bool IsCorrectAnswer(Question question, string selectedAnswer)
        {
            return question.CorrectAnswer == selectedAnswer;
        }

        // Is there other questions to ask?
        public bool HasMoreQuestions()
        {
            bool moreQuestions = _currentQuestionIndex < _questions.Count;
            Console.WriteLine($"Has more questions? {moreQuestions}");
            return moreQuestions;
        }
       
    }
}
