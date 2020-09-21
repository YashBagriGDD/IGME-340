using DatabindingListView.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace DatabindingListView.ViewModels {
    class MainPageViewModel {
        public ObservableCollection<GameLevel> Levels { get; set; }
        public Command AddCommand { get; }
        public Command RemoveCommand { get; }

        public MainPageViewModel() {
            Levels = new ObservableCollection<GameLevel> {
                new GameLevel {Name="Jyon", LevelNumber=1, MinPlayerLevel=1, MaxPlayerLevel=100, Score=500, Deaths=2},
                new GameLevel {Name="Gamer420", LevelNumber=99, MinPlayerLevel=50, MaxPlayerLevel=200, Deaths=0, Score=9999999},
                new GameLevel {Name="Serra", LevelNumber=6, MinPlayerLevel=1, MaxPlayerLevel=200, Score=34500, Deaths=5}
            };

            AddCommand = new Command(Add);
            RemoveCommand = new Command(Remove);
        }

        private void Add() {
            Levels.Add(new GameLevel { LevelNumber = Levels.Count, Name = "added level " + Levels.Count + 1});
        }

        private void Remove() {
            if (Levels.Count >= 1) {
                Levels.RemoveAt(Levels.Count - 1);
            }
            else {
                // Prevents crash when at 0 levels.
            }
        }
    }
}