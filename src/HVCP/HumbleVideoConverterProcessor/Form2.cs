using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;




namespace HumbleVideoConverterProcessor
{

    public partial class Form2 : Form
    {
        private System.IO.StreamReader srtFileReader;
        private String srtFileName;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO  Insert a valid path in the line below.
            // MessageBox.Show("Form 2 loaded");
           // PlayFile(@"Wildlife.wmv");
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        
        }

        
        private void PlayFile(String url)
        {
            //axWindowsMediaPlayer1.PlayStateChange +=
            //    new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            //axWindowsMediaPlayer1.MediaError +=
            //    new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            //axWindowsMediaPlayer1.URL = url;
            //axWindowsMediaPlayer1.controls.play();
        }

        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                this.Close();
            }
        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.");
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_write_Click(object sender, EventArgs e)
        {

        }

        private void fineToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                axWindowsMediaPlayer1.URL = @openVideoForProcessingDialog.FileName.ToString();

            }
            //Read or create srt file
            string srtName;
            srtName = @openVideoForProcessingDialog.FileName.ToString();
            int index = srtName.LastIndexOf('.');
            srtName = srtName.Substring(0, index) + ".srt";
            //MessageBox.Show(srtName);
            srtFileName = new String(srtName.ToCharArray());
            
            if(File.Exists(srtFileName)){
                MessageBox.Show(srtFileName + " already exists");
                try
                {
                    srtFileReader = new System.IO.StreamReader(srtFileName);
                }
                catch
                {
                    MessageBox.Show("Error:"+ srtFileName + " cannot be open");
                }

                //read srt file


            } else {
                MessageBox.Show(srtFileName + " does not exists. The file will be created");
                try
                {
                    File.Create(srtFileName);
                }
                catch
                {
                    MessageBox.Show("Error:" + srtFileName + " cannot be created");
                }
            }
            
        }

        private void btn_addStart_Click(object sender, EventArgs e)
        {
            double currentPosition;
            currentPosition = (axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
            //MessageBox.Show(currentPosition.ToString());
            TimeSpan t = TimeSpan.FromSeconds(currentPosition);
            txb_sh.Text = (t.Hours).ToString();
            txb_sm.Text = (t.Minutes).ToString();
            txb_ss.Text = (t.Seconds).ToString();
            txb_sms.Text = (t.Milliseconds).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_addEnd_Click(object sender, EventArgs e)
        {
            double currentPosition;
            currentPosition = (axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
            //MessageBox.Show(currentPosition.ToString());
            TimeSpan t = TimeSpan.FromSeconds(currentPosition);
            txb_eh.Text = (t.Hours).ToString();
            txb_em.Text = (t.Minutes).ToString();
            txb_es.Text = (t.Seconds).ToString();
            txb_ems.Text = (t.Milliseconds).ToString();

        }
    }
}




