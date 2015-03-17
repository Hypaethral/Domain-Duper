using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebScraping {
    public partial class JsonAttributeControl: UserControl {
        public JsonAttributeControl( ) {
            InitializeComponent( );
        }

        private void label1_Click( object sender, EventArgs e ) {

        }

        private void textBox1_TextChanged( object sender, EventArgs e ) {

        }

        private void button1_Click( object sender, EventArgs e ) {
            this.Parent.Controls.Remove( this );
        }

        private void textBox2_TextChanged( object sender, EventArgs e ) {

        }
    }
}
