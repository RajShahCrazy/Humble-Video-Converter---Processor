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
            this.panel1 = new System.Windows.Forms.Panel();
            this.slowDownVideo = new System.Windows.Forms.Button();
            this.addWatermark = new System.Windows.Forms.Button();
            this.createSketch = new System.Windows.Forms.Button();
            this.extractAudio = new System.Windows.Forms.Button();
            this.createbwVideo = new System.Windows.Forms.Button();
            this.muteAudio = new System.Windows.Forms.Button();
            this.addAudio = new System.Windows.Forms.Button();
            this.speedUpVideo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtitlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processingStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.previewVideoProcessing = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.processingStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewVideoProcessing)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.slowDownVideo);
            this.panel1.Controls.Add(this.addWatermark);
            this.panel1.Controls.Add(this.createSketch);
            this.panel1.Controls.Add(this.extractAudio);
            this.panel1.Controls.Add(this.createbwVideo);
            this.panel1.Controls.Add(this.muteAudio);
            this.panel1.Controls.Add(this.addAudio);
            this.panel1.Controls.Add(this.speedUpVideo);
            this.panel1.Location = new System.Drawing.Point(64, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 241);
            this.panel1.TabIndex = 2;
            // 
            // slowDownVideo
            // 
            this.slowDownVideo.Location = new System.Drawing.Point(3, 35);
            this.slowDownVideo.Name = "slowDownVideo";
            this.slowDownVideo.Size = new System.Drawing.Size(249, 23);
            this.slowDownVideo.TabIndex = 7;
            this.slowDownVideo.Text = "Slow Down Video";
            this.slowDownVideo.UseVisualStyleBackColor = true;
            this.slowDownVideo.Click += new System.EventHandler(this.slowDownVideo_Click);
            // 
            // addWatermark
            // 
            this.addWatermark.Location = new System.Drawing.Point(3, 209);
            this.addWatermark.Name = "addWatermark";
            this.addWatermark.Size = new System.Drawing.Size(249, 23);
            this.addWatermark.TabIndex = 6;
            this.addWatermark.Text = "Add Watermark";
            this.addWatermark.UseVisualStyleBackColor = true;
            this.addWatermark.Click += new System.EventHandler(this.addWatermark_Click);
            // 
            // createSketch
            // 
            this.createSketch.Location = new System.Drawing.Point(3, 180);
            this.createSketch.Name = "createSketch";
            this.createSketch.Size = new System.Drawing.Size(249, 23);
            this.createSketch.TabIndex = 5;
            this.createSketch.Text = "Create sketch from video";
            this.createSketch.UseVisualStyleBackColor = true;
            this.createSketch.Click += new System.EventHandler(this.createSketch_Click);
            // 
            // extractAudio
            // 
            this.extractAudio.Location = new System.Drawing.Point(3, 93);
            this.extractAudio.Name = "extractAudio";
            this.extractAudio.Size = new System.Drawing.Size(249, 23);
            this.extractAudio.TabIndex = 4;
            this.extractAudio.Text = "Extract Audio";
            this.extractAudio.UseVisualStyleBackColor = true;
            this.extractAudio.Click += new System.EventHandler(this.extractAudio_Click);
            // 
            // createbwVideo
            // 
            this.createbwVideo.Location = new System.Drawing.Point(3, 151);
            this.createbwVideo.Name = "createbwVideo";
            this.createbwVideo.Size = new System.Drawing.Size(249, 23);
            this.createbwVideo.TabIndex = 3;
            this.createbwVideo.Text = "Convert Video to Black and White";
            this.createbwVideo.UseVisualStyleBackColor = true;
            this.createbwVideo.Click += new System.EventHandler(this.createbwVideo_Click);
            // 
            // muteAudio
            // 
            this.muteAudio.Location = new System.Drawing.Point(3, 122);
            this.muteAudio.Name = "muteAudio";
            this.muteAudio.Size = new System.Drawing.Size(249, 23);
            this.muteAudio.TabIndex = 2;
            this.muteAudio.Text = "Mute Audio";
            this.muteAudio.UseVisualStyleBackColor = true;
            this.muteAudio.Click += new System.EventHandler(this.muteAudio_Click);
            // 
            // addAudio
            // 
            this.addAudio.Location = new System.Drawing.Point(3, 64);
            this.addAudio.Name = "addAudio";
            this.addAudio.Size = new System.Drawing.Size(249, 23);
            this.addAudio.TabIndex = 1;
            this.addAudio.Text = "Add Audio";
            this.addAudio.UseVisualStyleBackColor = true;
            this.addAudio.Click += new System.EventHandler(this.addAudio_Click);
            // 
            // speedUpVideo
            // 
            this.speedUpVideo.Location = new System.Drawing.Point(3, 4);
            this.speedUpVideo.Name = "speedUpVideo";
            this.speedUpVideo.Size = new System.Drawing.Size(249, 23);
            this.speedUpVideo.TabIndex = 0;
            this.speedUpVideo.Text = "Speed Up Video";
            this.speedUpVideo.UseVisualStyleBackColor = true;
            this.speedUpVideo.Click += new System.EventHandler(this.speedVideo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.convertToolStripMenuItem,
            this.subtitlesToolStripMenuItem,
            this.processingToolStripMenuItem,
            this.helpToolStripMenuItem});
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
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.convertToolStripMenuItem.Text = "Convert";
            // 
            // subtitlesToolStripMenuItem
            // 
            this.subtitlesToolStripMenuItem.Name = "subtitlesToolStripMenuItem";
            this.subtitlesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.subtitlesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.subtitlesToolStripMenuItem.Text = "Subtitles";
            this.subtitlesToolStripMenuItem.Click += new System.EventHandler(this.subtitlesToolStripMenuItem_Click);
            // 
            // processingToolStripMenuItem
            // 
            this.processingToolStripMenuItem.Enabled = false;
            this.processingToolStripMenuItem.Name = "processingToolStripMenuItem";
            this.processingToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.processingToolStripMenuItem.Text = "Processing";
            this.processingToolStripMenuItem.Click += new System.EventHandler(this.processingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // processingStatusStrip
            // 
            this.processingStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
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
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // previewVideoProcessing
            // 
            this.previewVideoProcessing.Enabled = true;
            this.previewVideoProcessing.Location = new System.Drawing.Point(476, 60);
            this.previewVideoProcessing.Name = "previewVideoProcessing";
            this.previewVideoProcessing.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("previewVideoProcessing.OcxState")));
            this.previewVideoProcessing.Size = new System.Drawing.Size(518, 261);
            this.previewVideoProcessing.TabIndex = 5;
            this.previewVideoProcessing.MediaError += new AxWMPLib._WMPOCXEvents_MediaErrorEventHandler(this.preview_process_WMP_MediaError);
            // 
            // ProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 667);
            this.Controls.Add(this.previewVideoProcessing);
            this.Controls.Add(this.processingStatusStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProcessingForm";
            this.Text = "HVCP - Processing";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.processingStatusStrip.ResumeLayout(false);
            this.processingStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewVideoProcessing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtitlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processingToolStripMenuItem;
        private System.Windows.Forms.Button speedUpVideo;
        private System.Windows.Forms.Button addAudio;
        private System.Windows.Forms.Button addWatermark;
        private System.Windows.Forms.Button createSketch;
        private System.Windows.Forms.Button extractAudio;
        private System.Windows.Forms.Button createbwVideo;
        private System.Windows.Forms.Button muteAudio;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip processingStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer previewVideoProcessing;
        private System.Windows.Forms.Button slowDownVideo;
    }
}