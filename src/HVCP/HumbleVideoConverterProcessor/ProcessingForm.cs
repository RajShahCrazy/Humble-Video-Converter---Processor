using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumbleVideoConverterProcessor
{
    public partial class ProcessingForm : Form
    {
        public ProcessingForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void subtitlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void speedVideo_Click(object sender, EventArgs e)
        {
            processingStatusStrip.Text = "Speed up / Slow down videos";
        }

        private void processingStatusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openVideoForProcessingDialog = new OpenFileDialog();

            //add supporting file types in this format
            openVideoForProcessingDialog.Filter = "AVI files (.avi)| *.avi"
                + " |MKV files (.mkv) | *.mkv"
                + " |MPEG-4 files (*.*)| *.mpeg4"
                //add new file formats to support here 
                //format to use: " |FileFormat files (*.ext) | *.ext"
                + " |All Files (*.*)| *.*";
                    
            openVideoForProcessingDialog.FilterIndex = 1;
            openVideoForProcessingDialog.Multiselect = true;
            openVideoForProcessingDialog.ShowDialog();
            
        }
    }
}
