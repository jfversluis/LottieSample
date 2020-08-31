using System;
using Xamarin.Forms;

namespace LottieSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void HandlePlay_Clicked(object sender, EventArgs e)
        {
            lottie.Play();
        }

        void HandlePause_Clicked(object sender, EventArgs e)
        {
            lottie.Pause();
        }
    }
}