using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebScraping {
    public partial class Form4: Form {
        private bool save = false;
        public ListViewItem returnValue;
        public string context;
        public Form4( string aContext ) {
            InitializeComponent( );
            this.Text = aContext;
            context = aContext;
        }

        public Form4( string aContext, ListViewItem editThisGuy ) {
            InitializeComponent( );
            this.Text = aContext;
            context = aContext;
            nameGrabber.Text = editThisGuy.SubItems[0].Text;
            urlGrabber.Text = editThisGuy.SubItems[1].Text;
        }

        private void saveCloseF4_Click( object sender, EventArgs e ) {
            if ( nameGrabber.Text != String.Empty && urlGrabber.Text != String.Empty ) {
                returnValue = new ListViewItem( new[] { nameGrabber.Text, urlGrabber.Text } );
                save = true;
                this.Close( );
            } else {
                MessageBox.Show( "The fields cannot be empty if you would like to save!" );
            }
        }

        private void Form4_FormClosing( object sender, FormClosingEventArgs e ) {
            if ( !save ) {
                returnValue = null;
            } else {
                //other situations will be handled by individual buttons
            }
        }
    }
}
