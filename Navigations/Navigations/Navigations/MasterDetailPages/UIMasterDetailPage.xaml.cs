using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Navigations.MasterDetailPages
{
    public partial class UIMasterDetailPage : MasterDetailPage
    {
        public UIMasterDetailPage()
        {
            InitializeComponent();
        }

        public void GoToPagina1(object sender, EventArgs e)
        {
            ChangeDetail(new Pagina1());
        }

        public void GoToPagina2(object sender, EventArgs e)
        {
            ChangeDetail(new Pagina2());
        }

        public void GoToPagina3(object sender, EventArgs e)
        {
            ChangeDetail(new Pagina3());
        }

        private void ChangeDetail(Page page)
        {
            var navigationPage = Detail as NavigationPage;
            if (navigationPage != null)
            {
                navigationPage.PushAsync(page);
                return;
            }
            Detail = page;
            IsPresented = false;
        }
    }
}
