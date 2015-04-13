using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebScraping {
    public class JsonObject {
        public JsonObject( ) {
            name = "";
            type = new List<KeyValuePair<string,string>>( );
        }

        public string name {
            get;
            set;
        }

        public List<KeyValuePair<string, string>> type {
            get;
            set;
        }
    }
}
