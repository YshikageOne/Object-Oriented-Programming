using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FamilyFeudProject
{
    public partial class FirstQuestion : Form
    {
        private int player1Chances = 3;
        private int player2Chances = 3;
        private int player1Points = 0;
        private int player2Points = 0;
        private Random random = new Random();
        private bool isPlayer1Turn;
        private string player1Name;
        private string player2Name;
        private List<string> answersOnBoard = new List<string>();
        private bool faceOffDone = false;


        string connectionString = "Server=192.168.1.41,1433;Database=familyFeud;User=YshikageOne;Password=clydelovejerra";

        private string[] answers = { "JavaScript", "Html/CSS", "Python", "SQL", "Java", "C#" };
        private int[] points = { 100, 90, 80, 70, 60, 50  };

        public FirstQuestion()
        {
            InitializeComponent();
        }

        //Methods that gets the names of the players
        private void FirstQuestion_Load(object sender, EventArgs e)
        {
            player1Name = InputPlayerName("Player 1");
            player2Name = InputPlayerName("Player 2");

            InsertPlayerName(player1Name);
            InsertPlayerName(player2Name);

            MessageBox.Show($"Welcome, {player1Name} and {player2Name}! Let's start the game.", "Family Feud");
            MessageBox.Show($"Face-Off, Who ever can get the higher score has the power of choice");

            isPlayer1Turn = random.Next(2) == 0;
            UpdatePlayerTurnLabel(isPlayer1Turn ? player1Name : player2Name);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                if (!faceOffDone)
                {
                    FaceOff();
                }
                else
                {
                    if (CheckAnswer())
                    {
                        int score = GetScore();
                        if (isPlayer1Turn)
                        {
                            player1Points += score;
                            MessageBox.Show($"{player1Name} got {player1Points}");
                        }

                        else
                        {
                            player2Points += score;
                            MessageBox.Show($"{player2Name} got {player2Points}");
                        }
                            

                        DisplayAnswerOnBoard(txtUserAnswer.Text.Trim().ToLower());

                        txtUserAnswer.Clear();
                    }
                    else
                    {
                        txtUserAnswer.Clear();
                    }
                }

                if (CheckGameOver())
                {
                    MessageBox.Show($"Game Over! {player1Name} scored {player1Points} points and {player2Name} scored {player2Points} points.");
                    AddScoresToTable();
                    this.Close(); // Close the form
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FaceOff()
        {
            string userAnswer = txtUserAnswer.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(userAnswer))
            {
                MessageBox.Show("Please enter an answer.");
                return;
            }

            if (CheckAnswer())
            {
                int score = GetScore();
                if (isPlayer1Turn)
                    player1Points += score;
                else
                    player2Points += score;

                MessageBox.Show($"{(isPlayer1Turn ? player1Name : player2Name)} answered correctly and scored {score} points!");

                DisplayAnswerOnBoard(userAnswer);
            }
            else
            {
                if (isPlayer1Turn)
                {
                    player1Chances--;
                    isPlayer1Turn = false;
                }
                else
                {
                    player2Chances--;
                    isPlayer1Turn = true;
                }

                txtUserAnswer.Text = "";
                UpdatePlayerTurnLabel(isPlayer1Turn ? player1Name : player2Name);

                MessageBox.Show("The other player gets a chance to answer.");
            }

            if (CheckGameOver())
            {
                MessageBox.Show($"Game Over! {player1Name} scored {player1Points} points and {player2Name} scored {player2Points} points.");
                AddScoresToTable();
                this.Close(); // Close the form
                return;
            }

            txtUserAnswer.Clear();
        }


        //Other Methods
        private bool CheckAnswer()
        {
            // Getting the answer
            String userInput = txtUserAnswer.Text.ToLower();

            // Check if the answer has already been answered
            if (answersOnBoard.Contains(userInput))
            {
                MessageBox.Show("This answer has already been answered.");
                return false;
            }

            // Iterate over each answer
            foreach (string answer in answers)
            {
                // Convert the answer to lower case for case insensitive comparison
                string lowerCaseAnswer = answer.ToLower();

                // Check if the user input matches the answer or its variants
                if (userInput == lowerCaseAnswer ||
                    (lowerCaseAnswer == "html/css" && (userInput == "html" || userInput == "css")))
                {
                    // Add the answer to the list of answered answers
                    answersOnBoard.Add(userInput);
                    return true;
                }
            }


            if (CheckGameOver())
            {
                MessageBox.Show($"Game Over! {player1Name} scored {player1Points} points and {player2Name} scored {player2Points} points.");
                AddScoresToTable();
                this.Close(); // Close the form
                return false; // Add this line
            }

            //If no match is found, return false
            return false;
        }

        //Getting their score
        private int GetScore()
        {
            //Convert the user input to lower case for case insensitive comparison
            String userInput = txtUserAnswer.Text.ToLower();

            //Iterate over each answer
            for (int i = 0; i < answers.Length; i++)
            {
                //Convert the answer to lower case for case insensitive comparison
                string lowerCaseAnswer = answers[i].ToLower();

                //Check if the user input matches the answer or its variants
                if (userInput == lowerCaseAnswer ||
                    (lowerCaseAnswer == "html/css" && (userInput == "html" || userInput == "css")))
                {
                    return points[i];
                }
            }

            //If no match is found, return 0
            return 0;
        }

        private void DisplayAnswerOnBoard(string answer)
        {
            // Convert the answer to lowercase
            string lowerCaseAnswer = answer.ToLower();

            switch (lowerCaseAnswer)
            {
                case "javascript":
                    txtAnswer1.Text = "JavaScript";
                    break;
                case "css":
                    txtAnswer2.Text = "HTML/CSS";
                    break;
                case "html":
                    txtAnswer2.Text = "HTML/CSS";
                    break;
                case "python":
                    txtAnswer3.Text = "Python";
                    break;
                case "sql":
                    txtAnswer4.Text = "SQL";
                    break;
                case "java":
                    txtAnswer5.Text = "Java";
                    break;
                case "c#":
                    txtAnswer6.Text = "C#";
                    break;

            }

        }

        private bool CheckGameOver()
        {
            if ((txtAnswer1.Text == "JavaScript") &&
               (txtAnswer2.Text == "HTML/CSS") &&
               (txtAnswer3.Text == "Python") &&
               (txtAnswer4.Text == "SQL") &&
               (txtAnswer5.Text == "Java") &&
               (txtAnswer6.Text == "C#"))
            {
                return true;
            }
            if (player1Chances == 0 && player2Chances == 0)
            {
                AddScoresToTable();
                return true;
            }
            return false;

        }



        private string InputPlayerName(string playerNumber)
        {
            return Microsoft.VisualBasic.Interaction.InputBox($"Enter the name for {playerNumber}:", "Player Name", "");
        }

        private void UpdatePlayerTurnLabel(string playerName)
        {
            txtPlayerTurn.Text = $"{playerName}'s TURN";
        }

        
        //Method that adds the name to the player database
        private void InsertPlayerName(string playerName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO ScoresTable (PlayerName) VALUES (@PlayerName)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@PlayerName", playerName);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        private void AddScoresToTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO ScoresTable (PlayerName, Score) VALUES (@PlayerName, @Score)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@PlayerName", player1Name);
                    command.Parameters.AddWithValue("@Score", player1Points);
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@PlayerName", player2Name);
                    command.Parameters.AddWithValue("@Score", player2Points);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

    }

}






