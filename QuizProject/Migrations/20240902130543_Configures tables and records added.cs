using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizProject.Migrations
{
    /// <inheritdoc />
    public partial class Configurestablesandrecordsadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScoreId",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Scores",
                table: "Scores",
                column: "ScoreId");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Nature" },
                    { 2, "Sports" },
                    { 3, "Movies" },
                    { 4, "Technology" },
                    { 5, "Music" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "PlayerName" },
                values: new object[,]
                {
                    { 1, "Salva" },
                    { 2, "Toto" },
                    { 3, "Velsal" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Answer1", "Answer2", "Answer3", "Answer4", "CategoryId", "CorrectAnswer", "QuestionText" },
                values: new object[,]
                {
                    { 1, "Nectar", "Yeast", "Eggs", "Self-Rising Flour", 1, "Nectar", "What do bees gather in order to make honey?" },
                    { 2, "Milligram", "Millipede", "Millisecond", "Millimetre", 1, "Millipede", "Which of those is a creature with many legs?" },
                    { 3, "Hailstone", "Eclipse", "Rainbow", "Sunbeam", 1, "Rainbow", "Which natural phenomenon is a display of the visible spectrum?" },
                    { 4, "The Scoville Scale", "The Fujita Scale", "The Borg Scale", "The Richter Scale", 1, "The Richter Scale", "What scale is used to measure earthquakes?" },
                    { 5, "The Elephant", "The Cow", "The Kangaroo", "The Fox", 1, "The Elephant", "Which of those mammals can't jump?" },
                    { 6, "Football", "Baseball", "Hockey", "Basketball", 2, "Baseball", "In which sport can you hit a \"Home Run\"?" },
                    { 7, "Shot pitch", "Shot toss", "Shot put", "Shot set", 2, "Shot put", "Which of these is an Olympic field event?" },
                    { 8, "US Open", "NBA All-Star Game", "Super Bowl", "Indianapolis 500", 2, "Indianapolis 500", "Which of these events takes place in the Brickyard?" },
                    { 9, "Billiards", "Tennis", "Football", "Hockey", 2, "Billiards", "In which of these sports would you use a cue to hit the ball?" },
                    { 10, "Triple jump", "Ski jumping", "Curling", "Rifle Shooting", 2, "Ski jumping", "The \"K-Point\" is a measurement used in which sport?" },
                    { 11, "A Lion", "A Dinosaur", "An Ape", "A Lizard", 3, "An Ape", "What type of animal is King Kong n the film of the same name?" },
                    { 12, "Northwood", "Southwood", "Eastwood", "Westwood", 3, "Eastwood", "Which of these is a famous Hollywood actor?" },
                    { 13, "Dean Green", "Lou Blue", "Jay Green", "Jack Black", 3, "Jack Black", "Who starred in the 2003 comedy \"School of Rock\"?" },
                    { 14, "Christian Bale", "Jake Gyllenhaal", "Wes Bentley", "Mark Wahlberg", 3, "Christian Bale", "Which actor played the title role in Batman Begins, reseased in 2005?" },
                    { 15, "Conrad Veidt", "Werner Krauss", "Friedrich Feher", "Lil Dagover", 3, "Werner Krauss", "Which actor played the role of Doctor Caligari in the 1920 movie \"The Cabinet of Dr. Caligari\"?" },
                    { 16, "Panasonic", "Hitachi", "Sony", "Casio", 4, "Sony", "Which company created the first portable CD player known as the Discman?" },
                    { 17, "2000", "2007", "2010", "2020", 4, "2007", "When was the first iPhone released?" },
                    { 18, "James Gosling", "Ted Codd", "Larry Ellison", "Tim Berners-Lee", 4, "Tim Berners-Lee", "Who is the inventor of the \"World Wide Web\"?" },
                    { 19, "Volkswagen", "Audi", "BMW", "Mercedes", 4, "Volkswagen", "Which car company manufactures the Passat?" },
                    { 20, "Pac-Man", "Pong", "Space Invaders", "Jumpman", 4, "Pong", "What is the first arcade video game?" },
                    { 21, "Duke Ellington", "Count Basie", "Cab Calloway", "Benny Goodman", 5, "Cab Calloway", "Who made the jazz standard \"Minnie the Moocher\"?" },
                    { 22, "\"Baby Shark\" by Pinkfong", "\"Despacito\" by Luis Fonsi", "\"Uptown Funk\" by Mark Ronson", "\"Gangnam Style\"  by Psy", 5, "\"Gangnam Style\"  by Psy", "What music video was the first video to reach 1 billion views?" },
                    { 23, "Nas", "Dr. Dre", "Snoop Dogg", "50 Cent", 5, "Nas", "Who released the iconic debut album \"Illmatic\" in 1994?" },
                    { 24, "Prince", "Michael Jackson", "Lionel Richie", "Phil Collins", 5, "Michael Jackson", "Who is known as the \"King of Pop\"?" },
                    { 25, "Bleach", "Nevermind", "The Colour and the Shape", "In Utero", 5, "The Colour and the Shape", "Which of these albums was not released by the band \"Nirvana\"?" }
                });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "ScoreId", "PlayerId", "ScoreCount" },
                values: new object[,]
                {
                    { 1, 1, 4 },
                    { 2, 2, 8 },
                    { 3, 3, 12 },
                    { 4, 1, 2 },
                    { 5, 2, 6 },
                    { 6, 3, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Scores_PlayerId",
                table: "Scores",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Categories_CategoryId",
                table: "Questions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_Players_PlayerId",
                table: "Scores",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Categories_CategoryId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Scores_Players_PlayerId",
                table: "Scores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Scores",
                table: "Scores");

            migrationBuilder.DropIndex(
                name: "IX_Scores_PlayerId",
                table: "Scores");

            migrationBuilder.DropIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyColumnType: "int",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ScoreId",
                table: "Scores");
        }
    }
}
