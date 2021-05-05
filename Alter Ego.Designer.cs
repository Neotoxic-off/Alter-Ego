
namespace FDR
{
    partial class Alter_Ego
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.browse = new System.Windows.Forms.Button();
            this.directory = new System.Windows.Forms.FolderBrowserDialog();
            this.remove = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.RichTextBox();
            this.only_images = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.auto_remove = new System.Windows.Forms.CheckBox();
            this.only_videos = new System.Windows.Forms.CheckBox();
            this.only_music = new System.Windows.Forms.CheckBox();
            this.dark_theme = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cancel = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.percent = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.Transparent;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse.Location = new System.Drawing.Point(401, 535);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(81, 23);
            this.browse.TabIndex = 0;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // remove
            // 
            this.remove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remove.Location = new System.Drawing.Point(6, 19);
            this.remove.Name = "remove";
            this.remove.ReadOnly = true;
            this.remove.Size = new System.Drawing.Size(451, 93);
            this.remove.TabIndex = 2;
            this.remove.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.remove);
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 118);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Duplicate ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.logs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(470, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Status ";
            // 
            // logs
            // 
            this.logs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logs.Location = new System.Drawing.Point(6, 26);
            this.logs.Name = "logs";
            this.logs.ReadOnly = true;
            this.logs.Size = new System.Drawing.Size(451, 79);
            this.logs.TabIndex = 1;
            this.logs.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.status);
            this.groupBox3.Location = new System.Drawing.Point(12, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(470, 110);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Logs ";
            // 
            // status
            // 
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.status.Location = new System.Drawing.Point(6, 26);
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(451, 79);
            this.status.TabIndex = 1;
            this.status.Text = "";
            // 
            // only_images
            // 
            this.only_images.AutoSize = true;
            this.only_images.Location = new System.Drawing.Point(13, 26);
            this.only_images.Name = "only_images";
            this.only_images.Size = new System.Drawing.Size(84, 17);
            this.only_images.TabIndex = 5;
            this.only_images.Text = "Only Images";
            this.only_images.UseVisualStyleBackColor = true;
            this.only_images.CheckedChanged += new System.EventHandler(this.only_images_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.auto_remove);
            this.groupBox4.Controls.Add(this.only_videos);
            this.groupBox4.Controls.Add(this.only_music);
            this.groupBox4.Controls.Add(this.only_images);
            this.groupBox4.Location = new System.Drawing.Point(12, 376);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox4.Size = new System.Drawing.Size(306, 76);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Search Options ";
            // 
            // auto_remove
            // 
            this.auto_remove.AutoSize = true;
            this.auto_remove.Location = new System.Drawing.Point(131, 26);
            this.auto_remove.Name = "auto_remove";
            this.auto_remove.Size = new System.Drawing.Size(91, 17);
            this.auto_remove.TabIndex = 8;
            this.auto_remove.Text = "Auto Remove";
            this.auto_remove.UseVisualStyleBackColor = true;
            this.auto_remove.CheckedChanged += new System.EventHandler(this.auto_remove_CheckedChanged);
            // 
            // only_videos
            // 
            this.only_videos.AutoSize = true;
            this.only_videos.Location = new System.Drawing.Point(131, 49);
            this.only_videos.Name = "only_videos";
            this.only_videos.Size = new System.Drawing.Size(82, 17);
            this.only_videos.TabIndex = 7;
            this.only_videos.Text = "Only Videos";
            this.only_videos.UseVisualStyleBackColor = true;
            this.only_videos.CheckedChanged += new System.EventHandler(this.only_videos_CheckedChanged);
            // 
            // only_music
            // 
            this.only_music.AutoSize = true;
            this.only_music.Location = new System.Drawing.Point(13, 49);
            this.only_music.Name = "only_music";
            this.only_music.Size = new System.Drawing.Size(78, 17);
            this.only_music.TabIndex = 6;
            this.only_music.Text = "Only Music";
            this.only_music.UseVisualStyleBackColor = true;
            this.only_music.CheckedChanged += new System.EventHandler(this.only_music_CheckedChanged);
            // 
            // dark_theme
            // 
            this.dark_theme.AutoSize = true;
            this.dark_theme.Location = new System.Drawing.Point(13, 26);
            this.dark_theme.Name = "dark_theme";
            this.dark_theme.Size = new System.Drawing.Size(85, 17);
            this.dark_theme.TabIndex = 6;
            this.dark_theme.Text = "Dark Theme";
            this.dark_theme.UseVisualStyleBackColor = true;
            this.dark_theme.CheckedChanged += new System.EventHandler(this.dark_theme_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dark_theme);
            this.groupBox5.Location = new System.Drawing.Point(324, 376);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox5.Size = new System.Drawing.Size(158, 76);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " Interface ";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Location = new System.Drawing.Point(314, 535);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(81, 23);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // progress
            // 
            this.progress.ForeColor = System.Drawing.Color.Red;
            this.progress.Location = new System.Drawing.Point(16, 28);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(367, 13);
            this.progress.TabIndex = 8;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.percent);
            this.groupBox6.Controls.Add(this.progress);
            this.groupBox6.Location = new System.Drawing.Point(12, 458);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(470, 60);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = " Progress ";
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(386, 28);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(38, 13);
            this.percent.TabIndex = 9;
            this.percent.Text = "Ready";
            // 
            // Alter_Ego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 570);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.browse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Alter_Ego";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alter Ego";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.FolderBrowserDialog directory;
        private System.Windows.Forms.RichTextBox remove;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox status;
        private System.Windows.Forms.CheckBox only_images;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox dark_theme;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox only_music;
        private System.Windows.Forms.CheckBox only_videos;
        private System.Windows.Forms.CheckBox auto_remove;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label percent;
    }
}

