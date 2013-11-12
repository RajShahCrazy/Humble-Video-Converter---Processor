namespace HumbleVideoConverterProcessor
{
    partial class Form1
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
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.SubtitlesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(42, 33);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ProcessButton
            // 
            this.ProcessButton.Location = new System.Drawing.Point(104, 114);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(75, 23);
            this.ProcessButton.TabIndex = 1;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // SubtitlesButton
            // 
            this.SubtitlesButton.Location = new System.Drawing.Point(175, 193);
            this.SubtitlesButton.Name = "SubtitlesButton";
            this.SubtitlesButton.Size = new System.Drawing.Size(75, 23);
            this.SubtitlesButton.TabIndex = 2;
            this.SubtitlesButton.Text = "Subtitles";
            this.SubtitlesButton.UseVisualStyleBackColor = true;
            this.SubtitlesButton.Click += new System.EventHandler(this.SubtitlesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.SubtitlesButton);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.ConvertButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.Button SubtitlesButton;
    }
}

