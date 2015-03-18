using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebScraping {
    public partial class Form2: Form {
        public Form2( ) {
            InitializeComponent( );
        }

        private void label9_Click( object sender, EventArgs e ) {

        }

        private void textBox2_TextChanged( object sender, EventArgs e ) {

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

        private void button2_Click( object sender, EventArgs e ) {
        }

        private void urlGrabber_TextChanged( object sender, EventArgs e ) {

        }

        private void whackGrabber_TextChanged( object sender, EventArgs e ) {

        }

        private void button1_Click( object sender, EventArgs e ) {
            jsonOutput.Text = WebWorker.post( urlGrabber.Text, whackGrabber.Text, contentGrabber.Text );
        }

        private void label3_Click( object sender, EventArgs e ) {

        }

        private void jsonOutput_TextChanged( object sender, EventArgs e ) {

        }

        private void label2_Click( object sender, EventArgs e ) {

        }

        private void jsonLoginOutput_TextChanged( object sender, EventArgs e ) {

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

        private void postJson_Click( object sender, EventArgs e ) {
            //todo: search source
            //todo: css, javascript, html files
            jsonOutput.Text = "";
            foreach ( JsonAttributeControl ele in jsonInput.Controls ) {
                jsonOutput.Text += ele.keyInput.Text + " : " + ele.valueInput.Text + Environment.NewLine;
            }
        }
    }
}
