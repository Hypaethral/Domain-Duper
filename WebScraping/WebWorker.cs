﻿using System;
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
//http://stackoverflow.com/questions/29615647/is-there-some-way-to-use-if-loop-in-python-more-than-4-times hahaha
//hubcapsarecool@gmail.com hello12345 // grundleberg123

namespace WebScraping {
    public class WebWorker {
        /* This method returns the HTML from the desired url as a string.
         */
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

        /* This method finds matches for tags within long HTML documents.  It accepts
         * a string and appends tag brackets (<>).  Scripts have a special result, which
         * includes all the contents between the start-tag and end-tag.
         */
        public static string searchTags( string source, string tag ) {
            if ( tag != "script" ) {
                var matches = Regex.Matches( source, String.Format( "(<{0}.*?>)", tag ), RegexOptions.Multiline | RegexOptions.IgnoreCase );
                var result = String.Empty;
                foreach ( var match in matches ) {
                    result += match.ToString( ) + Environment.NewLine;
                }
                return result;
            } else {
                var matches = Regex.Matches( source, String.Format( "(<{0}.*?>[\\S\\s]*?</{0}?>)", tag ), RegexOptions.Multiline | RegexOptions.IgnoreCase );
                var result = String.Empty;
                foreach ( var match in matches ) {
                    result += match.ToString( ) + Environment.NewLine + Environment.NewLine;
                }
                return result;
            }
        }


        /* Converts a dictionary<string, string> to JSON post format
         */
        public static string serializeJson( Dictionary<string, string> dict ) {
            StringBuilder sb = new StringBuilder( );
            int count = 0;
            foreach ( var entry in dict ) {
                sb.AppendFormat( "{0}={1}", entry.Key, entry.Value, WebUtility.HtmlEncode( entry.Value ) );
                if ( count != dict.Count - 1 ) {
                    sb.Append( "&" );
                }
                count++;
            }
            return sb.ToString( );
        }

        /*  Based on the context from which it was called, this method attempts to make
         *  a REST api call from the form.  It returns the response from this call.
         */
        public static string restCall( string url, string contentType, string method, Dictionary<string, string> dict ) {
            try {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create( url );
                if ( contentType != String.Empty ) {
                    req.ContentType = contentType;
                } else {
                    req.ContentType = "application/x-www-form-urlencoded";
                }
                req.Method = method;
                try {
                    using ( StreamWriter sw = new StreamWriter( req.GetRequestStream( ) ) ) {
                        string json = serializeJson( dict );

                        sw.Write( json );
                        sw.Flush( );
                        using ( HttpWebResponse res = (HttpWebResponse)req.GetResponse( ) ) {
                            using ( StreamReader sr = new StreamReader( res.GetResponseStream( ) ) ) {
                                string response = sr.ReadToEnd( );
                                return response;
                            }
                        }
                    }
                } catch ( ProtocolViolationException ex ) {
                    //If we're here, we don't need the body (i.e., we're probably performing a GET).
                    using ( HttpWebResponse res = (HttpWebResponse)req.GetResponse( ) ) {
                        using ( StreamReader sr = new StreamReader( res.GetResponseStream( ) ) ) {
                            string response = sr.ReadToEnd( );
                            return response;
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
    }
}
