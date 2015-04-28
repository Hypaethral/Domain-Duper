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
            var formb = new Form4( "New" );
            formb.FormClosed += new FormClosedEventHandler( formb_FormClosed );
            formb.ShowDialog( );
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
            if ( favsListView.SelectedIndices.Count > 1 ) {
                MessageBox.Show( "You may only edit one favorite at a time!" );
            } else if ( favsListView.SelectedIndices.Count > 0 ) {
                var formb = new Form4( "Edit", favsListView.SelectedItems[0] );
                formb.FormClosed += new FormClosedEventHandler( formb_FormClosed );
                formb.ShowDialog( );
            }
        }
        //This function allows us to return the new thinger to the previous form
        private void formb_FormClosed( object sender, FormClosedEventArgs e ) {
            if ( ( (Form4)sender ).context == "Edit"  && ( (Form4)sender ).returnValue != null
                && ( ( (Form4)sender ).returnValue.SubItems[0].Text != String.Empty
                && ( (Form4)sender ).returnValue.SubItems[1].Text != String.Empty ) ) {
                favsListView.Items[favsListView.SelectedIndices[0]] = ( (Form4)sender ).returnValue;
            } else if ( ( (Form4)sender ).returnValue != null && ( (Form4)sender ).returnValue.SubItems[0].Text != String.Empty 
                && ( (Form4)sender ).returnValue.SubItems[1].Text != String.Empty ) {
                favsListView.SelectedIndices.Clear( );
                favsListView.Items.Add( ( (Form4)sender ).returnValue );
            }
            
            ( (Form4)sender ).FormClosed -= formb_FormClosed;
            ( (Form4)sender ).Dispose( );
        }


        private void mvFavUp_Click( object sender, EventArgs e ) {
            DataManager.MoveListViewItem( favsListView, DataManager.MoveDirection.Up );
        }

        private void mvFavDown_Click( object sender, EventArgs e ) {
            DataManager.MoveListViewItem( favsListView, DataManager.MoveDirection.Down );
        }
    }
}
