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
            try
            {

                //Hardcoding the speed - this will create a 4X video
                string args = "-y -i " + @"""" + previewVideoProcessing.URL + @"""" + " -r 16 -filter:v "
                                       + "\"setpts=0.250*PTS\"" + " -filter:a \"atempo=2.0,atempo=2.0\" " + @""""
                                       + FFMpegProxy.getOutputFileName(previewVideoProcessing.URL, "_faster", Path.GetExtension(previewVideoProcessing.URL)) + @"""";
                String commandResult = FFMpegProxy.runCommand(args);
                if (commandResult != null)
                {
                    MessageBox.Show("Unable to speed up the video. Received an exception from the underlying FFMpeg library: " + commandResult);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Open a file using File->Open and then choose an action to perform");
            }
            


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
            openVideoForProcessingDialog.Filter = "AVI files |*.avi"
                + "|MKV files |*.mkv"
                + "|MPEG-4 files |*.mpeg4"
                + "|WMV files |*.wmv"
                //add new file formats to support here 
                //format to use: "|FileFormat files (*.ext)|*.ext"
                //example: "|WMV files (*.wmv)|*.wmv"
                + "|All files |*.*";     

            openVideoForProcessingDialog.FilterIndex = 4;
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
            OpenFileDialog openAudioForMixingWithVideo = new OpenFileDialog();

            openAudioForMixingWithVideo.DefaultExt = "mp3";

            //add supporting file types in this format
            openAudioForMixingWithVideo.Filter = "MP3 files (.mp3)|*.mp3"
                + "|WMA files (.wma)|*.wma"
                //add new file formats to support here 
                //format to use: "|FileFormat files (*.ext)|*.ext"
                //example: "|WMV files (*.wmv)|*.wmv"
                + "|All files (*.*)|*.*";

            openAudioForMixingWithVideo.FilterIndex = 1;
            openAudioForMixingWithVideo.Multiselect = true;
            openAudioForMixingWithVideo.ShowDialog();

            //validate the file and mix it with video
            if (openAudioForMixingWithVideo.FileName.Length > 0)
            {
                string args = "-y -i " + @"""" + previewVideoProcessing.URL + @"""" +
                                " -i " + @"""" + openAudioForMixingWithVideo.FileName.ToString() + @""""
                                       + " -vcodec copy -acodec copy "
                                       + @"""" + FFMpegProxy.getOutputFileName(previewVideoProcessing.URL, "_AudioMixedToVideo", Path.GetExtension(previewVideoProcessing.URL)) + @"""";

                String commandResult = FFMpegProxy.runCommand(args);
                if (commandResult != null)
                {
                    MessageBox.Show("Unable to mix audio to video. Received an exception from the underlying FFMpeg library: " + commandResult);
                }

            }
            
        }

        private void extractAudio_Click(object sender, EventArgs e)
        {
            try
            {
                string args = "-y -i " + @"""" + previewVideoProcessing.URL + @"""" + " -vn -ac 2 -ar 44100 -ab 320k -f mp3 " + @""""
                                   + FFMpegProxy.getOutputFileName(previewVideoProcessing.URL, "_AudioExtracted", ".mp3") + @"""";
                String commandResult = FFMpegProxy.runCommand(args);
                if (commandResult != null)
                {
                    MessageBox.Show("Unable to extract the video. Received an exception from the underlying FFMpeg library: " + commandResult);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Open a file using File->Open and then choose an action to perform");
            }

        }

        private void muteAudio_Click(object sender, EventArgs e)
        {
            try
            {

                string args = "-y -i " + @"""" + previewVideoProcessing.URL + @"""" + " -an -q:v 0 " + @""""
                                       + FFMpegProxy.getOutputFileName(previewVideoProcessing.URL, "_AudioMuted") + @"""";
                String commandResult = FFMpegProxy.runCommand(args);
                if (commandResult != null)
                {
                    MessageBox.Show("Unable to extract the video. Received an exception from the underlying FFMpeg library: " + commandResult);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Open a file using File->Open and then choose an action to perform");
            }

        }

        private void createbwVideo_Click(object sender, EventArgs e)
        {
            try
            {
                string args = "-y -i " + @"""" + previewVideoProcessing.URL + @"""" + " -q:v 0 -vf format=gray " + @""""
                                       + FFMpegProxy.getOutputFileName(previewVideoProcessing.URL, "_Grayed") + @"""";
                String commandResult = FFMpegProxy.runCommand(args);
                if (commandResult != null)
                {
                    MessageBox.Show("Unable to grayscale the video. Received an exception from the underlying FFMpeg library: " + commandResult);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Open a file using File->Open and then choose an action to perform");
            }
        }

        private void createSketch_Click(object sender, EventArgs e)
        {

        }

        private void addWatermark_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openPNGForWatermark = new OpenFileDialog();

                openPNGForWatermark.DefaultExt = "png";

                //add supporting file types in this format
                openPNGForWatermark.Filter = "PNG files (.png)|*.png";

                openPNGForWatermark.FilterIndex = 1;
                openPNGForWatermark.Multiselect = false;
                openPNGForWatermark.ShowDialog();

                //validate the file and show it in the player stub
                if (openPNGForWatermark.FileName.Length <= 0)
                {
                    MessageBox.Show("Please select a valid PNG file for watermarking");
                    openPNGForWatermark.ShowDialog();
                }

                string args = "-y -i " + @"""" + previewVideoProcessing.URL + @"""" +  " -i " + @"""" + openPNGForWatermark.FileName.ToString() + @"""" +
                    " -q:v 0 -filter_complex overlay=\"(main_w/2)-(overlay_w/2):(main_h/2)-(overlay_h)/2\" " + @""""
                                       + FFMpegProxy.getOutputFileName(previewVideoProcessing.URL, "_Watermarked") + @"""";

                String commandResult = FFMpegProxy.runCommand(args);
                if (commandResult != null)
                {
                    MessageBox.Show("Unable to grayscale the video. Received an exception from the underlying FFMpeg library: " + commandResult);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Open a file using File->Open and then choose an action to perform");
            }

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

        private void slowDownVideo_Click(object sender, EventArgs e)
        {
            try
            {

                //Hardcoding the speed to slow down to 1/2 original speed
                string args = "-y -i " + @"""" + previewVideoProcessing.URL + @"""" + " -r 16 -filter:v "
                                       + "\"setpts=2.0*PTS\"" + " -filter:a \"atempo=0.5\" " + @""""
                                       + FFMpegProxy.getOutputFileName(previewVideoProcessing.URL, "_slower", Path.GetExtension(previewVideoProcessing.URL)) + @"""";
                String commandResult = FFMpegProxy.runCommand(args);
                if (commandResult != null)
                {
                    MessageBox.Show("Unable to slow down the video. Received an exception from the underlying FFMpeg library: " + commandResult);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Open a file using File->Open and then choose an action to perform");
            }
            
        }
    }
}
