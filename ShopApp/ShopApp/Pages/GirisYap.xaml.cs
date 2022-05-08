using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GirisYap : ContentPage
    {
        public GirisYap()
        {
            InitializeComponent();
            GirisYapStack.IsVisible = true;
            KayitOlStack.IsVisible = false;
        }
        private void Giris_Clicked(object sender, EventArgs e)
        {
            GirisYapStack.IsVisible = true;
            KayitOlStack.IsVisible = false;
            GirisCizgi.BackgroundColor = Color.Black;
            KayitCizgi.BackgroundColor = Color.Gray;
        }
        private void Uye_Clicked(object sender, EventArgs e)
        {
            GirisYapStack.IsVisible = false;
            KayitOlStack.IsVisible = true;
            GirisCizgi.BackgroundColor = Color.Gray;
            KayitCizgi.BackgroundColor = Color.Black;
        }
        private void GeriAl(object sender, EventArgs e)
        {
            TappedHome.instance.Navigation.PopAsync();
        }
    }
}