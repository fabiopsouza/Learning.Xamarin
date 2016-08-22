using System;
using Xamarin.Forms;

namespace Navigations.ContentPages
{
    public partial class UIContentPage2 : ContentPage
    {
        public UIContentPage2()
        {
            InitializeComponent();
        }
        
        public async void DoCloseModal(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PopModalAsync(true);
            }
            catch(Exception ex) { }
        }
    }
}
