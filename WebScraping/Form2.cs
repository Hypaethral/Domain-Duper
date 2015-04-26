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
    public partial class Form2: Form {
       OrderedDictionary restFavorites;

        public Form2( ) {
            InitializeComponent( );
            restFavorites = DataManager.retrieveFavorites( "rest" );
            foreach ( DictionaryEntry kvp in restFavorites ) {
                //will chaining like this even work?  I'm excited to find out!
                favoriteButton.ContextMenuStrip.Items.Add( kvp.Key.ToString( ) )
                    .Click += new System.EventHandler( favoriteMenuItemClicked );
            }
        }

        private void textBox1_TextChanged( object sender, EventArgs e ) {

        }

        private void label4_Click( object sender, EventArgs e ) {

        }

        private void button4_Click( object sender, EventArgs e ) {
            var form1 = (Form1)Tag;
            form1.Show( );
            Close( );
        }

        private void urlGrabber_TextChanged( object sender, EventArgs e ) {

        }

        private void label3_Click( object sender, EventArgs e ) {

        }

        private void jsonOutput_TextChanged( object sender, EventArgs e ) {

        }

        private void label2_Click( object sender, EventArgs e ) {

        }

        private void button2_Click_1( object sender, EventArgs e ) {
            JsonAttributeControl mbox = new JsonAttributeControl( );
            jsonInput.Controls.Add( mbox );
        }

        private void clearAll_Click( object sender, EventArgs e ) {
            jsonInput.AutoScroll = false;
            jsonInput.Controls.Clear( );
            jsonInput.AutoScroll = true;
        }

        private void jsonInput_Paint( object sender, PaintEventArgs e ) {

        }

        //The main button -- rest verb calls are done through WebWorker right here!
        private void restCallButton_Click( object sender, EventArgs e ) {
            outputRestResult.Text = String.Empty;
            JsonObject json = new JsonObject( );
            foreach ( JsonAttributeControl ele in jsonInput.Controls ) {
                //take each controls' values into a dictionary or object, pass to serialize json function in webworker
                if ( !String.IsNullOrWhiteSpace( ele.keyInput.Text ) && !String.IsNullOrWhiteSpace( ele.valueInput.Text ) ) {
                    json.kvps.Add( ele.keyInput.Text, ele.valueInput.Text );
                }
            }
            string url = urlGrabber.Text.IndexOf( "http" ) < 0 ? "http://" + urlGrabber.Text : urlGrabber.Text;
            outputRestResult.Text = "You performed a " + ( (SplitButton)sender ).Text + " with: " + Environment.NewLine + WebWorker.serializeJson( json.kvps ) + Environment.NewLine + "You got: " + Environment.NewLine;
            outputRestResult.Text += JsonObject.beautifyJson( WebWorker.restCall( url, contentGrabber.Text, ( (SplitButton)sender ).Text, json.kvps ) );
        }

        private void restOpts_Opening( object sender, CancelEventArgs e ) {
            restOpts.Size = new System.Drawing.Size( this.restCallButton.Width, restOpts.Items.Count * 22 + 5 );
            foreach ( ToolStripMenuItem item in restOpts.Items ) {
                item.Size = new System.Drawing.Size( this.restCallButton.Width - 1, 22 );
            }

        }

        private void restOptsMenuItem_Click( object sender, EventArgs e ) {
            restCallButton.Text = ( (ToolStripMenuItem)sender ).Text;
        }

        private void searchRestResult_Click( object sender, EventArgs e ) {
            //This line resets the selectionBackColor formatting... is there a cleaner way? 
            outputRestResult.Text = outputRestResult.Text;
            if ( searchGrabberRestResult.Text != String.Empty ) {
                int i = 0;
                while ( i < outputRestResult.Text.LastIndexOf( searchGrabberRestResult.Text ) ) {
                    outputRestResult.Find( searchGrabberRestResult.Text, i, outputRestResult.TextLength, RichTextBoxFinds.None );
                    outputRestResult.SelectionBackColor = Color.DarkOrchid;
                    i = outputRestResult.Text.IndexOf( searchGrabberRestResult.Text, i ) + 1;
                }
            }
        }

        private void favoriteButton_Click( object sender, EventArgs e ) {
            Button x = sender as Button;
            FavoritesStrip.Show( x.PointToScreen( new Point( 0, x.Height ) ) );
        }

        private void favoriteMenuItemClicked( object sender, EventArgs e ) {
            ToolStripMenuItem x = sender as ToolStripMenuItem;
            urlGrabber.Text = (string)restFavorites[x.Text];
        }

        private void bToolStripMenuItem_Click( object sender, EventArgs e ) {
            var forma = new Form3( restFavorites, "rest" );
            forma.FormClosed += new FormClosedEventHandler( forma_FormClosed );
            forma.ShowDialog( );
        }

        //This function allows us to refresh the favorites whenever the editing page is closed 
        //    (changes only occur when file is updated)
        private void forma_FormClosed( object sender, FormClosedEventArgs e ) {
            var edit = favoriteButton.ContextMenuStrip.Items[0];
            var div = favoriteButton.ContextMenuStrip.Items[1];
            favoriteButton.ContextMenuStrip.Items.Clear( );
            restFavorites = DataManager.retrieveFavorites( "rest" );

            //rebuilding the contextmenustrip
            favoriteButton.ContextMenuStrip.Items.Add( edit );
            favoriteButton.ContextMenuStrip.Items.Add( div );
            foreach ( DictionaryEntry kvp in restFavorites ) {
                favoriteButton.ContextMenuStrip.Items.Add( kvp.Key.ToString( ) )
                    .Click += new System.EventHandler( favoriteMenuItemClicked );
            }
            ( (Form3)sender ).FormClosed -= forma_FormClosed;
            ( (Form3)sender ).Dispose( );
        }
    }
}
