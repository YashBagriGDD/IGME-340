using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CallingWebService
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void MoveAboutPage(object sender, EventArgs e) {
            await Navigation.PushAsync(new AboutPage());
        }

        private async void MakeMap(object sender, EventArgs e) {
            await Navigation.PushAsync(new MapPage((MainPageViewModel)this.BindingContext));
        }
    }
}
