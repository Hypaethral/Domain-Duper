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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.urlGrabber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputMeta = new System.Windows.Forms.TextBox();
            this.customGrabber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.searchGrabberSource = new System.Windows.Forms.TextBox();
            this.searchButtonSource = new System.Windows.Forms.Button();
            this.outputSource = new System.Windows.Forms.RichTextBox();
            this.searchButtonCustom = new System.Windows.Forms.Button();
            this.searchGrabberCustom = new System.Windows.Forms.TextBox();
            this.outputCustom = new System.Windows.Forms.RichTextBox();
            this.favoriteButton = new System.Windows.Forms.Button();
            this.FavoritesStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FavoritesStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(651, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "SCRAPE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // urlGrabber
            // 
            this.urlGrabber.Location = new System.Drawing.Point(53, 17);
            this.urlGrabber.Name = "urlGrabber";
            this.urlGrabber.Size = new System.Drawing.Size(217, 20);
            this.urlGrabber.TabIndex = 0;
            this.urlGrabber.TextChanged += new System.EventHandler(this.urlGrabber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "URL: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "SOURCE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(709, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "META TAGS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // outputMeta
            // 
            this.outputMeta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.outputMeta.Location = new System.Drawing.Point(712, 115);
            this.outputMeta.Multiline = true;
            this.outputMeta.Name = "outputMeta";
            this.outputMeta.ReadOnly = true;
            this.outputMeta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputMeta.Size = new System.Drawing.Size(427, 183);
            this.outputMeta.TabIndex = 15;
            // 
            // customGrabber
            // 
            this.customGrabber.Location = new System.Drawing.Point(461, 17);
            this.customGrabber.Name = "customGrabber";
            this.customGrabber.Size = new System.Drawing.Size(243, 20);
            this.customGrabber.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "OPTIONAL CUSTOM TAG: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(717, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "CUSTOM TAG RESULTS: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(906, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 72);
            this.button2.TabIndex = 7;
            this.button2.Text = "next page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchGrabberSource
            // 
            this.searchGrabberSource.Location = new System.Drawing.Point(372, 88);
            this.searchGrabberSource.Name = "searchGrabberSource";
            this.searchGrabberSource.Size = new System.Drawing.Size(157, 20);
            this.searchGrabberSource.TabIndex = 3;
            // 
            // searchButtonSource
            // 
            this.searchButtonSource.Location = new System.Drawing.Point(536, 86);
            this.searchButtonSource.Name = "searchButtonSource";
            this.searchButtonSource.Size = new System.Drawing.Size(167, 23);
            this.searchButtonSource.TabIndex = 4;
            this.searchButtonSource.Text = "SEARCH";
            this.searchButtonSource.UseVisualStyleBackColor = true;
            this.searchButtonSource.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // outputSource
            // 
            this.outputSource.BackColor = System.Drawing.SystemColors.Control;
            this.outputSource.Location = new System.Drawing.Point(13, 116);
            this.outputSource.Name = "outputSource";
            this.outputSource.ReadOnly = true;
            this.outputSource.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.outputSource.Size = new System.Drawing.Size(690, 484);
            this.outputSource.TabIndex = 19;
            this.outputSource.Text = "";
            // 
            // searchButtonCustom
            // 
            this.searchButtonCustom.Location = new System.Drawing.Point(1024, 310);
            this.searchButtonCustom.Name = "searchButtonCustom";
            this.searchButtonCustom.Size = new System.Drawing.Size(115, 23);
            this.searchButtonCustom.TabIndex = 6;
            this.searchButtonCustom.Text = "SEARCH";
            this.searchButtonCustom.UseVisualStyleBackColor = true;
            this.searchButtonCustom.Click += new System.EventHandler(this.searchTagButton_Click);
            // 
            // searchGrabberCustom
            // 
            this.searchGrabberCustom.Location = new System.Drawing.Point(860, 313);
            this.searchGrabberCustom.Name = "searchGrabberCustom";
            this.searchGrabberCustom.Size = new System.Drawing.Size(158, 20);
            this.searchGrabberCustom.TabIndex = 5;
            this.searchGrabberCustom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // outputCustom
            // 
            this.outputCustom.BackColor = System.Drawing.SystemColors.Control;
            this.outputCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputCustom.Location = new System.Drawing.Point(712, 339);
            this.outputCustom.Name = "outputCustom";
            this.outputCustom.ReadOnly = true;
            this.outputCustom.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.outputCustom.Size = new System.Drawing.Size(427, 261);
            this.outputCustom.TabIndex = 22;
            this.outputCustom.Text = "";
            // 
            // favoriteButton
            // 
            this.favoriteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("favoriteButton.BackgroundImage")));
            this.favoriteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.favoriteButton.ContextMenuStrip = this.FavoritesStrip;
            this.favoriteButton.Location = new System.Drawing.Point(276, 10);
            this.favoriteButton.Name = "favoriteButton";
            this.favoriteButton.Size = new System.Drawing.Size(33, 33);
            this.favoriteButton.TabIndex = 61;
            this.toolTip1.SetToolTip(this.favoriteButton, "Favorites Menu");
            this.favoriteButton.UseVisualStyleBackColor = true;
            this.favoriteButton.Click += new System.EventHandler(this.favoriteButton_Click);
            // 
            // FavoritesStrip
            // 
            this.FavoritesStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bToolStripMenuItem,
            this.toolStripMenuItem1});
            this.FavoritesStrip.Name = "FavoritesStrip";
            this.FavoritesStrip.Size = new System.Drawing.Size(153, 54);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bToolStripMenuItem.Text = "Edit . . .";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1173, 619);
            this.Controls.Add(this.favoriteButton);
            this.Controls.Add(this.outputCustom);
            this.Controls.Add(this.searchButtonCustom);
            this.Controls.Add(this.searchGrabberCustom);
            this.Controls.Add(this.outputSource);
            this.Controls.Add(this.searchButtonSource);
            this.Controls.Add(this.searchGrabberSource);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customGrabber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputMeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlGrabber);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "SOURCE AND TAGS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FavoritesStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox urlGrabber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputMeta;
        private System.Windows.Forms.TextBox customGrabber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox searchGrabberSource;
        private System.Windows.Forms.Button searchButtonSource;
        private System.Windows.Forms.RichTextBox outputSource;
        private System.Windows.Forms.Button searchButtonCustom;
        private System.Windows.Forms.TextBox searchGrabberCustom;
        private System.Windows.Forms.RichTextBox outputCustom;
        private System.Windows.Forms.Button favoriteButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip FavoritesStrip;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

