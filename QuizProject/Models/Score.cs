using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizProject.Models
{
    
    public class Score
    {
        public int ScoreId { get; set; }
        [ForeignKey("PlayerId")]
        public int PlayerId { get; set; }
        public int ScoreCount { get; set; }
        public Player Player { get; set; }
    }
}
