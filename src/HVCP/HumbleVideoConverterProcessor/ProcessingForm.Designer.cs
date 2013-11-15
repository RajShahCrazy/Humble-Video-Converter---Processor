namespace HumbleVideoConverterProcessor
{
    partial class ProcessingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessingForm));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addWatermark = new System.Windows.Forms.Button();
            this.createSketch = new System.Windows.Forms.Button();
            this.extractAudio = new System.Windows.Forms.Button();
            this.createbwVideo = new System.Windows.Forms.Button();
            this.muteAudio = new System.Windows.Forms.Button();
            this.addAudio = new System.Windows.Forms.Button();
            this.speedVideo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtitlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processingStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.processingStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(452, 62);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(510, 268);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addWatermark);
            this.panel1.Controls.Add(this.createSketch);
            this.panel1.Controls.Add(this.extractAudio);
            this.panel1.Controls.Add(this.createbwVideo);
            this.panel1.Controls.Add(this.muteAudio);
            this.panel1.Controls.Add(this.addAudio);
            this.panel1.Controls.Add(this.speedVideo);
            this.panel1.Location = new System.Drawing.Point(91, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 214);
            this.panel1.TabIndex = 2;
            // 
            // addWatermark
            // 
            this.addWatermark.Location = new System.Drawing.Point(3, 178);
            this.addWatermark.Name = "addWatermark";
            this.addWatermark.Size = new System.Drawing.Size(249, 23);
            this.addWatermark.TabIndex = 6;
            this.addWatermark.Text = "Add Watermark";
            this.addWatermark.UseVisualStyleBackColor = true;
            // 
            // createSketch
            // 
            this.createSketch.Location = new System.Drawing.Point(3, 149);
            this.createSketch.Name = "createSketch";
            this.createSketch.Size = new System.Drawing.Size(249, 23);
            this.createSketch.TabIndex = 5;
            this.createSketch.Text = "Create sketch from video";
            this.createSketch.UseVisualStyleBackColor = true;
            // 
            // extractAudio
            // 
            this.extractAudio.Location = new System.Drawing.Point(3, 62);
            this.extractAudio.Name = "extractAudio";
            this.extractAudio.Size = new System.Drawing.Size(249, 23);
            this.extractAudio.TabIndex = 4;
            this.extractAudio.Text = "Extract Audio";
            this.extractAudio.UseVisualStyleBackColor = true;
            // 
            // createbwVideo
            // 
            this.createbwVideo.Location = new System.Drawing.Point(3, 120);
            this.createbwVideo.Name = "createbwVideo";
            this.createbwVideo.Size = new System.Drawing.Size(249, 23);
            this.createbwVideo.TabIndex = 3;
            this.createbwVideo.Text = "Convert Video to Black and White";
            this.createbwVideo.UseVisualStyleBackColor = true;
            // 
            // muteAudio
            // 
            this.muteAudio.Location = new System.Drawing.Point(3, 91);
            this.muteAudio.Name = "muteAudio";
            this.muteAudio.Size = new System.Drawing.Size(249, 23);
            this.muteAudio.TabIndex = 2;
            this.muteAudio.Text = "Mute Audio";
            this.muteAudio.UseVisualStyleBackColor = true;
            // 
            // addAudio
            // 
            this.addAudio.Location = new System.Drawing.Point(3, 33);
            this.addAudio.Name = "addAudio";
            this.addAudio.Size = new System.Drawing.Size(249, 23);
            this.addAudio.TabIndex = 1;
            this.addAudio.Text = "Add Audio (mp3)";
            this.addAudio.UseVisualStyleBackColor = true;
            this.addAudio.Click += new System.EventHandler(this.button1_Click);
            // 
            // speedVideo
            // 
            this.speedVideo.Location = new System.Drawing.Point(3, 4);
            this.speedVideo.Name = "speedVideo";
            this.speedVideo.Size = new System.Drawing.Size(249, 23);
            this.speedVideo.TabIndex = 0;
            this.speedVideo.Text = "Speed Up / Slow Down Video";
            this.speedVideo.UseVisualStyleBackColor = true;
            this.speedVideo.Click += new System.EventHandler(this.speedVideo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.convertToolStripMenuItem,
            this.subtitlesToolStripMenuItem,
            this.processingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.convertToolStripMenuItem.Text = "Convert";
            // 
            // subtitlesToolStripMenuItem
            // 
            this.subtitlesToolStripMenuItem.Name = "subtitlesToolStripMenuItem";
            this.subtitlesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.subtitlesToolStripMenuItem.Text = "Subtitles";
            this.subtitlesToolStripMenuItem.Click += new System.EventHandler(this.subtitlesToolStripMenuItem_Click);
            // 
            // processingToolStripMenuItem
            // 
            this.processingToolStripMenuItem.Name = "processingToolStripMenuItem";
            this.processingToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.processingToolStripMenuItem.Text = "Processing";
            // 
            // processingStatusStrip
            // 
            this.processingStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.processingStatusStrip.Location = new System.Drawing.Point(0, 645);
            this.processingStatusStrip.Name = "processingStatusStrip";
            this.processingStatusStrip.Size = new System.Drawing.Size(1021, 22);
            this.processingStatusStrip.TabIndex = 4;
            this.processingStatusStrip.Text = "Status:";
            this.processingStatusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.processingStatusStrip_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // ProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 667);
            this.Controls.Add(this.processingStatusStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProcessingForm";
            this.Text = "ProcessingForm";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.processingStatusStrip.ResumeLayout(false);
            this.processingStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtitlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processingToolStripMenuItem;
        private System.Windows.Forms.Button speedVideo;
        private System.Windows.Forms.Button addAudio;
        private System.Windows.Forms.Button addWatermark;
        private System.Windows.Forms.Button createSketch;
        private System.Windows.Forms.Button extractAudio;
        private System.Windows.Forms.Button createbwVideo;
        private System.Windows.Forms.Button muteAudio;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip processingStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}