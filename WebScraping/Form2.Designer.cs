namespace WebScraping {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            this.label6 = new System.Windows.Forms.Label( );
            this.whackGrabber = new System.Windows.Forms.TextBox( );
            this.label1 = new System.Windows.Forms.Label( );
            this.urlGrabber = new System.Windows.Forms.TextBox( );
            this.button1 = new System.Windows.Forms.Button( );
            this.label4 = new System.Windows.Forms.Label( );
            this.jsonGrabber = new System.Windows.Forms.TextBox( );
            this.button4 = new System.Windows.Forms.Button( );
            this.label5 = new System.Windows.Forms.Label( );
            this.label2 = new System.Windows.Forms.Label( );
            this.button2 = new System.Windows.Forms.Button( );
            this.label3 = new System.Windows.Forms.Label( );
            this.jsonOutput = new System.Windows.Forms.TextBox( );
            this.jsonInput = new System.Windows.Forms.FlowLayoutPanel( );
            this.clearAll = new System.Windows.Forms.Button( );
            this.postJson = new System.Windows.Forms.Button( );
            this.SuspendLayout( );
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point( 9, 42 );
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size( 50, 13 );
            this.label6.TabIndex = 36;
            this.label6.Text = "WHACK:";
            // 
            // whackGrabber
            // 
            this.whackGrabber.Location = new System.Drawing.Point( 65, 39 );
            this.whackGrabber.Name = "whackGrabber";
            this.whackGrabber.Size = new System.Drawing.Size( 281, 20 );
            this.whackGrabber.TabIndex = 35;
            this.whackGrabber.TextChanged += new System.EventHandler( this.whackGrabber_TextChanged );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 24, 16 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 35, 13 );
            this.label1.TabIndex = 25;
            this.label1.Text = "URL: ";
            // 
            // urlGrabber
            // 
            this.urlGrabber.Location = new System.Drawing.Point( 65, 13 );
            this.urlGrabber.Name = "urlGrabber";
            this.urlGrabber.Size = new System.Drawing.Size( 281, 20 );
            this.urlGrabber.TabIndex = 24;
            this.urlGrabber.TextChanged += new System.EventHandler( this.urlGrabber_TextChanged );
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point( 356, 54 );
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size( 363, 23 );
            this.button1.TabIndex = 42;
            this.button1.Text = "POST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler( this.button1_Click );
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 353, 17 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 86, 13 );
            this.label4.TabIndex = 47;
            this.label4.Text = "STRINGY JSON";
            this.label4.Click += new System.EventHandler( this.label4_Click );
            // 
            // jsonGrabber
            // 
            this.jsonGrabber.Location = new System.Drawing.Point( 445, 13 );
            this.jsonGrabber.Multiline = true;
            this.jsonGrabber.Name = "jsonGrabber";
            this.jsonGrabber.Size = new System.Drawing.Size( 274, 22 );
            this.jsonGrabber.TabIndex = 46;
            this.jsonGrabber.TextChanged += new System.EventHandler( this.textBox1_TextChanged );
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point( 854, 12 );
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size( 233, 72 );
            this.button4.TabIndex = 49;
            this.button4.Text = "previous page";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler( this.button4_Click );
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point( 472, 38 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 247, 13 );
            this.label5.TabIndex = 50;
            this.label5.Text = "example: {\"username\":\"mom\", \"password\":\"pass\"}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 11, 104 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 71, 13 );
            this.label2.TabIndex = 52;
            this.label2.Text = "JSON INPUT";
            this.label2.Click += new System.EventHandler( this.label2_Click );
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point( 12, 573 );
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size( 427, 35 );
            this.button2.TabIndex = 53;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler( this.button2_Click_1 );
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 595, 104 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 50, 13 );
            this.label3.TabIndex = 29;
            this.label3.Text = "RESULT";
            this.label3.Click += new System.EventHandler( this.label3_Click );
            // 
            // jsonOutput
            // 
            this.jsonOutput.Location = new System.Drawing.Point( 598, 120 );
            this.jsonOutput.Multiline = true;
            this.jsonOutput.Name = "jsonOutput";
            this.jsonOutput.ReadOnly = true;
            this.jsonOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jsonOutput.Size = new System.Drawing.Size( 489, 488 );
            this.jsonOutput.TabIndex = 37;
            this.jsonOutput.UseWaitCursor = true;
            this.jsonOutput.TextChanged += new System.EventHandler( this.jsonOutput_TextChanged );
            // 
            // jsonInput
            // 
            this.jsonInput.AutoScroll = true;
            this.jsonInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.jsonInput.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.jsonInput.Location = new System.Drawing.Point( 14, 121 );
            this.jsonInput.Name = "jsonInput";
            this.jsonInput.Size = new System.Drawing.Size( 578, 446 );
            this.jsonInput.TabIndex = 54;
            this.jsonInput.WrapContents = false;
            this.jsonInput.Paint += new System.Windows.Forms.PaintEventHandler( this.jsonInput_Paint );
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point( 445, 573 );
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size( 147, 35 );
            this.clearAll.TabIndex = 55;
            this.clearAll.Text = "CLEAR";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler( this.clearAll_Click );
            // 
            // postJson
            // 
            this.postJson.Location = new System.Drawing.Point( 356, 78 );
            this.postJson.Name = "postJson";
            this.postJson.Size = new System.Drawing.Size( 363, 23 );
            this.postJson.TabIndex = 56;
            this.postJson.Text = "NEW POST";
            this.postJson.UseVisualStyleBackColor = true;
            this.postJson.Click += new System.EventHandler( this.postJson_Click );
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 1099, 620 );
            this.Controls.Add( this.postJson );
            this.Controls.Add( this.clearAll );
            this.Controls.Add( this.jsonInput );
            this.Controls.Add( this.button2 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.label5 );
            this.Controls.Add( this.button4 );
            this.Controls.Add( this.label4 );
            this.Controls.Add( this.jsonGrabber );
            this.Controls.Add( this.button1 );
            this.Controls.Add( this.jsonOutput );
            this.Controls.Add( this.label6 );
            this.Controls.Add( this.whackGrabber );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.urlGrabber );
            this.Name = "Form2";
            this.Text = "POSTING";
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox whackGrabber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlGrabber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox jsonGrabber;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jsonOutput;
        private System.Windows.Forms.FlowLayoutPanel jsonInput;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button postJson;

    }
}