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
        public double points = 20;
        public int RandomNumberPrevious;
        public int RandomNumberNext;

        Random random = new Random();

        public MainPage()
        {
            InitializeComponent();
            SliderValue.Text = 0.ToString();
            Points.Text = "Your points: " + points;
            Slider.Maximum = points;

            Card.Source = ImageSource.FromResource("HigherLower.Images.gray_back.png");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            RandomNumberPrevious = random.Next(1, 53);

            int cardValue;

            if (RandomNumberPrevious >= 1 && RandomNumberPrevious <= 4)
            {
                cardValue = 1;
            }
            else if(RandomNumberPrevious >= 5 && RandomNumberPrevious <= 8)
            {
                cardValue = 2;
            }
            else if (RandomNumberPrevious >= 9 && RandomNumberPrevious <= 12)
            {
                cardValue = 3;
            }
            else if (RandomNumberPrevious >= 13 && RandomNumberPrevious <= 16)
            {
                cardValue = 4;
            }
            else if (RandomNumberPrevious >= 17 && RandomNumberPrevious <= 20)
            {
                cardValue = 5;
            }
            else if (RandomNumberPrevious >= 21 && RandomNumberPrevious <= 24)
            {
                cardValue = 6;
            }
            else if (RandomNumberPrevious >= 25 && RandomNumberPrevious <= 28)
            {
                cardValue = 7;            
            }
            else if (RandomNumberPrevious >= 29 && RandomNumberPrevious <= 32)
            {
                cardValue = 8;
            }
            else if (RandomNumberPrevious >= 33 && RandomNumberPrevious <= 36)
            {
                cardValue = 9;
            }
            else if (RandomNumberPrevious >= 37 && RandomNumberPrevious <= 40)
            {
                cardValue = 10;
            }
            else if (RandomNumberPrevious >= 41 && RandomNumberPrevious <= 44)
            {
                cardValue = 11;
            }
            else if (RandomNumberPrevious >= 45 && RandomNumberPrevious <= 48)
            {
                cardValue = 12;
            }
            else if (RandomNumberPrevious >= 49 && RandomNumberPrevious <= 52)
            {
                cardValue = 13;
            }

            switch (RandomNumberPrevious)
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

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            SliderValue.Text = Slider.Value.ToString();
        }

        private void Higher_Clicked(object sender, EventArgs e)
        {
            RandomNumberPrevious = RandomNumberNext;
            RandomNumberNext = random.Next(1, 52);

            if(RandomNumberNext > RandomNumberPrevious)
            {
                hilo.Text = "Correct, it was higher. You got another " + (Slider.Value * 1.5) + " points!";
                points += (Slider.Value * 1.5);
                Slider.Maximum = points;
                Points.Text = "Your points: " + points;
            }
            else
            {
                hilo.Text = "Unlucky! You lost " + Slider.Value + " points!";
                points -= Slider.Value;
                Slider.Maximum = points;
                Points.Text = "Your points: " + points;
            }
        }

        private void Lower_Clicked(object sender, EventArgs e)
        {
            RandomNumberPrevious = RandomNumberNext;
            RandomNumberNext = random.Next(1, 52);

            if (RandomNumberNext < RandomNumberPrevious)
            {
                hilo.Text = "Correct, it was lower. You got another " + (Slider.Value*1.5) + " points!";
                points += (Slider.Value*1.5);
                Slider.Maximum = points;
                Points.Text = "Your points: " + points;
            }
            else
            {
                hilo.Text = "Unlucky! You lost " + Slider.Value + " points!";
                points -= Slider.Value;
                Slider.Maximum = points;
                Points.Text = "Your points: " + points;
            }
        }
    }
}
