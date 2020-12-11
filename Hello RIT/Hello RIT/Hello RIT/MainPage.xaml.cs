using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hello_RIT {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();

            var topLabel = new Label();
            var bottomLabel = new Label();
            var nameLabel = new Label();

            topLabel.Text = "Hello";
            topLabel.FontSize = 36;
            topLabel.Margin = new Thickness(100, 40, 0, 0);

            bottomLabel.Text = "RIT";
            bottomLabel.FontSize = 48;
            bottomLabel.HorizontalTextAlignment = TextAlignment.Center;

            nameLabel.Text = "Yash Bagri";
            nameLabel.FontSize = 20;
            nameLabel.VerticalOptions = LayoutOptions.End;
            nameLabel.TextColor = Color.DarkGray;

            mainStack.Children.Add(topLabel);
            mainStack.Children.Add(bottomLabel);
            mainStack.Children.Add(nameLabel);
            BackgroundColor = Color.Orange;

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += async (s, e) => {
                await topLabel.TranslateTo(50, 200, 2000, Easing.BounceOut);
            };
            tapGestureRecognizer.Tapped += async (s, e) => {
                await bottomLabel.TranslateTo(100, 500, 5000, Easing.BounceIn);
            };
            mainStack.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}
