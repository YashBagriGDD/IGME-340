using System;
using System.Collections.Generic;
using System.Text;

namespace CallingWebService {

    public class GameInfo {
        public List<Details> names { get; set; }
    }

    public class Details {
        public string name { get; set; }
        public string studio { get; set; }
        public float longitude { get; set; }
        public float latitude { get; set; }
    }

}
