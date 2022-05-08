using ShopApp.Siniflar;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace ShopApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sepet : ContentPage
    {
        public Sepet()
        {
            InitializeComponent();
            UrunleriGetir();
            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {
                UrunleriGetir();
                return true;
            }));
        }
        async void UrunleriGetir()
        {
            Database database = Database.Instance();
            var data = await database.SepetiGetir();
            sepetsutun.ItemsSource = data;
            sepetsutun.BindingContext = data;
            Adet.Text = data.Count + " ADET";
            sepetsutun.HeightRequest = data.Count * 270;
        }
        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            ImageButton frame = (ImageButton)sender;
            Urun img = (Urun)frame.CommandParameter;

            Database database = Database.Instance();
            await database.SepettenSil(img.UrunIsim);
            await DisplayAlert("BAŞARILI", "ÜRÜN SEPETTEN SİLİNDİ", "TAMAM");
            UrunleriGetir();
        }
        private void GeriAl(object sender, EventArgs e)
        {
            TappedHome.instance.Navigation.PopAsync();
        }
        private async void GirisYap(object sender, EventArgs e)
        {
            await TappedHome.instance.Navigation.PushAsync(new GirisYap());
        }
    }
}