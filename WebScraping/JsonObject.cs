using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebScraping {
    public class JsonObject {
        public JsonObject( ) {
            jsonString = "";
            kvps = new Dictionary<string, string>( );
        }

        public string jsonString {
            get;
            set;
        }

        public Dictionary<string, string> kvps {
            get;
            set;
        }

        /* credit to stack overflow 4580397 "json-formatter-in-c" for the beautification idea
         */
        public static string beautifyJson( string json ) {
            const string INDENT_STRING = "    ";
            int indentAmount = 0;
            bool insideQuotes = false;
            StringBuilder builder = new StringBuilder( );
            for ( int i = 0; i < json.Length; i++ ) {
                char x = json[i];
                switch ( x ) {
                    case ( '{' ):
                    case ( '[' ):
                        builder.Append( x );
                        if ( !insideQuotes ) {
                            builder.AppendLine( );
                            Enumerable.Range( 0, ++indentAmount ).ForEach( item => builder.Append( INDENT_STRING ) );
                        }
                        break;
                    case ( '}' ):
                    case ( ']' ):
                        if ( !insideQuotes ) {
                            builder.AppendLine( );
                            Enumerable.Range( 0, --indentAmount ).ForEach( item => builder.Append( INDENT_STRING ) );
                        }
                        builder.Append( x );
                        break;
                    case ( '"' ):
                        builder.Append( x );
                        bool escaped = false;
                        int index = i;
                        while ( index > 0 && json[--index] == '\\' ) {
                            escaped = !escaped;
                        }
                        if ( !escaped ) {
                            insideQuotes = !insideQuotes;
                        }
                        break;
                    case ( ',' ):
                        builder.Append( x );
                        if ( !insideQuotes ) {
                            builder.AppendLine( );
                            Enumerable.Range( 0, indentAmount ).ForEach( item => builder.Append( INDENT_STRING ) );
                        }
                        break;
                    case ( ':' ):
                        builder.Append( x );
                        if ( !insideQuotes ) {
                            builder.Append( " " );
                        }
                        break;
                    default:
                        builder.Append( x );
                        break;
                }
            }
            return builder.ToString( );
        }
    }
    static class Extensions {
        public static void ForEach<T>( this IEnumerable<T> ie, Action<T> action ) {
            foreach ( var i in ie ) {
                action( i );
            }
        }
    }
}
