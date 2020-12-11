using Paging.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paging.ViewModels {
    class MainPageViewModel {
        public List<GameData> Games { get; set; }

        //constructor
        public MainPageViewModel() {
            Games = new List<GameData> {
                new GameData { Name="Qbert", YearOfRelease=1982, Rating=3, Platform=PlatformType.Arcade, Genre="Shooter" },
                new GameData { Name="Okami", YearOfRelease=2010, Rating=5, Platform=PlatformType.Console, Genre="Adventure"},
                new GameData { Name="Granblue Fantasy", YearOfRelease=2014, Rating=4, Platform=PlatformType.Mobile, Genre="RPG" },
                new GameData { Name="Hades", YearOfRelease=2020, Rating=5, Platform=PlatformType.PC, Genre="Rougelike" },
                new GameData { Name="999", YearOfRelease=2010, Rating=4, Platform=PlatformType.Handheld, Genre="Visual Novel" }
            };
        }
    }
}
