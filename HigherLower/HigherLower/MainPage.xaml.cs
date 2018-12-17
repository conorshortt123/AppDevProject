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
        public int points = 200;
        public int RandomNumber1;
        public int RandomNumber2;

        public MainPage()
        {
            InitializeComponent();
            SliderValue.Text = 0.ToString();
            Points.Text = "Your points: " + points;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            RandomNumber1 = random.Next(1, 52);
            RandomNum.Text = RandomNumber1.ToString();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            SliderValue.Text = Slider.Value.ToString();
        }

        private void Higher_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}
