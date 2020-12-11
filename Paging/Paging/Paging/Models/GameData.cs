using System;
using System.Collections.Generic;
using System.Text;

namespace Paging.Models {
    public class GameData {
        public string Name { get; set; }
        public int YearOfRelease { get; set; }
        public float Rating { get; set; }
        public PlatformType Platform { get; set; }
        public string Genre { get; set; }

        public override string ToString() {
            string result = $"{Name}\nPlatform: {Platform}     Rating: {Rating}";
            return result;
        }
    }

    public enum PlatformType {
        Arcade,
        Board,
        PC,
        Console,
        Handheld,
        Mobile
    }
}
