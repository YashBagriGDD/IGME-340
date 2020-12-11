using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CallingWebService {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage {
        public AboutPage() {
            InitializeComponent();
        }

        private async void OpenPrivacy(object sender, EventArgs e) {
            await Browser.OpenAsync("https://policies.google.com/privacy?hl=en-US", BrowserLaunchMode.SystemPreferred);
        }
    }
}