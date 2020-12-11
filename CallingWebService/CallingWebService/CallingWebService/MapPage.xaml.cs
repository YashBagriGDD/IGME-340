using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace CallingWebService {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage {
        public MapPage(MainPageViewModel vm) {
            InitializeComponent();
            BindingContext = vm;

            // Map setup
            map.MapType = MapType.Street;

            Position startPos = new Position(43.08468, -77.67469);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(startPos, Distance.FromKilometers(1)));

            //Loop through the sent data and add each one as a pin to the map
            foreach (var item in vm.Data) {
                Pin pin = new Pin {
                    Label = item.studio,
                    Address = item.name,
                    Type = PinType.Place,
                    Position = new Position(item.longitude, item.latitude)
                };

                map.Pins.Add(pin);
            }
        }
    }
}