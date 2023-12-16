using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace project
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Random random = new Random();
        Random randomKind = new Random();
        int Score = 0;
        int questionCount = 0;
        private DispatcherTimer questionTimer;


        public Window1(string Name)
        {
            InitializeComponent();
            NameResult.Text = Name;
            randomal();
            Wichsign();

            // Initialize and configure the question timer
            questionTimer = new DispatcherTimer();
            questionTimer.Interval = TimeSpan.FromSeconds(20); // Set the duration of the timer
            questionTimer.Tick += QuestionTimer_Tick;
        }
        private void QuestionTimer_Tick(object sender, EventArgs e)
        {
            // Timer logic for when the timer ticks
            questionTimer.Stop(); // Stop the timer
            DisplayNextQuestion(); // Move to the next question
        }





        private void DisplayNextQuestion()
        {
            if (questionCount < 10)
            {
                randomal();
                Wichsign();
                questionCount++;
                UpdateTimerText();
                // Start the question timer when displaying a new question
                questionTimer.Start();
            }
            else
            {
                // If there are no more questions, close the current window and show the result window
                string Name2 = NameResult.Text;
                Window2 hadash = new Window2(Score, Name2);
                hadash.Show();
                this.Close();
            }
        }

        private void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            // Start the question timer when the window is loaded
            questionTimer.Start();
            UpdateTimerText(); // Update the timer text when the window is loaded
        }

        private void UpdateTimerText()
        {
            // Update the TextBlock with the remaining time
            TimerTextBlock.Text = $"Time: {questionTimer.Interval.TotalSeconds} seconds";
        }




        public void randomal()
        {
           
           
                int rnd1 = random.Next(0, 31);
                int rnd2 = random.Next(0, 31);
                num1.Text = rnd1.ToString();
                num2.Text = rnd2.ToString();
        }
 

        private void Wichsign()
        { 
            int kind = randomKind.Next(1, 4);
            if (kind == 1)
            {
                sign.Text = "+";
            }
            else if (kind == 2)
            {
                sign.Text = "-";
            }
            else if (kind == 3)
            {
                sign.Text = "*";
            }
        }



        private void cheking(object sender, RoutedEventArgs e)
        {
            
            try
            {
                int correctAnswer = 0;
                int answer = int.Parse(Answer.Text);
                int count = 1;
                QuestionCount.Text = count.ToString();
                count++;

                if (sign.Text == "+")
                {
                    correctAnswer = int.Parse(num1.Text) + int.Parse(num2.Text);
                }
                else if (sign.Text == "-")
                {
                    int num1Value = int.Parse(num1.Text);
                    int num2Value = int.Parse(num2.Text);
                    correctAnswer = num1Value - num2Value;
                }

                else if (sign.Text == "*")
                {
                    correctAnswer = int.Parse(num1.Text) * int.Parse(num2.Text);
                }
                double greenValue = progressBar.Maximum * 0.1;
                double redValue = progressBar.Maximum * 0.1;
                if (correctAnswer == answer)
                {
                    MessageBox.Show("Correct"+ " Good job" +" "+ NameResult.Text);
                    progressBar.Foreground = Brushes.Green;

                    // Adjust the value to add 10% of the progress bar in green
                    progressBar.Value = Math.Min(progressBar.Value + greenValue, progressBar.Maximum);
                    this.Score += 10;   

                }
                else
                {
                    MessageBox.Show("Incorrect");
                    progressBar.Foreground = Brushes.Red;


                    // Adjust the value to add 10% of the progress bar in red
                    progressBar.Value = Math.Min(progressBar.Value + redValue, progressBar.Maximum);
                    if(Score != 0)
                    {
                        this.Score -= 10;

                    }

                }



                // Display the next question
                DisplayNextQuestion();
            }
            catch
            {
                MessageBox.Show("Enter a valid number");
            }
        }



    }
     

        // ... (rest of the code)

        // Example: Call this method when a button is clicked
        





    }


