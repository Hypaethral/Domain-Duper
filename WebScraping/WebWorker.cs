using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace WebScraping {
    //todo: exception handling
    public class WebWorker {
        public static string getSource( string url ) {
            try {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create( url );
                try {
                    HttpWebResponse res = (HttpWebResponse)req.GetResponse( );
                    StreamReader sr = new StreamReader( res.GetResponseStream( ) );
                    string source = sr.ReadToEnd( );
                    sr.Close( );
                    res.Close( );
                    return source;
                } catch ( WebException ex ) {
                    MessageBox.Show( ex.Message );
                    return String.Empty;
                }
            } catch ( UriFormatException ex ) {
                MessageBox.Show( ex.Message );
                return String.Empty;
            }
        }

        public static string searchTags( string source, string tag ) {
            //todo: verify additional script functionality
            var matches = Regex.Matches(source, String.Format("(<{0}.*?>)", tag), RegexOptions.Multiline | RegexOptions.IgnoreCase);
            var result = String.Empty;
            foreach (var match in matches)
            {
                result += match.ToString() + Environment.NewLine;
            }
            return result; // returning a list of matches here would probably be a better long-term option
        }

        public static string post( string url, string whack, string contentType, Dictionary<string, string> json ) {
            //todo:  serialize string:string dictionary as json
            if ( whack.IndexOf( "/" ) == 0 ) {

            } else {
                whack = "/" + whack;
            }
            try {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create( url + whack );
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = 272;
                req.Method = "POST";
                try {
                    using ( StreamWriter sw = new StreamWriter( req.GetRequestStream( ) ) ) {
                        /*{'text':'mary had a little lamb'}
                        object ojson = new JavaScriptSerializer().Deserialize(json, typeof(object));
                        json.Replace("\"","\\\"");*/
                        sw.Write( json );
                        sw.Flush( );
                        using ( HttpWebResponse res = (HttpWebResponse)req.GetResponse( ) ) {
                            using ( StreamReader sr = new StreamReader( res.GetResponseStream( ) ) ) {
                                string response = sr.ReadToEnd( );
                                return response;
                            }
                        }
                    }
                } catch ( WebException ex ) {
                    MessageBox.Show( ex.Message );
                    return String.Empty;
                }
            } catch ( UriFormatException ex ) {
                MessageBox.Show( ex.Message );
                return String.Empty;
            }
        }
        /*
        public static string postJsonLogin( string url, string whack, string user, string pass ) {
            //need to figure out what the site expects "user" and "pass" to be called on the server side
            if ( whack.IndexOf( "/" ) == 0 ) {

            } else {
                whack = "/" + whack;
            }
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create( url + whack );
            req.ContentType = "text/json";
            req.Method = "POST";
            try {
                using ( StreamWriter sw = new StreamWriter( req.GetRequestStream( ) ) ) {
                    string json = new JavaScriptSerializer( ).Serialize( new {
                        user = user,
                        pass = pass
                    } );
                    sw.Write( json );
                    sw.Flush( );
                    sw.Close( );

                    HttpWebResponse res = (HttpWebResponse)req.GetResponse( );
                    using ( StreamReader sr = new StreamReader( res.GetResponseStream( ) ) ) {
                        string response = sr.ReadToEnd( );
                        sr.Close( );
                        res.Close( );
                        return response;
                    }
                }
            } catch ( WebException ex ) {
                MessageBox.Show( ex.Message );
                return "";
            }
        }*/
    }
}
