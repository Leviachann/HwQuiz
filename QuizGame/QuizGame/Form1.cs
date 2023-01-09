using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class Form1 : Form
    {
        //variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int rightAnswers;
        int totalQuestions=10;

        public Form1()
        {
            InitializeComponent();
            AskQuestion(questionNumber);
        }
        
        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject=(Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            var rightans = (Button)sender;
            if (buttonTag == correctAnswer)
            {
                score += 10;
                rightAnswers+=1;
            }
            else
            {
                
                if ((score-10)> 0) { score -= 10; }
                if (Convert.ToInt32(Ans1.Tag) == correctAnswer)
                {
                    rightans = Ans1;
                }
                else if (Convert.ToInt32(Ans2.Tag) == correctAnswer)
                {
                 
                    rightans = Ans2;
                }
                else if (Convert.ToInt32(Ans3.Tag) == correctAnswer)
                {
                 
                    rightans = Ans3;
                }
                else if (Convert.ToInt32(Ans4.Tag) == correctAnswer)
                {
                    
                    rightans = Ans4;
                }
            }
            if (questionNumber == 10)
            {
                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + rightAnswers + " questions correctly." + Environment.NewLine +
                    "You're score is " + score  + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                AskQuestion(questionNumber);
            }
            LblQuestion.Text="Next Question..";
            TestCorrect();
            async Task TestCorrect()
            {
                await Task.Run(async () =>
                {
                    rightans.BackColor = Color.Green;
                    if (rightans != senderObject) {
                        senderObject.BackColor = Color.Red;
                    }
                    await Task.Delay(300);
                    senderObject.BackColor = Color.White;
                    rightans.BackColor = Color.White;
                });
                Console.WriteLine("All done");
            }
            
            questionNumber++;
            AskQuestion(questionNumber);
            

        }

        private void AskQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.genshinimpact;
                    LblQuestion.Text = "What is the name of this game?";
                    Ans1.Text = "Genshin Impact";
                    Ans2.Text = "Grand Theft Auto V";
                    Ans3.Text = "Legend Of Zelda: Breath of the wild";
                    Ans4.Text = "Tower of Fantasy";
                    correctAnswer = 1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.dragonspine;
                    LblQuestion.Text = "Which region was the first one released?";
                    Ans1.Text = "Sumeru";
                    Ans2.Text = "Liyue";
                    Ans3.Text = "Inazuma";
                    Ans4.Text = "Mondstadt";
                    correctAnswer = 4;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.sumeru;
                    LblQuestion.Text = "What is the name of this region?";
                    Ans1.Text = "Teyvat";
                    Ans2.Text = "Fontaine";
                    Ans3.Text = "Sumeru";
                    Ans4.Text = "Dragonspine";
                    correctAnswer = 3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.rexlapis;
                    LblQuestion.Text = "What is the name of the Geo Archon?";
                    Ans1.Text = "Paimon";
                    Ans2.Text = "Rex Lapis";
                    Ans3.Text = "Venti";
                    Ans4.Text = "Raiden Shogun";
                    correctAnswer = 2;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.cryo;
                    LblQuestion.Text = "What element does she use?";
                    Ans1.Text = "Pyro";
                    Ans2.Text = "Cryo";
                    Ans3.Text = "Anemo";
                    Ans4.Text = "Hydro";
                    correctAnswer = 2;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.zombie;
                    LblQuestion.Text = "What creature is she?";
                    Ans1.Text = "Archon";
                    Ans2.Text = "Adeptus";
                    Ans3.Text = "Zombie";
                    Ans4.Text = "Fatui";
                    correctAnswer = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.hydroabyssmage;
                    LblQuestion.Text = "What is the name of the enemy?";
                    Ans1.Text = "Matachurl";
                    Ans2.Text = "Hilichurl";
                    Ans3.Text = "Ruin Guard";
                    Ans4.Text = "Hydro Abyss Mage";
                    correctAnswer = 4;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.faruzan;
                    LblQuestion.Text = "When was she released?";
                    Ans1.Text = "3.3";
                    Ans2.Text = "4.2";
                    Ans3.Text = "2.6";
                    Ans4.Text = "1.5";
                    correctAnswer = 1;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.jean;
                    LblQuestion.Text = "What is her sister's name?";
                    Ans1.Text = "Barbara";
                    Ans2.Text = "Jean";
                    Ans3.Text = "Wanderer";
                    Ans4.Text = "Lumine";
                    correctAnswer = 2;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.fromashesreborn;
                    LblQuestion.Text = "What was his featured banner name?";
                    Ans1.Text = "From Ashes Reborn";
                    Ans2.Text = "Azure Excursion";
                    Ans3.Text = "Reign of Serenity";
                    Ans4.Text = "Leaves in the wind";
                    correctAnswer = 1;
                    break;

            }


        }
    }
}
