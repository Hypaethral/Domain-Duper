using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.IO;
namespace WebScraping {
    //This class is bad because it returns stuff instead of storing it to be accessed later (singleton model)
    static class DataManager {

        const string FAVORITE_PATH_REST = "favorites-rest.txt";
        const string FAVORITE_PATH_SCRAPE = "favorites-scrape.txt";
        const char DELIMETER = '|';

        public static OrderedDictionary retrieveFavorites( string favType ) {
            OrderedDictionary kvps = new OrderedDictionary( );
            string[] lines;
            switch ( favType.ToLower( ) ) {
                case ( "rest" ):
                    lines = System.IO.File.ReadAllLines( FAVORITE_PATH_REST );
                    break;
                case ( "scrape" ):
                    lines = System.IO.File.ReadAllLines( FAVORITE_PATH_SCRAPE );
                    break;
                default:
                    lines = new[] { "" };
                    break;
            }
            foreach ( string line in lines ) {
                //name, url
                string[] guys = line.Split( DELIMETER );
                kvps.Insert( kvps.Count, guys[0], guys[1] );
            }
            return kvps;
        }

        public static ListView.ListViewItemCollection storeFavorites( ListView.ListViewItemCollection favs, string favType ) {
            //Inefficient.  This writes all lines to a file when there's probably one or two new additions.  
            //  Given my current data model (which sucks), this is the best I can think of to allow the other functionalities.
            //    Given more time, this should be more robust (along with the data model itself)
            using ( System.IO.StreamWriter file = new System.IO.StreamWriter( String.Format( "favorites-{0}.txt", favType ) ) ) {
                foreach ( ListViewItem lvi in favs ) {
                    file.WriteLine( lvi.SubItems[0].Text + DELIMETER + lvi.SubItems[1].Text );
                }
            }
            return favs;
        }



        /* MoveListViewItem takes a listview and a direction (enumerated as MoveDirection.Up or MoveDirection.Down)
         *   It moves the selected listviewitem up or down
         */
        public enum MoveDirection {
            Up = -1,
            Down = 1
        };

        public static void MoveListViewItem( ListView sender, MoveDirection direction ) {
            int dir = (int)direction;
            int repDir = dir * -1;

            if ( sender.SelectedItems.Count > 0 && (
                    ( direction == MoveDirection.Down && sender.SelectedItems[sender.SelectedItems.Count - 1].Index < sender.Items.Count - 1 )
                    || ( direction == MoveDirection.Up && sender.SelectedItems[0].Index > 0 ) ) ) {
                foreach ( ListViewItem item in sender.SelectedItems ) {
                    //use dir to decide on the new index
                    int newIndex = item.Index + dir;
                    //move the item
                    sender.Items.RemoveAt( item.Index );
                    sender.Items.Insert( newIndex, item );
                }
            }
        }
    }
}
