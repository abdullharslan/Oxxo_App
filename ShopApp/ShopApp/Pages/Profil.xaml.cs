using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profil : ContentPage
    {
        public Profil()
        {
            InitializeComponent();
        }
        private async void GirisYap(object sender, EventArgs e)
        {
            await TappedHome.instance.Navigation.PushAsync(new GirisYap());
        }
        private async void AramaButon(object sender, EventArgs e)
        {
            await TappedHome.instance.Navigation.PushAsync(new Arama());
        }
        private async void SepetButton(object sender, EventArgs e)
        {
            await TappedHome.instance.Navigation.PushAsync(new Sepet());
        }
        private async void KategoriButton(object sender, EventArgs e)
        {
            TappedHome.instance.CurrentPage = TappedHome.instance.Children[1];
        }
    }
}