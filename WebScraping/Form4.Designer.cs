namespace WebScraping {
    partial class Form4 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveCloseF4 = new System.Windows.Forms.Button();
            this.nameGrabber = new System.Windows.Forms.TextBox();
            this.urlGrabber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "URL:";
            // 
            // saveCloseF4
            // 
            this.saveCloseF4.Location = new System.Drawing.Point(30, 79);
            this.saveCloseF4.Name = "saveCloseF4";
            this.saveCloseF4.Size = new System.Drawing.Size(225, 39);
            this.saveCloseF4.TabIndex = 2;
            this.saveCloseF4.Text = "Save and Close";
            this.saveCloseF4.UseVisualStyleBackColor = true;
            this.saveCloseF4.Click += new System.EventHandler(this.saveCloseF4_Click);
            // 
            // nameGrabber
            // 
            this.nameGrabber.Location = new System.Drawing.Point(68, 27);
            this.nameGrabber.Name = "nameGrabber";
            this.nameGrabber.Size = new System.Drawing.Size(187, 20);
            this.nameGrabber.TabIndex = 3;
            // 
            // urlGrabber
            // 
            this.urlGrabber.Location = new System.Drawing.Point(68, 53);
            this.urlGrabber.Name = "urlGrabber";
            this.urlGrabber.Size = new System.Drawing.Size(187, 20);
            this.urlGrabber.TabIndex = 4;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 134);
            this.Controls.Add(this.urlGrabber);
            this.Controls.Add(this.nameGrabber);
            this.Controls.Add(this.saveCloseF4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New/Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveCloseF4;
        private System.Windows.Forms.TextBox nameGrabber;
        private System.Windows.Forms.TextBox urlGrabber;
    }
}