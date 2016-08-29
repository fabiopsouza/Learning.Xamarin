using Navigations.CarouselPages;
using Navigations.MasterDetailPages;
using Navigations.TappedPages;
using System;
using Xamarin.Forms;

namespace Navigations.ContentPages
{
    public partial class UIContentPage : ContentPage
    {
        public UIContentPage()
        {
            InitializeComponent();
        }

        public async void DoPushAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UIContentPage2());
        }

        public async void DoPushModalAsync(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new UIContentPage2());
        }

        public async void GoToTabbedPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UITappedPage());
        }
        
        public async void GoToCarouselPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UICarouselPage());
        }

        public async void GoToMasterDetailPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UIMasterDetailPage());
        }
    }
}
