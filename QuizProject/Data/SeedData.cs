using Microsoft.EntityFrameworkCore;
using QuizProject.Models;

namespace QuizProject.Data
{
    public static class SeedData
    {
        public static void AddRecords(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Nature"},
                new Category { CategoryId = 2, CategoryName = "Sports"},
                new Category { CategoryId = 3, CategoryName = "Movies"},
                new Category { CategoryId = 4, CategoryName = "Technology"},
                new Category { CategoryId = 5, CategoryName = "Music"}
                );

            modelBuilder.Entity<Question>().HasData(
                new Question { 
                    QuestionId = 1, 
                    QuestionText = "What do bees gather in order to make honey?",
                    Answer1 = "Nectar",
                    Answer2 = "Yeast",
                    Answer3 = "Eggs",
                    Answer4 = "Self-Rising Flour",
                    CorrectAnswer = "Nectar",
                    CategoryId = 1
                },
                new Question {
                    QuestionId = 2,
                    QuestionText = "Which of those is a creature with many legs?",
                    Answer1 = "Milligram",
                    Answer2 = "Millipede",
                    Answer3 = "Millisecond",
                    Answer4 = "Millimetre",
                    CorrectAnswer = "Millipede",
                    CategoryId = 1
                },
                new Question {
                    QuestionId = 3,
                    QuestionText = "Which natural phenomenon is a display of the visible spectrum?",
                    Answer1 = "Hailstone",
                    Answer2 = "Eclipse",
                    Answer3 = "Rainbow",
                    Answer4 = "Sunbeam",
                    CorrectAnswer = "Rainbow",
                    CategoryId = 1
                },
                new Question {
                    QuestionId = 4,
                    QuestionText = "What scale is used to measure earthquakes?",
                    Answer1 = "The Scoville Scale",
                    Answer2 = "The Fujita Scale",
                    Answer3 = "The Borg Scale",
                    Answer4 = "The Richter Scale",
                    CorrectAnswer = "The Richter Scale",
                    CategoryId = 1
                },
                new Question {
                    QuestionId = 5,
                    QuestionText = "Which of those mammals can't jump?",
                    Answer1 = "The Elephant",
                    Answer2 = "The Cow",
                    Answer3 = "The Kangaroo",
                    Answer4 = "The Fox",
                    CorrectAnswer = "The Elephant",
                    CategoryId = 1
                },
                new Question {
                    QuestionId = 6,
                    QuestionText = "In which sport can you hit a \"Home Run\"?",
                    Answer1 = "Football",
                    Answer2 = "Baseball",
                    Answer3 = "Hockey",
                    Answer4 = "Basketball",
                    CorrectAnswer = "Baseball",
                    CategoryId = 2
                },
                new Question {
                    QuestionId = 7,
                    QuestionText = "Which of these is an Olympic field event?",
                    Answer1 = "Shot pitch",
                    Answer2 = "Shot toss",
                    Answer3 = "Shot put",
                    Answer4 = "Shot set",
                    CorrectAnswer = "Shot put",
                    CategoryId = 2
                },
                new Question {
                    QuestionId = 8,
                    QuestionText = "Which of these events takes place in the Brickyard?",
                    Answer1 = "US Open",
                    Answer2 = "NBA All-Star Game",
                    Answer3 = "Super Bowl",
                    Answer4 = "Indianapolis 500",
                    CorrectAnswer = "Indianapolis 500",
                    CategoryId = 2
                },
                new Question {
                    QuestionId = 9,
                    QuestionText = "In which of these sports would you use a cue to hit the ball?",
                    Answer1 = "Billiards",
                    Answer2 = "Tennis",
                    Answer3 = "Football",
                    Answer4 = "Hockey",
                    CorrectAnswer = "Billiards",
                    CategoryId = 2
                },
                new Question {
                    QuestionId = 10,
                    QuestionText = "The \"K-Point\" is a measurement used in which sport?",
                    Answer1 = "Triple jump",
                    Answer2 = "Ski jumping",
                    Answer3 = "Curling",
                    Answer4 = "Rifle Shooting",
                    CorrectAnswer = "Ski jumping",
                    CategoryId = 2
                },
                new Question {
                    QuestionId = 11,
                    QuestionText = "What type of animal is King Kong n the film of the same name?",
                    Answer1 = "A Lion",
                    Answer2 = "A Dinosaur",
                    Answer3 = "An Ape",
                    Answer4 = "A Lizard",
                    CorrectAnswer = "An Ape",
                    CategoryId = 3
                },
                new Question
                {
                    QuestionId = 12,
                    QuestionText = "Which of these is a famous Hollywood actor?",
                    Answer1 = "Northwood",
                    Answer2 = "Southwood",
                    Answer3 = "Eastwood",
                    Answer4 = "Westwood",
                    CorrectAnswer = "Eastwood",
                    CategoryId = 3
                },
                new Question
                {
                    QuestionId = 13,
                    QuestionText = "Who starred in the 2003 comedy \"School of Rock\"?",
                    Answer1 = "Dean Green",
                    Answer2 = "Lou Blue",
                    Answer3 = "Jay Green",
                    Answer4 = "Jack Black",
                    CorrectAnswer = "Jack Black",
                    CategoryId = 3
                },
                new Question
                {
                    QuestionId = 14,
                    QuestionText = "Which actor played the title role in Batman Begins, reseased in 2005?",
                    Answer1 = "Christian Bale",
                    Answer2 = "Jake Gyllenhaal",
                    Answer3 = "Wes Bentley",
                    Answer4 = "Mark Wahlberg",
                    CorrectAnswer = "Christian Bale",
                    CategoryId = 3
                },
                new Question
                {
                    QuestionId = 15,
                    QuestionText = "Which actor played the role of Doctor Caligari in the 1920 movie \"The Cabinet of Dr. Caligari\"?",
                    Answer1 = "Conrad Veidt",
                    Answer2 = "Werner Krauss",
                    Answer3 = "Friedrich Feher",
                    Answer4 = "Lil Dagover",
                    CorrectAnswer = "Werner Krauss",
                    CategoryId = 3
                },
                new Question
                {
                    QuestionId = 16,
                    QuestionText = "Which company created the first portable CD player known as the Discman?",
                    Answer1 = "Panasonic",
                    Answer2 = "Hitachi",
                    Answer3 = "Sony",
                    Answer4 = "Casio",
                    CorrectAnswer = "Sony",
                    CategoryId = 4
                },
                new Question
                {
                    QuestionId = 17,
                    QuestionText = "When was the first iPhone released?",
                    Answer1 = "2000",
                    Answer2 = "2007",
                    Answer3 = "2010",
                    Answer4 = "2020",
                    CorrectAnswer = "2007",
                    CategoryId = 4
                },
                new Question
                {
                    QuestionId = 18,
                    QuestionText = "Who is the inventor of the \"World Wide Web\"?",
                    Answer1 = "James Gosling",
                    Answer2 = "Ted Codd",
                    Answer3 = "Larry Ellison",
                    Answer4 = "Tim Berners-Lee",
                    CorrectAnswer = "Tim Berners-Lee",
                    CategoryId = 4
                },
                new Question
                {
                    QuestionId = 19,
                    QuestionText = "Which car company manufactures the Passat?",
                    Answer1 = "Volkswagen",
                    Answer2 = "Audi",
                    Answer3 = "BMW",
                    Answer4 = "Mercedes",
                    CorrectAnswer = "Volkswagen",
                    CategoryId = 4
                },
                new Question
                {
                    QuestionId = 20,
                    QuestionText = "What is the first arcade video game?",
                    Answer1 = "Pac-Man",
                    Answer2 = "Pong",
                    Answer3 = "Space Invaders",
                    Answer4 = "Jumpman",
                    CorrectAnswer = "Pong",
                    CategoryId = 4
                },
                new Question
                {
                    QuestionId = 21,
                    QuestionText = "Who made the jazz standard \"Minnie the Moocher\"?",
                    Answer1 = "Duke Ellington",
                    Answer2 = "Count Basie",
                    Answer3 = "Cab Calloway",
                    Answer4 = "Benny Goodman",
                    CorrectAnswer = "Cab Calloway",
                    CategoryId = 5
                },
                new Question
                {
                    QuestionId = 22,
                    QuestionText = "What music video was the first video to reach 1 billion views?",
                    Answer1 = "\"Baby Shark\" by Pinkfong",
                    Answer2 = "\"Despacito\" by Luis Fonsi",
                    Answer3 = "\"Uptown Funk\" by Mark Ronson",
                    Answer4 = "\"Gangnam Style\"  by Psy",
                    CorrectAnswer = "\"Gangnam Style\"  by Psy",
                    CategoryId = 5
                },
                new Question
                {
                    QuestionId = 23,
                    QuestionText = "Who released the iconic debut album \"Illmatic\" in 1994?",
                    Answer1 = "Nas",
                    Answer2 = "Dr. Dre",
                    Answer3 = "Snoop Dogg",
                    Answer4 = "50 Cent",
                    CorrectAnswer = "Nas",
                    CategoryId = 5
                },
                new Question
                {
                    QuestionId = 24,
                    QuestionText = "Who is known as the \"King of Pop\"?",
                    Answer1 = "Prince",
                    Answer2 = "Michael Jackson",
                    Answer3 = "Lionel Richie",
                    Answer4 = "Phil Collins",
                    CorrectAnswer = "Michael Jackson",
                    CategoryId = 5
                },
                new Question
                {
                    QuestionId = 25,
                    QuestionText = "Which of these albums was not released by the band \"Nirvana\"?",
                    Answer1 = "Bleach",
                    Answer2 = "Nevermind",
                    Answer3 = "The Colour and the Shape",
                    Answer4 = "In Utero",
                    CorrectAnswer = "The Colour and the Shape",
                    CategoryId = 5
                }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    PlayerId = 1,
                    PlayerName = "Salva"
                },
                new Player
                {
                    PlayerId = 2,
                    PlayerName = "Toto"
                },
                new Player
                {
                    PlayerId = 3,
                    PlayerName = "Velsal"
                }
            );

            modelBuilder.Entity<Score>().HasData(
                new Score
                {
                    PlayerId = 1,
                    ScoreCount = 4,
                },
                new Score
                {
                    PlayerId = 2,
                    ScoreCount = 8,
                },
                new Score
                {
                    PlayerId = 3,
                    ScoreCount = 12,
                },
                new Score
                {
                    PlayerId = 1,
                    ScoreCount = 2,
                },
                new Score
                {
                    PlayerId = 2,
                    ScoreCount = 6,
                },
                new Score
                {
                    PlayerId = 3,
                    ScoreCount = 10,
                }
            );
        }
    }
}
