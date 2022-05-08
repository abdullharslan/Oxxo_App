using ShopApp.Siniflar;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrunDetayi : ContentPage
    {
        Urun UrunIsmi;
        public UrunDetayi(Urun urunismi)
        {
            InitializeComponent();
            UrunIsmi = urunismi;
            DatalariCek();
        }
        void DatalariCek()
        {
            var images = new List<string>();
            images.Add(UrunIsmi.UrunUrl);
            UrunTitle.Text = UrunIsmi.UrunIsim;
            fiyattext.Text = UrunIsmi.UrunFiyat;
            ResimListesi.ItemsSource = images;
        }
        private async void SepeteEkle(object sender, EventArgs e)
        {
            Database data = Database.Instance();
            await data.SepeteEkle(UrunIsmi);
            await DisplayAlert("BAŞARILI", "SEPET ÜRÜNE EKLENDİ", "TAMAM");
        }
        private async void AramaButon(object sender, EventArgs e)
        {
            await TappedHome.instance.Navigation.PushAsync(new Arama());
        }
        private async void SepetButton(object sender, EventArgs e)
        {
            await TappedHome.instance.Navigation.PushAsync(new Sepet());
        }
        private async void GeriButton(object sender, EventArgs e)
        {
            TappedHome.instance.Navigation.PopAsync();
        }
    }
}