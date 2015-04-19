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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.urlGrabber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.jsonOutput = new System.Windows.Forms.TextBox();
            this.jsonInput = new System.Windows.Forms.FlowLayoutPanel();
            this.clearAll = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.contentGrabber = new System.Windows.Forms.TextBox();
            this.restCallButton = new WebScraping.SplitButton();
            this.restOpts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHead = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPatch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPost = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPut = new System.Windows.Forms.ToolStripMenuItem();
            this.restOpts.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "URL: ";
            // 
            // urlGrabber
            // 
            this.urlGrabber.Location = new System.Drawing.Point(65, 13);
            this.urlGrabber.Name = "urlGrabber";
            this.urlGrabber.Size = new System.Drawing.Size(281, 20);
            this.urlGrabber.TabIndex = 0;
            this.urlGrabber.TextChanged += new System.EventHandler(this.urlGrabber_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "CONTENT TYPE:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(854, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 72);
            this.button4.TabIndex = 4;
            this.button4.Text = "previous page";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "JSON INPUT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(427, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "RESULT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // jsonOutput
            // 
            this.jsonOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.jsonOutput.Location = new System.Drawing.Point(598, 120);
            this.jsonOutput.Multiline = true;
            this.jsonOutput.Name = "jsonOutput";
            this.jsonOutput.ReadOnly = true;
            this.jsonOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jsonOutput.Size = new System.Drawing.Size(489, 488);
            this.jsonOutput.TabIndex = 37;
            this.jsonOutput.TextChanged += new System.EventHandler(this.jsonOutput_TextChanged);
            // 
            // jsonInput
            // 
            this.jsonInput.AutoScroll = true;
            this.jsonInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.jsonInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.jsonInput.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.jsonInput.Location = new System.Drawing.Point(14, 121);
            this.jsonInput.Name = "jsonInput";
            this.jsonInput.Size = new System.Drawing.Size(578, 446);
            this.jsonInput.TabIndex = 54;
            this.jsonInput.WrapContents = false;
            this.jsonInput.Paint += new System.Windows.Forms.PaintEventHandler(this.jsonInput_Paint);
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(445, 573);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(147, 35);
            this.clearAll.TabIndex = 55;
            this.clearAll.Text = "CLEAR";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "example: application/x-www-form-urlencoded";
            // 
            // contentGrabber
            // 
            this.contentGrabber.Location = new System.Drawing.Point(456, 12);
            this.contentGrabber.Multiline = true;
            this.contentGrabber.Name = "contentGrabber";
            this.contentGrabber.Size = new System.Drawing.Size(274, 22);
            this.contentGrabber.TabIndex = 1;
            this.contentGrabber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // restCallButton
            // 
            this.restCallButton.AutoSize = true;
            this.restCallButton.ContextMenuStrip = this.restOpts;
            this.restCallButton.Location = new System.Drawing.Point(456, 53);
            this.restCallButton.Name = "restCallButton";
            this.restCallButton.Size = new System.Drawing.Size(274, 41);
            this.restCallButton.SplitMenuStrip = this.restOpts;
            this.restCallButton.TabIndex = 56;
            this.restCallButton.Text = "POST";
            this.restCallButton.UseVisualStyleBackColor = true;
            this.restCallButton.Click += new System.EventHandler(this.restCallButton_Click);
            // 
            // restOpts
            // 
            this.restOpts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCopy,
            this.menuItemDelete,
            this.menuItemGet,
            this.menuItemHead,
            this.menuItemOptions,
            this.menuItemPatch,
            this.menuItemPost,
            this.menuItemPut});
            this.restOpts.AutoSize = false;
            this.restOpts.Name = "restOpts";
            this.restOpts.Size = new System.Drawing.Size(this.restCallButton.Width, 180);
            this.restOpts.Opening += new System.ComponentModel.CancelEventHandler(this.restOpts_Opening);
            // 
            // menuItemCopy
            // 
            this.menuItemCopy.Name = "menuItemCopy";
            this.menuItemCopy.AutoSize = false;
            this.menuItemCopy.Size = new System.Drawing.Size(this.restCallButton.Width-1, 22);
            this.menuItemCopy.Text = "COPY";
            this.menuItemCopy.Click += new System.EventHandler(this.restOptsMenuItem_Click);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.AutoSize = false;
            this.menuItemDelete.Size = new System.Drawing.Size( this.restCallButton.Width - 1, 22 );
            this.menuItemDelete.Text = "DELETE";
            this.menuItemDelete.Click += new System.EventHandler(this.restOptsMenuItem_Click);
            // 
            // menuItemGet
            // 
            this.menuItemGet.Name = "menuItemGet";
            this.menuItemGet.AutoSize = false;
            this.menuItemGet.Size = new System.Drawing.Size( this.restCallButton.Width - 1, 22 );
            this.menuItemGet.Text = "GET";
            this.menuItemGet.Click += new System.EventHandler(this.restOptsMenuItem_Click);
            // 
            // menuItemHead
            // 
            this.menuItemHead.Name = "menuItemHead";
            this.menuItemHead.AutoSize = false;
            this.menuItemHead.Size = new System.Drawing.Size( this.restCallButton.Width - 1, 22 );
            this.menuItemHead.Text = "HEAD";
            this.menuItemHead.Click += new System.EventHandler(this.restOptsMenuItem_Click);
            // 
            // menuItemOptions
            // 
            this.menuItemOptions.Name = "menuItemOptions";
            this.menuItemOptions.AutoSize = false;
            this.menuItemOptions.Size = new System.Drawing.Size( this.restCallButton.Width - 1, 22 );
            this.menuItemOptions.Text = "OPTIONS";
            this.menuItemOptions.Click += new System.EventHandler(this.restOptsMenuItem_Click);
            // 
            // menuItemPatch
            // 
            this.menuItemPatch.Name = "menuItemPatch";
            this.menuItemPatch.AutoSize = false;
            this.menuItemPatch.Size = new System.Drawing.Size( this.restCallButton.Width - 1, 22 );
            this.menuItemPatch.Text = "PATCH";
            this.menuItemPatch.Click += new System.EventHandler(this.restOptsMenuItem_Click);
            // 
            // menuItemPost
            // 
            this.menuItemPost.Name = "menuItemPost";
            this.menuItemPost.AutoSize = false;
            this.menuItemPost.Size = new System.Drawing.Size( this.restCallButton.Width - 1, 22 );
            this.menuItemPost.Text = "POST";
            this.menuItemPost.Click += new System.EventHandler(this.restOptsMenuItem_Click);
            // 
            // menuItemPut
            // 
            this.menuItemPut.Name = "menuItemPut";
            this.menuItemPut.AutoSize = false;
            this.menuItemPut.Size = new System.Drawing.Size( this.restCallButton.Width - 1, 22 );
            this.menuItemPut.Text = "PUT";
            this.menuItemPut.Click += new System.EventHandler(this.restOptsMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 620);
            this.Controls.Add(this.restCallButton);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.jsonInput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contentGrabber);
            this.Controls.Add(this.jsonOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlGrabber);
            this.Name = "Form2";
            this.Text = "REST API Interaction";
            this.restOpts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlGrabber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jsonOutput;
        private System.Windows.Forms.FlowLayoutPanel jsonInput;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contentGrabber;
        private SplitButton restCallButton;
        private System.Windows.Forms.ContextMenuStrip restOpts;
        private System.Windows.Forms.ToolStripMenuItem menuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemHead;
        private System.Windows.Forms.ToolStripMenuItem menuItemGet;
        private System.Windows.Forms.ToolStripMenuItem menuItemOptions;
        private System.Windows.Forms.ToolStripMenuItem menuItemPatch;
        private System.Windows.Forms.ToolStripMenuItem menuItemPost;
        private System.Windows.Forms.ToolStripMenuItem menuItemPut;

    }
}