using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TerminalHacking
{
    public partial class GuessPinCode : Form
    {
        private string wordToGuess;
        private List<string> words;
        private Label[] labels;
        private TextBox textBoxInput;
        private Button runButton;
        private Button returnButton;
        private TextBox scoreMessage;
        private Label atteptShow;
        private Label resultMessage;
        private int attempts = 4;
        private bool isWin = false;

        public GuessPinCode()
        {
            InitializeComponent();
        }

        private void buttonVeryEasy_Click(object sender, EventArgs e)
        {
            ProccesGame("5letters.txt");
        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            ProccesGame("7letters.txt");
        }

        private void buttonAvarage_Click(object sender, EventArgs e)
        {
            ProccesGame("9letters.txt");
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            ProccesGame("11letters.txt");
        }

        private void buttonVeryHard_Click(object sender, EventArgs e)
        {
            ProccesGame("12letters.txt");
        }

        private void ProccesGame(string fileName)
        {
            ClearForm();
            ChooseWords(fileName);
            GameLaunch();
            ClickLabel();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            RemoveAllItems(sender, e);
            ShowFirstMenu();
        }

        private void ShowFirstMenu()
        {
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);
            this.Controls.Add(button4);
            this.Controls.Add(button5);
            this.Controls.Add(button6);
            this.Controls.Add(label1);
        }

        private void RemoveAllItems(object sender, EventArgs e)
        {
            isWin = false;
            attempts = 4;
            words = new List<string>();
            foreach (Label label in labels)
            {
                label.Dispose();
                this.Controls.Remove(label);
            }
            textBoxInput.Dispose();
            runButton.Dispose();
            scoreMessage.Dispose();
            atteptShow.Dispose();
            resultMessage.Dispose();
            returnButton.Dispose();
        }
        private void ClearForm()
        {
            this.Controls.Remove(button1);
            this.Controls.Remove(button2);
            this.Controls.Remove(button3);
            this.Controls.Remove(button4);
            this.Controls.Remove(button5);
            this.Controls.Remove(button6);
            this.Controls.Remove(label1);
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (isWin || attempts <= 0)
                return;
            if (attempts > 0)
            {
                scoreMessage.Text = GetScore();
                if (IsWin(GetScore()))
                {
                    ShowResultMessage("You are win!",255);
                    isWin = true;
                }
                attempts--;
                ShowAttemptMesage();
            } 
            if (!isWin && attempts <= 0)
                ShowResultMessage("Attempts are over, game over!", 205);
        }

        private void ShowAttemptMesage()
        {
            atteptShow.Text = "Click on the word you want to select. Attempt(s) left: " + attempts;
            atteptShow.Location = new Point(20, 20);
            atteptShow.ForeColor = Color.Lime;
        }

        private void ShowResultMessage(string message, int locationOnX)
        {
            resultMessage = new Label();
            resultMessage.Location = new Point(locationOnX, 280);
            resultMessage.AutoSize = true;
            this.Controls.Add(resultMessage);
            resultMessage.Text = message;
            resultMessage.ForeColor = Color.Lime;
            returnButton = new Button();
            this.Controls.Add(returnButton);
            returnButton.Text = "To main menu";
            returnButton.ForeColor = Color.Lime;
            returnButton.Size = new Size(100, 27);
            returnButton.Location = new Point(470, 300);
            returnButton.Click += new System.EventHandler(this.returnButton_Click);
        }

        private void ChooseWords(string fileName)
        {
            Random random = new Random();
            string[] allWords = File.ReadAllLines(fileName);
            wordToGuess = allWords[random.Next(allWords.Length)];
            int countOfWords = GetCountOfWords(fileName);
            allWords = allWords.OrderByDescending(item => FindCommonChars(item, wordToGuess))
                                    .ToArray();
            HashSet<string> wordsWithoutRepeating = new HashSet<string>();
            wordsWithoutRepeating.Add(wordToGuess);
            while (wordsWithoutRepeating.Count != countOfWords)
            {
                wordsWithoutRepeating.Add(allWords[random.Next(100)]);
            }
            words = new List<string>(wordsWithoutRepeating)
                   .OrderBy(x => random.Next()).ToList();
        }

        private int GetCountOfWords(string fileName)
        {
            int countOfWords = 0;
            switch (fileName)
            {
                case "5letters.txt":
                    countOfWords = 10;
                    break;
                case "7letters.txt":
                    countOfWords = 11;
                    break;
                case "9letters.txt":
                    countOfWords = 14;
                    break;
                case "11letters.txt":
                    countOfWords = 10;
                    break;
                case "12letters.txt":
                    countOfWords = 11;
                    break;

            }
            return countOfWords;
        }

        private int FindCommonChars(string s1, string s2)
        {
            int commonChars = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[i])
                    commonChars++;
            }
            return commonChars;
        }

        private void GameLaunch()
        {
            Label[] labels = new Label[words.Count];
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                this.Controls.Add(labels[i]);
                labels[i].Text = words[i];
                labels[i].ForeColor = Color.Lime;
                labels[i].AutoSize = true;
                labels[i].Location = new Point(20, 50 + i * 20);
            }
            this.labels = labels;
            atteptShow = new Label();
            atteptShow.Text = "Click on the word you want to select. Attempt(s) left: " + attempts;
            atteptShow.ForeColor = Color.Lime;
            atteptShow.Location = new Point(20, 20);
            atteptShow.AutoSize = true;
            this.Controls.Add(atteptShow);
            textBoxInput = new TextBox();
            textBoxInput.BackColor = Color.Black;
            textBoxInput.ForeColor = Color.Lime;
            textBoxInput.TextAlign = HorizontalAlignment.Center;
            this.Controls.Add(textBoxInput);
            textBoxInput.Location = new Point(130, 300);
            textBoxInput.ReadOnly = true;
            runButton = new Button();
            runButton.Text = "▶";
            runButton.ForeColor = Color.Lime;
            this.Controls.Add(runButton);
            runButton.Location = new Point(250, 300);
            scoreMessage = new TextBox();
            scoreMessage.ReadOnly = true;
            this.Controls.Add(scoreMessage);
            scoreMessage.Location = new Point(350, 300);
            scoreMessage.BackColor = Color.Black;
            scoreMessage.ForeColor = Color.Lime;
            scoreMessage.TextAlign = HorizontalAlignment.Center;
            runButton.Click += new System.EventHandler(this.runButton_Click);
        }

        private bool IsWin(string score)
        {
            string[] scores = score.Split('\\');
            return scores[0].Equals(scores[1]);
        }

        private string GetScore()
        {
            string userInput = textBoxInput.Text;
            int commonChars = FindCommonChars(userInput, wordToGuess);
            return $"{commonChars}\\{wordToGuess.Length}";
        }

        private void ClickLabel()
        {
            foreach(Label label in labels)
            {
                label.Click += delegate 
                {
                    textBoxInput.Text = label.Text;
                };
            }
        }
    }
}
