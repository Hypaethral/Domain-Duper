namespace WebScraping {
    partial class Form3 {
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
            this.rmFav = new System.Windows.Forms.Button();
            this.newFav = new System.Windows.Forms.Button();
            this.mvFavUp = new System.Windows.Forms.Button();
            this.mvFavDown = new System.Windows.Forms.Button();
            this.favsListView = new System.Windows.Forms.ListView();
            this.saveChanges = new System.Windows.Forms.Button();
            this.editFav = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // rmFav
            // 
            this.rmFav.Location = new System.Drawing.Point(742, 87);
            this.rmFav.Name = "rmFav";
            this.rmFav.Size = new System.Drawing.Size(55, 53);
            this.rmFav.TabIndex = 0;
            this.rmFav.Text = "delete";
            this.rmFav.UseVisualStyleBackColor = true;
            this.rmFav.Click += new System.EventHandler(this.rmFav_Click);
            // 
            // newFav
            // 
            this.newFav.Location = new System.Drawing.Point(742, 12);
            this.newFav.Name = "newFav";
            this.newFav.Size = new System.Drawing.Size(55, 69);
            this.newFav.TabIndex = 1;
            this.newFav.Text = "new";
            this.newFav.UseVisualStyleBackColor = true;
            this.newFav.Click += new System.EventHandler(this.newFav_Click);
            // 
            // mvFavUp
            // 
            this.mvFavUp.Location = new System.Drawing.Point(742, 211);
            this.mvFavUp.Name = "mvFavUp";
            this.mvFavUp.Size = new System.Drawing.Size(55, 60);
            this.mvFavUp.TabIndex = 2;
            this.mvFavUp.Text = "up";
            this.mvFavUp.UseVisualStyleBackColor = true;
            this.mvFavUp.Click += new System.EventHandler(this.mvFavUp_Click);
            // 
            // mvFavDown
            // 
            this.mvFavDown.Location = new System.Drawing.Point(742, 277);
            this.mvFavDown.Name = "mvFavDown";
            this.mvFavDown.Size = new System.Drawing.Size(55, 55);
            this.mvFavDown.TabIndex = 3;
            this.mvFavDown.Text = "down";
            this.mvFavDown.UseVisualStyleBackColor = true;
            this.mvFavDown.Click += new System.EventHandler(this.mvFavDown_Click);
            // 
            // favsListView
            // 
            this.favsListView.FullRowSelect = true;
            this.favsListView.HideSelection = false;
            this.favsListView.Location = new System.Drawing.Point(13, 12);
            this.favsListView.Name = "favsListView";
            this.favsListView.Size = new System.Drawing.Size(721, 385);
            this.favsListView.TabIndex = 4;
            this.favsListView.UseCompatibleStateImageBehavior = false;
            this.favsListView.View = System.Windows.Forms.View.Details;
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(742, 338);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(55, 59);
            this.saveChanges.TabIndex = 5;
            this.saveChanges.Text = "save and exit";
            this.toolTip1.SetToolTip(this.saveChanges, "hit the x in the top right to exit without saving");
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // editFav
            // 
            this.editFav.Location = new System.Drawing.Point(742, 146);
            this.editFav.Name = "editFav";
            this.editFav.Size = new System.Drawing.Size(55, 59);
            this.editFav.TabIndex = 6;
            this.editFav.Text = "edit";
            this.editFav.UseVisualStyleBackColor = true;
            this.editFav.Click += new System.EventHandler(this.editFav_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 409);
            this.Controls.Add(this.editFav);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.favsListView);
            this.Controls.Add(this.mvFavDown);
            this.Controls.Add(this.mvFavUp);
            this.Controls.Add(this.newFav);
            this.Controls.Add(this.rmFav);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rmFav;
        private System.Windows.Forms.Button newFav;
        private System.Windows.Forms.Button mvFavUp;
        private System.Windows.Forms.Button mvFavDown;
        private System.Windows.Forms.ListView favsListView;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button editFav;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}