using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Motivator {
    class MainPageViewModel : INotifyPropertyChanged {
        private string title;

        public string Title {
            get { return title; }
            set { title = value; }
        }

        private string sayingText;

        public string SayingText {
            get { return sayingText; }
            set { sayingText = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SayingText")); }
        }


        private string categoryText;

        public event PropertyChangedEventHandler PropertyChanged;

        public string CategoryText {
            get { return categoryText; }
            set { categoryText = value; }
        }

        private string categoryText2;

        public string CategoryText2 {
            get { return categoryText2; }
            set { categoryText2 = value; }
        }


        public ICommand MotivateCommand { get; set; }
        public ICommand MotivateCommand2 { get; set; }

        private List<String> healthySayings1;
        private List<string> healthySayings2;
        private Random rand = new Random();

        public MainPageViewModel() {
            Title = "Motivator-MVVM";
            SayingText = "Tap a button to get motivated!";
            CategoryText = "Eat Vegetables!";
            CategoryText2 = "Get Exercise!";

            healthySayings1 = new List<string> {
                "Eat Veggies and you will lose weight!",
                "Vegetables are healthy!",
                "Get a good night of sleep!"
            };

            healthySayings2 = new List<string> {
                "Getting Exercise helps you lose weight and stay healthy!",
                "Exercise helps your heart and muscles",
                "Turn on the bluelight filtering on the pc"
            };

            MotivateCommand = new Command(() => {
                SayingText = healthySayings1[rand.Next(0, 3)];
            });

            MotivateCommand2 = new Command(() => {
                SayingText = healthySayings2[rand.Next(0,3)];
            });
        }
    }
}
