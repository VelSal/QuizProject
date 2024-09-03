using System.ComponentModel.DataAnnotations;

namespace QuizProject.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public ICollection<Score> Scores { get; set; }
        
    }
}
