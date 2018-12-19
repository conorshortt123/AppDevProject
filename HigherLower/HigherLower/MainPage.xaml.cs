using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HigherLower
{
    public partial class MainPage : ContentPage
    {
        public int points = 20;
        public int highScore;
        Random random = new Random();

        public int RandomNumber;
        public int RandomNumberNext;

        int initCardValue;
        int nextCardValue;
   
        public MainPage()
        {
            InitializeComponent();

            SliderValue.Text = 0.ToString();

            Points.Text = "Your points: " + points;

            if (points > highScore)
            {
                highScore = points;
                HighScore.Text = "High Score: " + highScore;
            }

            Slider.Maximum = points;

            
            Card.Source = ImageSource.FromResource("HigherLower.Images.gray_back.png");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            RandomNumber = random.Next(1, 52);

            ChangeImage(RandomNumber);

            initCardValue = GetCardValue1(RandomNumber);
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            SliderValue.Text = ((int)Slider.Value).ToString();
        }

        private void Higher_Clicked(object sender, EventArgs e)
        {
            RandomNumber = random.Next(1, 52);
            
            ChangeImage(RandomNumber);

            nextCardValue = GetCardValue2(RandomNumber);

            if(nextCardValue > initCardValue)
            {
                hilo.Text = "Correct, it was higher. You got another " + (int)(Slider.Value) + " points!";
                points += (int)(Slider.Value);
                Slider.Maximum = points;
                Points.Text = "Your points: " + points;
                if(points>highScore)
                {
                    highScore = points;
                    HighScore.Text = "High Score: " + highScore;
                }
            }
            else if(nextCardValue == initCardValue)
            {
                hilo.Text = "Card values are equal! Try again.";
            }
            else if(nextCardValue < initCardValue)
            {
                hilo.Text = "Unlucky! You lost " + (int)Slider.Value + " points!";
                points -= (int)Slider.Value;
                if (points <= 0)
                {
                    DisplayAlert("You lost.", "Unfortunately you lost all of your points. Press OK to reset and start a new game.", "OK");

                    Card.Source = ImageSource.FromResource("HigherLower.Images.gray_back.png");

                    points = 20;

                    hilo.Text = "";
                }
                Slider.Maximum = points;
                Points.Text = "Your points: " + points;
            }

            initCardValue = nextCardValue;      
        }

        private void Lower_Clicked(object sender, EventArgs e)
        {
            RandomNumber = random.Next(1, 52);

            ChangeImage(RandomNumber);

            nextCardValue = GetCardValue2(RandomNumber);

            if (initCardValue > nextCardValue)
            {
                hilo.Text = "Correct, it was lower. You got another " + (int)(Slider.Value) + " points!";
                points += (int)(Slider.Value);
                Slider.Maximum = points;
                Points.Text = "Your points: " + points;
                if (points > highScore)
                {
                    highScore = points;
                    HighScore.Text = "High Score: " + highScore;
                }
            }
            else if (nextCardValue == initCardValue)
            {
                hilo.Text = "Card values are equal! Try again.";
            }
            else if(initCardValue < nextCardValue)
            {
                hilo.Text = "Unlucky! You lost " + (int)Slider.Value + " points!";
                points -= (int)Slider.Value;
                if (points <= 0)
                {
                    DisplayAlert("You lost.", "Unfortunately you lost all of your points. Press OK to reset and start a new game.", "OK");

                    Card.Source = ImageSource.FromResource("HigherLower.Images.gray_back.png");

                    points = 20;

                    hilo.Text = "";
                }
                Slider.Maximum = points;
                Points.Text = "Your points: " + points;
            }

            initCardValue = nextCardValue;
        }

        void ChangeImage(int RandomNumber)
        {
            switch (RandomNumber)
            {
                case 1:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.2C.png");
                    break;
                case 2:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.2D.png");
                    break;
                case 3:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.2H.png");
                    break;
                case 4:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.2S.png");
                    break;
                case 5:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.3C.png");
                    break;
                case 6:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.3D.png");
                    break;
                case 7:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.3H.png");
                    break;
                case 8:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.3S.png");
                    break;
                case 9:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.4C.png");
                    break;
                case 10:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.4D.png");
                    break;
                case 11:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.4H.png");
                    break;
                case 12:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.4S.png");
                    break;
                case 13:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.5C.png");
                    break;
                case 14:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.5D.png");
                    break;
                case 15:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.5H.png");
                    break;
                case 16:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.5S.png");
                    break;
                case 17:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.6C.png");
                    break;
                case 18:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.6D.png");
                    break;
                case 19:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.6H.png");
                    break;
                case 20:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.6S.png");
                    break;
                case 21:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.7C.png");
                    break;
                case 22:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.7D.png");
                    break;
                case 23:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.7H.png");
                    break;
                case 24:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.7S.png");
                    break;
                case 25:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.8C.png");
                    break;
                case 26:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.8D.png");
                    break;
                case 27:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.8H.png");
                    break;
                case 28:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.8S.png");
                    break;
                case 29:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.9C.png");
                    break;
                case 30:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.9D.png");
                    break;
                case 31:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.9H.png");
                    break;
                case 32:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.9S.png");
                    break;
                case 33:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.10C.png");
                    break;
                case 34:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.10D.png");
                    break;
                case 35:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.10H.png");
                    break;
                case 36:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.10S.png");
                    break;
                case 37:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.JC.png");
                    break;
                case 38:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.JD.png");
                    break;
                case 39:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.JH.png");
                    break;
                case 40:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.JS.png");
                    break;
                case 41:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.QC.png");
                    break;
                case 42:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.QD.png");
                    break;
                case 43:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.QH.png");
                    break;
                case 44:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.QS.png");
                    break;
                case 45:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.KC.png");
                    break;
                case 46:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.KD.png");
                    break;
                case 47:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.KH.png");
                    break;
                case 48:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.KS.png");
                    break;
                case 49:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.AC.png");
                    break;
                case 50:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.AD.png");
                    break;
                case 51:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.AH.png");
                    break;
                case 52:
                    Card.Source = ImageSource.FromResource("HigherLower.Images.AS.png");
                    break;
            }
        }

        int GetCardValue1(int RandomNumber)
        {
            if (RandomNumber >= 1 && RandomNumber <= 4)
            {
                initCardValue = 1;
            }
            else if (RandomNumber >= 5 && RandomNumber <= 8)
            {
                initCardValue = 2;
            }
            else if (RandomNumber >= 9 && RandomNumber <= 12)
            {
                initCardValue = 3;
            }
            else if (RandomNumber >= 13 && RandomNumber <= 16)
            {
                initCardValue = 4;
            }
            else if (RandomNumber >= 17 && RandomNumber <= 20)
            {
                initCardValue = 5;
            }
            else if (RandomNumber >= 21 && RandomNumber <= 24)
            {
                initCardValue = 6;
            }
            else if (RandomNumber >= 25 && RandomNumber <= 28)
            {
                initCardValue = 7;
            }
            else if (RandomNumber >= 29 && RandomNumber <= 32)
            {
                initCardValue = 8;
            }
            else if (RandomNumber >= 33 && RandomNumber <= 36)
            {
                initCardValue = 9;
            }
            else if (RandomNumber >= 37 && RandomNumber <= 40)
            {
                initCardValue = 10;
            }
            else if (RandomNumber >= 41 && RandomNumber <= 44)
            {
                initCardValue = 11;
            }
            else if (RandomNumber >= 45 && RandomNumber <= 48)
            {
                initCardValue = 12;
            }
            else if (RandomNumber >= 49 && RandomNumber <= 52)
            {
                initCardValue = 13;
            }

            return initCardValue;
        }

        int GetCardValue2(int RandomNumber)
        {
            if (RandomNumber >= 1 && RandomNumber <= 4)
            {
                nextCardValue = 1;
            }
            else if (RandomNumber >= 5 && RandomNumber <= 8)
            {
                nextCardValue = 2;
            }
            else if (RandomNumber >= 9 && RandomNumber <= 12)
            {
                nextCardValue = 3;
            }
            else if (RandomNumber >= 13 && RandomNumber <= 16)
            {
                nextCardValue = 4;
            }
            else if (RandomNumber >= 17 && RandomNumber <= 20)
            {
                nextCardValue = 5;
            }
            else if (RandomNumber >= 21 && RandomNumber <= 24)
            {
                nextCardValue = 6;
            }
            else if (RandomNumber >= 25 && RandomNumber <= 28)
            {
                nextCardValue = 7;
            }
            else if (RandomNumber >= 29 && RandomNumber <= 32)
            {
                nextCardValue = 8;
            }
            else if (RandomNumber >= 33 && RandomNumber <= 36)
            {
                nextCardValue = 9;
            }
            else if (RandomNumber >= 37 && RandomNumber <= 40)
            {
                nextCardValue = 10;
            }
            else if (RandomNumber >= 41 && RandomNumber <= 44)
            {
                nextCardValue = 11;
            }
            else if (RandomNumber >= 45 && RandomNumber <= 48)
            {
                nextCardValue = 12;
            }
            else if (RandomNumber >= 49 && RandomNumber <= 52)
            {
                nextCardValue = 13;
            }

            return nextCardValue;
        }
    }
}
