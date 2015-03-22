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
namespace WebScraping {
    //todo: exception handling
    class WebWorker {
        public static string getSource( string url ) {
            try {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create( url );
                HttpWebResponse res = (HttpWebResponse)req.GetResponse( );
                StreamReader sr = new StreamReader( res.GetResponseStream( ) );
                string source = sr.ReadToEnd( );
                sr.Close( );
                res.Close( );
                return source;
            } catch ( UriFormatException exception1 ) {
                MessageBox.Show( "Bad URI!" );
                return String.Empty;
            }
        }

        public static string searchTags( string source, string tag ) {
            List<string> tags = new List<string>( );
            int tempGuy = 0;
            string tempXeta = "";
            string result = "";
            int metasLength = 0;
            if ( tag == "script" ) {
                while ( source.IndexOf( "<" + tag ) > -1 ) {
                    tempGuy = source.IndexOf( "<" + tag );
                    source = source.Substring( tempGuy );
                    tempXeta = source.Substring( 0, source.IndexOf( "/script>" ) + 8 );
                    source = source.Substring( source.IndexOf( "/script>" ) + 8 );
                    tags.Add( tempXeta );
                }
                metasLength = tags.Count;
                for ( int i = 0; i < metasLength; i++ ) {
                    result = result + tags[i] + Environment.NewLine + Environment.NewLine;
                }

                return result;
            } else {
                //substring continues to end of string, OR a particular LENGTH
                //  this means substring does not continue to an index in a string.. do (length - index in a string) instead
                while ( source.IndexOf( "<" + tag ) > -1 ) {
                    tempGuy = source.IndexOf( "<" + tag );
                    source = source.Substring( tempGuy );
                    tempXeta = source.Substring( 0, source.IndexOf( ">" ) + 1 );
                    source = source.Substring( source.IndexOf( ">" ) - 1 );
                    tags.Add( tempXeta );
                }
                metasLength = tags.Count;
                for ( int i = 0; i < metasLength; i++ ) {
                    result += tags[i] + Environment.NewLine;
                }

                return result;
            }
        }

        public static string post( string url, string whack, string json ) {
            if ( whack.IndexOf( "/" ) == 0 ) {

            } else {
                whack = "/" + whack;
            }
            try {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url + whack);
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = 272;
                req.Method = "POST";

                using (StreamWriter sw = new StreamWriter(req.GetRequestStream()))
                {
                    /*{'text':'mary had a little lamb'}
                    object ojson = new JavaScriptSerializer().Deserialize(json, typeof(object));
                    json.Replace("\"","\\\"");*/
                    sw.Write(json);
                    sw.Flush();
                }

                using (HttpWebResponse res = (HttpWebResponse)req.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(res.GetResponseStream()))
                    {
                        string response = sr.ReadToEnd();
                        return response;
                    }
                }
            } catch ( UriFormatException exception1 ) {
                MessageBox.Show( "Bad URI!" );
                return "";
            }
        }

        public static string postJsonLogin( string url, string whack, string user, string pass ) {
            //need to figure out what the site expects "user" and "pass" to be called on the server side
            if ( whack.IndexOf( "/" ) == 0 ) {

            } else {
                whack = "/" + whack;
            }
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create( url + whack );
            req.ContentType = "text/json";
            req.Method = "POST";

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
        }
    }
}
