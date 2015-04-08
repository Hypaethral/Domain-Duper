using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WebScraping {
    public partial class Form1: Form {
        public Form1( ) {
            InitializeComponent( );
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

        private void label2_Click( object sender, EventArgs e ) {

        }

        private void label3_Click( object sender, EventArgs e ) {

        }

        private void label4_Click( object sender, EventArgs e ) {

        }

        private void button3_Click( object sender, EventArgs e ) {

        }

        private void label5_Click( object sender, EventArgs e ) {

        }

        private void outputSource_TextChanged( object sender, EventArgs e ) {

        }

        private void label6_Click( object sender, EventArgs e ) {

        }

        private void button2_Click( object sender, EventArgs e ) {
            Form2 form2 = new Form2( );
            form2.Tag = this;
            form2.Show( this );
            Hide( );
        }

        private void urlGrabber_TextChanged( object sender, EventArgs e ) {

        }

        private void label6_Click_1( object sender, EventArgs e ) {

        }

        private void button3_Click_1( object sender, EventArgs e ) {
            if ( searchGrabber.Text != String.Empty ) {
                int i = 0;

                //This line resets the selectionBackColor formatting... is there a cleaner way? 
                outputSource.Text = outputSource.Text;
                while ( i < outputSource.Text.LastIndexOf( searchGrabber.Text ) ) {
                    outputSource.Find( searchGrabber.Text, i, outputSource.TextLength, RichTextBoxFinds.None );
                    outputSource.SelectionBackColor = Color.DarkOrchid;
                    i = outputSource.Text.IndexOf( searchGrabber.Text, i ) + 1;
                }
            }
        }
    }
}
