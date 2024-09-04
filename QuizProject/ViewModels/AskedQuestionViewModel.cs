namespace QuizProject.ViewModels
{
	public class AskedQuestionViewModel
	{
		public int QuestionId { get; set; }
		public string QuestionText { get; set; }
		public string Answer1 { get; set; }
		public string Answer2 { get; set; }
		public string Answer3 { get; set; }
		public string Answer4 { get; set; }
		public string CorrectAnswer { get; set; }
	}
}
