using System;
using System.Collections.Generic;
using System.Text;

namespace DatabindingListView.Models {
    class GameLevel {
        public string Name { get; set; }
        public int LevelNumber { get; set; }
        public int MinPlayerLevel { get; set; }
        public int MaxPlayerLevel { get; set; }
        public int Score { get; set; }
        public int Deaths { get; set; }
    }
}