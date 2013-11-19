using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using System.IO;

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

        private bool isVideoFileOpen()
        {
            return previewVideoProcessing.URL != null;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openVideoForProcessingDialog = new OpenFileDialog();

            openVideoForProcessingDialog.DefaultExt = "wmv";
            
            //add supporting file types in this format
            openVideoForProcessingDialog.Filter = "AVI files (.avi)|*.avi"
                + "|MKV files (.mkv)|*.mkv"
                + "|MPEG-4 files (*.*)|*.mpeg4"
                + "|WMV files (*.wmv)|*.wmv"
                //add new file formats to support here 
                //format to use: "|FileFormat files (*.ext)|*.ext"
                //example: "|WMV files (*.wmv)|*.wmv"
                + "|All files (*.*)|*.*";     

            openVideoForProcessingDialog.FilterIndex = 1;
            openVideoForProcessingDialog.Multiselect = true;
            openVideoForProcessingDialog.ShowDialog();
            
            //validate the file and show it in the player stub
            if (openVideoForProcessingDialog.FileName.Length > 0)
            {
                previewVideoProcessing.URL = @openVideoForProcessingDialog.FileName.ToString();

            }

        }

        private void addAudio_Click(object sender, EventArgs e)
        {

        }

        private void extractAudio_Click(object sender, EventArgs e)
        {
            string args = " -i " + previewVideoProcessing.URL + " -vn -ac 2 -ar 44100 -ab 320k -f mp3 " + FFMpegProxy.getOutputFileName(previewVideoProcessing.URL, "AudioExtracted", "mp3");
            String commandResult = FFMpegProxy.runCommand(args);
            if (commandResult != null)
            {
                MessageBox.Show("Unable to extract the video. Received an exception from the underlying FFMpeg library: " + commandResult);
            }

        }

        private void muteAudio_Click(object sender, EventArgs e)
        {
            string args = " -i " + previewVideoProcessing.URL + " -an -q:v 0 " + FFMpegProxy.getOutputFileName(previewVideoProcessing.URL, "AudioMuted");
            String commandResult = FFMpegProxy.runCommand(args);
            if (commandResult != null)
            {
                MessageBox.Show("Unable to extract the video. Received an exception from the underlying FFMpeg library: " + commandResult);
            }
        }

        private void createbwVideo_Click(object sender, EventArgs e)
        {

        }

        private void createSketch_Click(object sender, EventArgs e)
        {

        }

        private void addWatermark_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void processingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seriously? When were user manuals ever useful? Use G-O-O-G-L-E!!!");
        }

        private void preview_process_WMP_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e)
        {
            try
            {
                IWMPMedia2 errSrc = e.pMediaObject as IWMPMedia2;
                IWMPErrorItem errItem = errSrc.Error;
                MessageBox.Show("Error " + errItem.errorCode.ToString("X")
                        + " in " + errSrc.sourceURL);
            }
            catch (InvalidCastException)
            {
            }

        }
    }
}
