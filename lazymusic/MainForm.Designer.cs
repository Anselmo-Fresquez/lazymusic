namespace Cool_Stuff {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.lstBands = new System.Windows.Forms.ListBox();
            this.lblBands = new System.Windows.Forms.Label();
            this.lstSongs = new System.Windows.Forms.ListBox();
            this.lblSongs = new System.Windows.Forms.Label();
            this.txtBandName = new System.Windows.Forms.TextBox();
            this.lblNewBand = new System.Windows.Forms.Label();
            this.btnAddBandName = new System.Windows.Forms.Button();
            this.btnClearBandName = new System.Windows.Forms.Button();
            this.btnClearSongName = new System.Windows.Forms.Button();
            this.btnAddSongTitle = new System.Windows.Forms.Button();
            this.lblNewSong = new System.Windows.Forms.Label();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.btnDeleteBand = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnGoogleBand = new System.Windows.Forms.Button();
            this.btnGoogleSong = new System.Windows.Forms.Button();
            this.btnRenameSong = new System.Windows.Forms.Button();
            this.btnDeleteSong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBands
            // 
            this.lstBands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstBands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBands.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBands.ForeColor = System.Drawing.Color.White;
            this.lstBands.FormattingEnabled = true;
            this.lstBands.ItemHeight = 20;
            this.lstBands.Location = new System.Drawing.Point(13, 157);
            this.lstBands.Name = "lstBands";
            this.lstBands.Size = new System.Drawing.Size(418, 302);
            this.lstBands.TabIndex = 0;
            this.lstBands.SelectedIndexChanged += new System.EventHandler(this.lstBands_SelectedIndexChanged);
            this.lstBands.DoubleClick += new System.EventHandler(this.lstBands_DoubleClick);
            // 
            // lblBands
            // 
            this.lblBands.AutoSize = true;
            this.lblBands.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBands.Location = new System.Drawing.Point(13, 130);
            this.lblBands.Name = "lblBands";
            this.lblBands.Size = new System.Drawing.Size(96, 24);
            this.lblBands.TabIndex = 1;
            this.lblBands.Text = "Bands I Like";
            // 
            // lstSongs
            // 
            this.lstSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSongs.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSongs.ForeColor = System.Drawing.Color.White;
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.ItemHeight = 20;
            this.lstSongs.Location = new System.Drawing.Point(514, 157);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(418, 302);
            this.lstSongs.TabIndex = 2;
            this.lstSongs.SelectedIndexChanged += new System.EventHandler(this.lstSongs_SelectedIndexChanged);
            this.lstSongs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstSongs_KeyDown);
            this.lstSongs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSongs_MouseDoubleClick);
            // 
            // lblSongs
            // 
            this.lblSongs.AutoSize = true;
            this.lblSongs.Location = new System.Drawing.Point(624, 137);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(0, 17);
            this.lblSongs.TabIndex = 3;
            // 
            // txtBandName
            // 
            this.txtBandName.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtBandName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBandName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBandName.Location = new System.Drawing.Point(101, 83);
            this.txtBandName.Name = "txtBandName";
            this.txtBandName.Size = new System.Drawing.Size(333, 22);
            this.txtBandName.TabIndex = 4;
            // 
            // lblNewBand
            // 
            this.lblNewBand.AutoSize = true;
            this.lblNewBand.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewBand.Location = new System.Drawing.Point(13, 83);
            this.lblNewBand.Name = "lblNewBand";
            this.lblNewBand.Size = new System.Drawing.Size(82, 24);
            this.lblNewBand.TabIndex = 5;
            this.lblNewBand.Text = "New Band";
            // 
            // btnAddBandName
            // 
            this.btnAddBandName.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddBandName.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnAddBandName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBandName.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBandName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddBandName.Location = new System.Drawing.Point(329, 111);
            this.btnAddBandName.Name = "btnAddBandName";
            this.btnAddBandName.Size = new System.Drawing.Size(103, 40);
            this.btnAddBandName.TabIndex = 6;
            this.btnAddBandName.Text = "Add";
            this.btnAddBandName.UseVisualStyleBackColor = false;
            this.btnAddBandName.Click += new System.EventHandler(this.btnAddBandName_Click);
            // 
            // btnClearBandName
            // 
            this.btnClearBandName.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnClearBandName.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnClearBandName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBandName.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearBandName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearBandName.Location = new System.Drawing.Point(218, 111);
            this.btnClearBandName.Name = "btnClearBandName";
            this.btnClearBandName.Size = new System.Drawing.Size(105, 40);
            this.btnClearBandName.TabIndex = 7;
            this.btnClearBandName.Text = "Clear";
            this.btnClearBandName.UseVisualStyleBackColor = false;
            this.btnClearBandName.Click += new System.EventHandler(this.btnClearBandName_Click);
            // 
            // btnClearSongName
            // 
            this.btnClearSongName.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnClearSongName.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnClearSongName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSongName.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSongName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearSongName.Location = new System.Drawing.Point(732, 111);
            this.btnClearSongName.Name = "btnClearSongName";
            this.btnClearSongName.Size = new System.Drawing.Size(96, 40);
            this.btnClearSongName.TabIndex = 12;
            this.btnClearSongName.Text = "Clear";
            this.btnClearSongName.UseVisualStyleBackColor = false;
            this.btnClearSongName.Click += new System.EventHandler(this.btnClearSongName_Click);
            // 
            // btnAddSongTitle
            // 
            this.btnAddSongTitle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddSongTitle.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnAddSongTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSongTitle.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSongTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddSongTitle.Location = new System.Drawing.Point(834, 111);
            this.btnAddSongTitle.Name = "btnAddSongTitle";
            this.btnAddSongTitle.Size = new System.Drawing.Size(99, 40);
            this.btnAddSongTitle.TabIndex = 11;
            this.btnAddSongTitle.Text = "Add";
            this.btnAddSongTitle.UseVisualStyleBackColor = false;
            this.btnAddSongTitle.Click += new System.EventHandler(this.btnAddSongTitle_Click);
            // 
            // lblNewSong
            // 
            this.lblNewSong.AutoSize = true;
            this.lblNewSong.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewSong.Location = new System.Drawing.Point(512, 83);
            this.lblNewSong.Name = "lblNewSong";
            this.lblNewSong.Size = new System.Drawing.Size(80, 24);
            this.lblNewSong.TabIndex = 10;
            this.lblNewSong.Text = "New Song";
            // 
            // txtSongName
            // 
            this.txtSongName.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtSongName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSongName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSongName.Location = new System.Drawing.Point(598, 83);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(335, 22);
            this.txtSongName.TabIndex = 9;
            this.txtSongName.TextChanged += new System.EventHandler(this.txtSongName_TextChanged);
            this.txtSongName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSongName_KeyDown);
            // 
            // btnDeleteBand
            // 
            this.btnDeleteBand.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnDeleteBand.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnDeleteBand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBand.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteBand.Location = new System.Drawing.Point(13, 471);
            this.btnDeleteBand.Name = "btnDeleteBand";
            this.btnDeleteBand.Size = new System.Drawing.Size(135, 43);
            this.btnDeleteBand.TabIndex = 14;
            this.btnDeleteBand.Text = "Delete";
            this.btnDeleteBand.UseVisualStyleBackColor = false;
            this.btnDeleteBand.Click += new System.EventHandler(this.btnDeleteBand_Click);
            // 
            // btnRename
            // 
            this.btnRename.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRename.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRename.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRename.Location = new System.Drawing.Point(155, 472);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(135, 42);
            this.btnRename.TabIndex = 15;
            this.btnRename.Text = "Rename ";
            this.btnRename.UseVisualStyleBackColor = false;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnGoogleBand
            // 
            this.btnGoogleBand.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGoogleBand.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnGoogleBand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoogleBand.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoogleBand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGoogleBand.Location = new System.Drawing.Point(296, 471);
            this.btnGoogleBand.Name = "btnGoogleBand";
            this.btnGoogleBand.Size = new System.Drawing.Size(135, 42);
            this.btnGoogleBand.TabIndex = 17;
            this.btnGoogleBand.Text = "Google";
            this.btnGoogleBand.UseVisualStyleBackColor = false;
            this.btnGoogleBand.Click += new System.EventHandler(this.btnGoogleBand_Click);
            // 
            // btnGoogleSong
            // 
            this.btnGoogleSong.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGoogleSong.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnGoogleSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoogleSong.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoogleSong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGoogleSong.Location = new System.Drawing.Point(798, 471);
            this.btnGoogleSong.Name = "btnGoogleSong";
            this.btnGoogleSong.Size = new System.Drawing.Size(135, 42);
            this.btnGoogleSong.TabIndex = 20;
            this.btnGoogleSong.Text = "Google";
            this.btnGoogleSong.UseVisualStyleBackColor = false;
            this.btnGoogleSong.Click += new System.EventHandler(this.btnGoogleSong_Click);
            // 
            // btnRenameSong
            // 
            this.btnRenameSong.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRenameSong.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnRenameSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenameSong.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenameSong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRenameSong.Location = new System.Drawing.Point(657, 472);
            this.btnRenameSong.Name = "btnRenameSong";
            this.btnRenameSong.Size = new System.Drawing.Size(135, 42);
            this.btnRenameSong.TabIndex = 19;
            this.btnRenameSong.Text = "Rename ";
            this.btnRenameSong.UseVisualStyleBackColor = false;
            this.btnRenameSong.Click += new System.EventHandler(this.btnRenameSong_Click);
            // 
            // btnDeleteSong
            // 
            this.btnDeleteSong.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnDeleteSong.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnDeleteSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSong.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteSong.Location = new System.Drawing.Point(515, 471);
            this.btnDeleteSong.Name = "btnDeleteSong";
            this.btnDeleteSong.Size = new System.Drawing.Size(135, 43);
            this.btnDeleteSong.TabIndex = 18;
            this.btnDeleteSong.Text = "Delete";
            this.btnDeleteSong.UseVisualStyleBackColor = false;
            this.btnDeleteSong.Click += new System.EventHandler(this.btnDeleteSong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 56);
            this.label1.TabIndex = 22;
            this.label1.Text = "lazy music";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Songs I Like";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoogleSong);
            this.Controls.Add(this.btnRenameSong);
            this.Controls.Add(this.btnDeleteSong);
            this.Controls.Add(this.btnGoogleBand);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnDeleteBand);
            this.Controls.Add(this.btnClearSongName);
            this.Controls.Add(this.btnAddSongTitle);
            this.Controls.Add(this.lblNewSong);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSongs);
            this.Controls.Add(this.btnClearBandName);
            this.Controls.Add(this.btnAddBandName);
            this.Controls.Add(this.lblNewBand);
            this.Controls.Add(this.txtBandName);
            this.Controls.Add(this.lblSongs);
            this.Controls.Add(this.lblBands);
            this.Controls.Add(this.lstBands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Opacity = 0.975D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "lazy music";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBands;
        private System.Windows.Forms.Label lblBands;
        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.Label lblSongs;
        private System.Windows.Forms.TextBox txtBandName;
        private System.Windows.Forms.Label lblNewBand;
        private System.Windows.Forms.Button btnAddBandName;
        private System.Windows.Forms.Button btnClearBandName;
        private System.Windows.Forms.Button btnClearSongName;
        private System.Windows.Forms.Button btnAddSongTitle;
        private System.Windows.Forms.Label lblNewSong;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Button btnDeleteBand;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnGoogleBand;
        private System.Windows.Forms.Button btnGoogleSong;
        private System.Windows.Forms.Button btnRenameSong;
        private System.Windows.Forms.Button btnDeleteSong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

