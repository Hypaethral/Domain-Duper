namespace WebScraping {
    partial class Form1 {
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
            this.button1 = new System.Windows.Forms.Button( );
            this.urlGrabber = new System.Windows.Forms.TextBox( );
            this.label1 = new System.Windows.Forms.Label( );
            this.outputSource = new System.Windows.Forms.RichTextBox( );
            this.label2 = new System.Windows.Forms.Label( );
            this.label3 = new System.Windows.Forms.Label( );
            this.outputMeta = new System.Windows.Forms.TextBox( );
            this.outputCustom = new System.Windows.Forms.TextBox( );
            this.customGrabber = new System.Windows.Forms.TextBox( );
            this.label4 = new System.Windows.Forms.Label( );
            this.label5 = new System.Windows.Forms.Label( );
            this.button2 = new System.Windows.Forms.Button( );
            this.SuspendLayout( );
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point( 53, 57 );
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size( 651, 23 );
            this.button1.TabIndex = 0;
            this.button1.Text = "SCRAPE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler( this.button1_Click );
            // 
            // urlGrabber
            // 
            this.urlGrabber.Location = new System.Drawing.Point( 53, 31 );
            this.urlGrabber.Name = "urlGrabber";
            this.urlGrabber.Size = new System.Drawing.Size( 243, 20 );
            this.urlGrabber.TabIndex = 1;
            this.urlGrabber.TextChanged += new System.EventHandler( this.urlGrabber_TextChanged );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 12, 34 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 35, 13 );
            this.label1.TabIndex = 2;
            this.label1.Text = "URL: ";
            this.label1.Click += new System.EventHandler( this.label1_Click );
            // 
            // outputSource
            // 
            this.outputSource.Location = new System.Drawing.Point( 13, 115 );
            this.outputSource.Name = "outputSource";
            this.outputSource.ReadOnly = true;
            this.outputSource.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.outputSource.Size = new System.Drawing.Size( 690, 488 );
            this.outputSource.TabIndex = 3;
            this.outputSource.Text = "";
            this.outputSource.TextChanged += new System.EventHandler( this.outputSource_TextChanged );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 12, 99 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 52, 13 );
            this.label2.TabIndex = 5;
            this.label2.Text = "SOURCE";
            this.label2.Click += new System.EventHandler( this.label2_Click );
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 709, 99 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 69, 13 );
            this.label3.TabIndex = 6;
            this.label3.Text = "META TAGS";
            this.label3.Click += new System.EventHandler( this.label3_Click );
            // 
            // outputMeta
            // 
            this.outputMeta.Location = new System.Drawing.Point( 712, 115 );
            this.outputMeta.Multiline = true;
            this.outputMeta.Name = "outputMeta";
            this.outputMeta.ReadOnly = true;
            this.outputMeta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputMeta.Size = new System.Drawing.Size( 427, 183 );
            this.outputMeta.TabIndex = 4;
            this.outputMeta.UseWaitCursor = true;
            // 
            // outputCustom
            // 
            this.outputCustom.Location = new System.Drawing.Point( 712, 337 );
            this.outputCustom.Multiline = true;
            this.outputCustom.Name = "outputCustom";
            this.outputCustom.ReadOnly = true;
            this.outputCustom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputCustom.Size = new System.Drawing.Size( 427, 263 );
            this.outputCustom.TabIndex = 7;
            // 
            // customGrabber
            // 
            this.customGrabber.Location = new System.Drawing.Point( 461, 31 );
            this.customGrabber.Name = "customGrabber";
            this.customGrabber.Size = new System.Drawing.Size( 243, 20 );
            this.customGrabber.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 314, 34 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 141, 13 );
            this.label4.TabIndex = 13;
            this.label4.Text = "OPTIONAL CUSTOM TAG: ";
            this.label4.Click += new System.EventHandler( this.label4_Click );
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point( 709, 321 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 137, 13 );
            this.label5.TabIndex = 14;
            this.label5.Text = "CUSTOM TAG RESULTS: ";
            this.label5.Click += new System.EventHandler( this.label5_Click );
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point( 906, 12 );
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size( 233, 72 );
            this.button2.TabIndex = 15;
            this.button2.Text = "next page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler( this.button2_Click );
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 1173, 619 );
            this.Controls.Add( this.button2 );
            this.Controls.Add( this.label5 );
            this.Controls.Add( this.label4 );
            this.Controls.Add( this.customGrabber );
            this.Controls.Add( this.outputCustom );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.outputMeta );
            this.Controls.Add( this.outputSource );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.urlGrabber );
            this.Controls.Add( this.button1 );
            this.Name = "Form1";
            this.Text = "SOURCE AND TAGS";
            this.Load += new System.EventHandler( this.Form1_Load );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox urlGrabber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox outputSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputMeta;
        private System.Windows.Forms.TextBox outputCustom;
        private System.Windows.Forms.TextBox customGrabber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}

