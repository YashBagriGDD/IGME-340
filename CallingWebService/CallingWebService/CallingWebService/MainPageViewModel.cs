using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CallingWebService
{
    public class MainPageViewModel
    {
        public ObservableCollection<Details> Data { get; set; }

        public ICommand SearchCommand { get; set; }
        public ICommand SearchMoreCommand { get; set; }
        public ICommand ClearCommand { get; set; }

        public MainPageViewModel()
        {
            Data = new ObservableCollection<Details>();

            SearchCommand = new Command(async() => {
                // put web service call here
                //Data.Add("another");

                var request = HttpWebRequest.Create("https://api.bustoutgames.com/api/generatewithlocation"); //api url

                using (HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse) { // await used for async
                    
                    //If response code is not ok
                    if(response.StatusCode != HttpStatusCode.OK) {
                        return; //exit without doing anything
                    }

                    var data = response.GetResponseStream(); //sets the response stream
                
                    using (var reader = new StreamReader(data)) {
                        var content = reader.ReadToEnd(); //gets everything from the data
                        var obj = JsonConvert.DeserializeObject<GameInfo>(content);
                        foreach (var item in obj.names) {
                            Data.Add(item);
                        }
                    }
                }
            });

            
            SearchMoreCommand = new Command(async () => {
                var request = HttpWebRequest.Create("https://api.bustoutgames.com/api/generatewithlocation?count=100"); //api url

                using (HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse) { // await used for async

                    //If response code is not ok
                    if (response.StatusCode != HttpStatusCode.OK) {
                        return; //exit without doing anything
                    }

                    var data = response.GetResponseStream(); //sets the response stream

                    using (var reader = new StreamReader(data)) {
                        var content = reader.ReadToEnd(); //gets everything from the data
                        var obj = JsonConvert.DeserializeObject<GameInfo>(content);
                        foreach (var item in obj.names) {
                            Data.Add(item);
                        }
                    }
                }
            });

            //Clears the data list on the main page
            ClearCommand = new Command(() => {
                Data.Clear();
            });
        }
    }
}
