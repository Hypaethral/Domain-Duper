using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebScraping {
    public partial class Form3: Form {
        string favType;
        public Form3( OrderedDictionary aItems, string aFavType ) {
            InitializeComponent( );
            favType = aFavType;
            populateListView( aItems );
        }

        private void Form3_Load( object sender, EventArgs e ) {

        }

        private void listView1_SelectedIndexChanged( object sender, EventArgs e ) {

        }

        private void populateListView( OrderedDictionary aItems ) {
            favsListView.Clear( );
            favsListView.Columns.Add( "NAME", -2, HorizontalAlignment.Left );
            favsListView.Columns.Add( "URL", -2, HorizontalAlignment.Left );
            foreach ( DictionaryEntry kvp in aItems ) {
                favsListView.Items.Add( new ListViewItem( new[] { kvp.Key.ToString( ), kvp.Value.ToString( ) } ) );
            }
        }
        private void populateListView( ListView.ListViewItemCollection aItems ) {
            favsListView.Clear( );
            foreach ( ListViewItem lvi in aItems ) {
                favsListView.Items.Add( lvi );
            }
        }

        private void newFav_Click( object sender, EventArgs e ) {

        }

        private void saveChanges_Click( object sender, EventArgs e ) {
            DataManager.storeFavorites( favsListView.Items, favType );
            this.Close( );
        }

        private void rmFav_Click( object sender, EventArgs e ) {
            if ( favsListView.SelectedIndices.Count > 0 ){
                foreach ( ListViewItem lvi in favsListView.SelectedItems ) {
                    lvi.Remove( );
                }
            }
        }

        private void editFav_Click( object sender, EventArgs e ) {

        }

        private void mvFavUp_Click( object sender, EventArgs e ) {
            DataManager.MoveListViewItem( favsListView, DataManager.MoveDirection.Up );
        }

        private void mvFavDown_Click( object sender, EventArgs e ) {
            DataManager.MoveListViewItem( favsListView, DataManager.MoveDirection.Down );
        }
    }
}
