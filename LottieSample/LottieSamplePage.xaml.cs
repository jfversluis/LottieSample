using Xamarin.Forms;

namespace LottieSample
{
    public partial class LottieSamplePage : ContentPage
    {
        public LottieSamplePage()
        {
            InitializeComponent();
        }

        private void Handle_Clicked(object sender, System.EventArgs e)
        {
            lottie.Play();
        }

        private void Handle1_Clicked(object sender, System.EventArgs e)
        {
            lottie.Pause();
        }
    }
}
