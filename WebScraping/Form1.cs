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
using System.IO;

namespace WebScraping {
    public partial class Form1: Form {
        OrderedDictionary scrapeFavorites;

        public Form1( ) {
            InitializeComponent( );
            scrapeFavorites = DataManager.retrieveFavorites( "scrape" );
            foreach ( DictionaryEntry kvp in scrapeFavorites ) {
                //will chaining like this even work?  I'm excited to find out!
                favoriteButton.ContextMenuStrip.Items.Add( kvp.Key.ToString() )
                    .Click += new System.EventHandler( favoriteMenuItemClicked );
            }
        }

        private void Form1_Load( object sender, EventArgs e ) {

        }

        private void label1_Click( object sender, EventArgs e ) {

        }

        private void button1_Click( object sender, EventArgs e ) {
            string url = urlGrabber.Text.IndexOf( "http" ) < 0 ? "http://" + urlGrabber.Text : urlGrabber.Text;
            string source = WebWorker.getSource( url );
            outputSource.Text = source;

            string searchMeta = WebWorker.searchTags( source, "meta" );
            outputMeta.Text = searchMeta;

            if ( !String.IsNullOrWhiteSpace( customGrabber.Text ) ) {
                string searchCustom = WebWorker.searchTags( source, customGrabber.Text );
                outputCustom.Text = searchCustom;
            }
        }

        private void button2_Click( object sender, EventArgs e ) {
            Form2 form2 = new Form2( );
            form2.Tag = this;
            form2.Show( this );
            Hide( );
        }

        private void urlGrabber_TextChanged( object sender, EventArgs e ) {

        }
        
        private void button3_Click_1( object sender, EventArgs e ) {
            //This line resets the selectionBackColor formatting... is there a cleaner way? 
            outputSource.Text = outputSource.Text;
            if ( searchGrabberSource.Text != String.Empty ) {
                int i = 0;

                while ( i < outputSource.Text.LastIndexOf( searchGrabberSource.Text ) ) {
                    outputSource.Find( searchGrabberSource.Text, i, outputSource.TextLength, RichTextBoxFinds.None );
                    outputSource.SelectionBackColor = Color.DarkOrchid;
                    i = outputSource.Text.IndexOf( searchGrabberSource.Text, i ) + 1;
                }
            }
        }

        private void textBox1_TextChanged( object sender, EventArgs e ) {

        }

        private void searchTagButton_Click( object sender, EventArgs e ) {
            //This line resets the selectionBackColor formatting... is there a cleaner way? 
            outputCustom.Text = outputCustom.Text;
            if ( searchGrabberCustom.Text != String.Empty ) {
                int i = 0;

                while ( i < outputCustom.Text.LastIndexOf( searchGrabberCustom.Text ) ) {
                    outputCustom.Find( searchGrabberCustom.Text, i, outputCustom.TextLength, RichTextBoxFinds.None );
                    outputCustom.SelectionBackColor = Color.DarkOrchid;
                    i = outputCustom.Text.IndexOf( searchGrabberCustom.Text, i ) + 1;
                }
            }
        }

        private void favoriteMenuItemClicked( object sender, EventArgs e ) {
            ToolStripMenuItem x = sender as ToolStripMenuItem;
            urlGrabber.Text = (string)scrapeFavorites[x.Text];
        }

        private void bToolStripMenuItem_Click( object sender, EventArgs e ) {
            var forma = new Form3( scrapeFavorites, "scrape" );
            forma.FormClosed += new FormClosedEventHandler( forma_FormClosed );
            forma.ShowDialog( );
        }

        private void forma_FormClosed( object sender, FormClosedEventArgs e ) {
            var edit = favoriteButton.ContextMenuStrip.Items[0];
            var div = favoriteButton.ContextMenuStrip.Items[1];
            favoriteButton.ContextMenuStrip.Items.Clear( );
            scrapeFavorites = DataManager.retrieveFavorites( "scrape" );

            //rebuilding the contextmenustrip
            favoriteButton.ContextMenuStrip.Items.Add( edit );
            favoriteButton.ContextMenuStrip.Items.Add( div );
            foreach ( DictionaryEntry kvp in scrapeFavorites ) {
                favoriteButton.ContextMenuStrip.Items.Add( kvp.Key.ToString( ) )
                    .Click += new System.EventHandler( favoriteMenuItemClicked );
            }
            ( (Form3)sender ).FormClosed -= forma_FormClosed;
            ( (Form3)sender ).Dispose( );
        }

        private void favoriteButton_Click( object sender, EventArgs e ) {
            Button x = sender as Button;
            FavoritesStrip.Show( x.PointToScreen( new Point( 0, x.Height ) ) );
        }
    }
}
