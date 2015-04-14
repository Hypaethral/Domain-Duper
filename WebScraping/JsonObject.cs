using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebScraping {
    public class JsonObject {
        public JsonObject( ) {
            name = "";
            kvps = new Dictionary<string,string>( );
        }

        public string name {
            get;
            set;
        }

        public Dictionary<string, string> kvps {
            get;
            set;
        }
    }
}
