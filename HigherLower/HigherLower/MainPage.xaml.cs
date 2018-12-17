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
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            RandomNumberPrevious = random.Next(1, 52);
            RandomNum.Text = RandomNumberPrevious.ToString();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            SliderValue.Text = Slider.Value.ToString();
        }

        private void Higher_Clicked(object sender, EventArgs e)
        {
            RandomNumberPrevious = RandomNumberNext;
            RandomNumberNext = random.Next(1, 52);
            RandomNum.Text = RandomNumberNext.ToString();

            if(RandomNumberNext > RandomNumberPrevious)
            {
                hilo.Text = "Correct, it was higher. You got another " + (Slider.Value * 2) + " points!";
                points += (Slider.Value * 2);
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
            RandomNum.Text = RandomNumberNext.ToString();

            if (RandomNumberNext < RandomNumberPrevious)
            {
                hilo.Text = "Correct, it was lower. You got another " + (Slider.Value*2) + " points!";
                points += (Slider.Value*2);
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
