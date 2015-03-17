namespace WebScraping {
    partial class JsonAttributeControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            this.label1 = new System.Windows.Forms.Label( );
            this.button1 = new System.Windows.Forms.Button( );
            this.label2 = new System.Windows.Forms.Label( );
            this.valueInput = new System.Windows.Forms.TextBox( );
            this.keyInput = new System.Windows.Forms.TextBox( );
            this.SuspendLayout( );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 17, 20 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 31, 13 );
            this.label1.TabIndex = 0;
            this.label1.Text = "KEY:";
            this.label1.Click += new System.EventHandler( this.label1_Click );
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point( 510, 3 );
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size( 28, 30 );
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler( this.button1_Click );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 149, 20 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 45, 13 );
            this.label2.TabIndex = 2;
            this.label2.Text = "VALUE:";
            // 
            // valueInput
            // 
            this.valueInput.Location = new System.Drawing.Point( 200, 17 );
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size( 304, 20 );
            this.valueInput.TabIndex = 3;
            this.valueInput.TextChanged += new System.EventHandler( this.textBox1_TextChanged );
            // 
            // keyInput
            // 
            this.keyInput.Location = new System.Drawing.Point( 54, 16 );
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size( 89, 20 );
            this.keyInput.TabIndex = 4;
            this.keyInput.TextChanged += new System.EventHandler( this.textBox2_TextChanged );
            // 
            // JsonAttributeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.keyInput );
            this.Controls.Add( this.valueInput );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.button1 );
            this.Controls.Add( this.label1 );
            this.Name = "JsonAttributeControl";
            this.Size = new System.Drawing.Size( 541, 51 );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox valueInput;
        internal System.Windows.Forms.TextBox keyInput;
    }
}
