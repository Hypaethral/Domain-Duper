﻿using System;
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
        Dictionary<string, string> scrapeFavorites;

        public Form1( ) {
            InitializeComponent( );
            scrapeFavorites = DataGetter.retrieveFavorites("scrape");
            foreach (KeyValuePair<string, string> kvp in scrapeFavorites) {
                //will chaining like this even work?  I'm excited to find out!
                favoriteButton.ContextMenuStrip.Items.Add(kvp.Key)
                    .Click += new System.EventHandler(favoriteMenuItemClicked);
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

        private void favoriteMenuItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem x = sender as ToolStripMenuItem;
            urlGrabber.Text = scrapeFavorites[x.Text];
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will be the 'new' section!");
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will be the 'edit' section!");
        }

        private void favoriteButton_Click(object sender, EventArgs e)
        {
            Button x = sender as Button;
            FavoritesStrip.Show( x.PointToScreen( new Point(0, x.Height) ) );
        }
    }
}
