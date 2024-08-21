using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizProject.Models
{
    [Keyless]
    public class Score
    {
        [ForeignKey("PlayerId")]
        public int PlayerId { get; set; }
        public int ScoreCount { get; set; }
    }
}
