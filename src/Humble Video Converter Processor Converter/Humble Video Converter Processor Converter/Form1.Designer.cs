namespace Humble_Video_Converter_Processor_Converter
{
    partial class ConverterModule
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
            this.VideosToBeConverted = new System.Windows.Forms.ListBox();
            this.VideoListLabel = new System.Windows.Forms.Label();
            this.AddFileFromFileExplorer = new System.Windows.Forms.Button();
            this.VideoFormatsDropDownLabel = new System.Windows.Forms.Label();
            this.VideoFormats = new System.Windows.Forms.ComboBox();
            this.AudioFormatsDropDownLabel = new System.Windows.Forms.Label();
            this.AudioFormats = new System.Windows.Forms.ComboBox();
            this.DestinationFolderLabel = new System.Windows.Forms.Label();
            this.DestinatonFolderChooseButton = new System.Windows.Forms.Button();
            this.ProgressBars = new System.Windows.Forms.FlowLayoutPanel();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VideosToBeConverted
            // 
            this.VideosToBeConverted.AllowDrop = true;
            this.VideosToBeConverted.FormattingEnabled = true;
            this.VideosToBeConverted.Location = new System.Drawing.Point(12, 54);
            this.VideosToBeConverted.Name = "VideosToBeConverted";
            this.VideosToBeConverted.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.VideosToBeConverted.Size = new System.Drawing.Size(142, 147);
            this.VideosToBeConverted.TabIndex = 0;
            // 
            // VideoListLabel
            // 
            this.VideoListLabel.AutoSize = true;
            this.VideoListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoListLabel.Location = new System.Drawing.Point(52, 27);
            this.VideoListLabel.Name = "VideoListLabel";
            this.VideoListLabel.Size = new System.Drawing.Size(45, 13);
            this.VideoListLabel.TabIndex = 1;
            this.VideoListLabel.Text = "Videos";
            // 
            // AddFileFromFileExplorer
            // 
            this.AddFileFromFileExplorer.AllowDrop = true;
            this.AddFileFromFileExplorer.Location = new System.Drawing.Point(12, 221);
            this.AddFileFromFileExplorer.Name = "AddFileFromFileExplorer";
            this.AddFileFromFileExplorer.Size = new System.Drawing.Size(75, 23);
            this.AddFileFromFileExplorer.TabIndex = 2;
            this.AddFileFromFileExplorer.Text = "Add A File";
            this.AddFileFromFileExplorer.UseVisualStyleBackColor = true;
            this.AddFileFromFileExplorer.Click += new System.EventHandler(this.AddFileFromFileExplorer_Click);
            // 
            // VideoFormatsDropDownLabel
            // 
            this.VideoFormatsDropDownLabel.AutoSize = true;
            this.VideoFormatsDropDownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoFormatsDropDownLabel.Location = new System.Drawing.Point(234, 27);
            this.VideoFormatsDropDownLabel.Name = "VideoFormatsDropDownLabel";
            this.VideoFormatsDropDownLabel.Size = new System.Drawing.Size(87, 13);
            this.VideoFormatsDropDownLabel.TabIndex = 3;
            this.VideoFormatsDropDownLabel.Text = "Video Formats";
            // 
            // VideoFormats
            // 
            this.VideoFormats.FormattingEnabled = true;
            this.VideoFormats.Items.AddRange(new object[] {
            "",
            "flv",
            "mp4",
            "avi",
            "dv",
            "mpeg",
            "QuickTime Animation (RLE) video",
            "Raw Video",
            "RealVideo 2.0",
            "WMV7"});
            this.VideoFormats.Location = new System.Drawing.Point(237, 54);
            this.VideoFormats.Name = "VideoFormats";
            this.VideoFormats.Size = new System.Drawing.Size(121, 21);
            this.VideoFormats.TabIndex = 4;
            this.VideoFormats.SelectedIndexChanged += new System.EventHandler(this.VideoFormats_SelectedIndexChanged);
            // 
            // AudioFormatsDropDownLabel
            // 
            this.AudioFormatsDropDownLabel.AutoSize = true;
            this.AudioFormatsDropDownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AudioFormatsDropDownLabel.Location = new System.Drawing.Point(414, 27);
            this.AudioFormatsDropDownLabel.Name = "AudioFormatsDropDownLabel";
            this.AudioFormatsDropDownLabel.Size = new System.Drawing.Size(87, 13);
            this.AudioFormatsDropDownLabel.TabIndex = 5;
            this.AudioFormatsDropDownLabel.Text = "Audio Formats";
            // 
            // AudioFormats
            // 
            this.AudioFormats.FormattingEnabled = true;
            this.AudioFormats.Items.AddRange(new object[] {
            "",
            "mp3",
            "RealAudion 3.0",
            "Windows Media Audio (WMA) 2"});
            this.AudioFormats.Location = new System.Drawing.Point(417, 54);
            this.AudioFormats.Name = "AudioFormats";
            this.AudioFormats.Size = new System.Drawing.Size(121, 21);
            this.AudioFormats.TabIndex = 6;
            this.AudioFormats.SelectedIndexChanged += new System.EventHandler(this.AudioFormats_SelectedIndexChanged);
            // 
            // DestinationFolderLabel
            // 
            this.DestinationFolderLabel.AutoSize = true;
            this.DestinationFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationFolderLabel.Location = new System.Drawing.Point(234, 111);
            this.DestinationFolderLabel.Name = "DestinationFolderLabel";
            this.DestinationFolderLabel.Size = new System.Drawing.Size(169, 13);
            this.DestinationFolderLabel.TabIndex = 7;
            this.DestinationFolderLabel.Text = "<Please Choose a Location>";
            // 
            // DestinatonFolderChooseButton
            // 
            this.DestinatonFolderChooseButton.Location = new System.Drawing.Point(237, 139);
            this.DestinatonFolderChooseButton.Name = "DestinatonFolderChooseButton";
            this.DestinatonFolderChooseButton.Size = new System.Drawing.Size(107, 23);
            this.DestinatonFolderChooseButton.TabIndex = 8;
            this.DestinatonFolderChooseButton.Text = "Destination Folder";
            this.DestinatonFolderChooseButton.UseVisualStyleBackColor = true;
            this.DestinatonFolderChooseButton.Click += new System.EventHandler(this.DestinatonFolderChooseButton_Click);
            // 
            // ProgressBars
            // 
            this.ProgressBars.AutoScroll = true;
            this.ProgressBars.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ProgressBars.Location = new System.Drawing.Point(12, 276);
            this.ProgressBars.Name = "ProgressBars";
            this.ProgressBars.Size = new System.Drawing.Size(583, 128);
            this.ProgressBars.TabIndex = 9;
            this.ProgressBars.WrapContents = false;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.Location = new System.Drawing.Point(237, 196);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(146, 48);
            this.ConvertButton.TabIndex = 10;
            this.ConvertButton.Text = "CONVERT";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ConverterModule
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 416);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.ProgressBars);
            this.Controls.Add(this.DestinatonFolderChooseButton);
            this.Controls.Add(this.DestinationFolderLabel);
            this.Controls.Add(this.AudioFormats);
            this.Controls.Add(this.AudioFormatsDropDownLabel);
            this.Controls.Add(this.VideoFormats);
            this.Controls.Add(this.VideoFormatsDropDownLabel);
            this.Controls.Add(this.AddFileFromFileExplorer);
            this.Controls.Add(this.VideoListLabel);
            this.Controls.Add(this.VideosToBeConverted);
            this.Name = "ConverterModule";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox VideosToBeConverted;
        private System.Windows.Forms.Label VideoListLabel;
        private System.Windows.Forms.Button AddFileFromFileExplorer;
        private System.Windows.Forms.Label VideoFormatsDropDownLabel;
        private System.Windows.Forms.ComboBox VideoFormats;
        private System.Windows.Forms.Label AudioFormatsDropDownLabel;
        private System.Windows.Forms.ComboBox AudioFormats;
        private System.Windows.Forms.Label DestinationFolderLabel;
        private System.Windows.Forms.Button DestinatonFolderChooseButton;
        private System.Windows.Forms.FlowLayoutPanel ProgressBars;
        private System.Windows.Forms.Button ConvertButton;
    }
}

