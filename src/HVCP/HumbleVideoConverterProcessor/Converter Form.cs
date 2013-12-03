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
    public partial class ConverterModule : Form
    {
        public string videoFormat;

        public string audioFormat;

        List<MediaFile> videosUnderConsideration = new List<MediaFile>();

        public ConverterModule()
        {
            InitializeComponent();

            this.VideosToBeConverted.DragDrop += new System.Windows.Forms.DragEventHandler(this.VideosToBeConverted_DragDrop);

            this.VideosToBeConverted.DragEnter += new System.Windows.Forms.DragEventHandler(this.VideosToBeConverted_DragEnter);

            ConvertButton.ForeColor = Color.Maroon;

            ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }


        private void VideosToBeConverted_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int indexOfItem = VideosToBeConverted.IndexFromPoint(e.X, e.Y);
            if (indexOfItem >= 0 && indexOfItem
              < VideosToBeConverted.Items.Count)  // check we clicked down on a string
            {
                // Set allowed DragDropEffect to Copy selected 
                // from DragDropEffects enumberation of None, Move, All etc.
                VideosToBeConverted.DoDragDrop(VideosToBeConverted.Items[indexOfItem], DragDropEffects.Copy);
            }
        }

        private void AddFileFromFileExplorer_Click(object sender, EventArgs e)
        {
            // Show Open File dialog
            OpenFileDialog openDlg = new OpenFileDialog();

            openDlg.Filter = "AVI files |*.avi"
                + "|MKV files |*.mkv"
                + "|MPEG-4 files |*.mpeg4"
                + "|WMV files |*.wmv"
                //add new file formats to support here 
                //format to use: "|FileFormat files (*.ext)|*.ext"
                //example: "|WMV files (*.wmv)|*.wmv"
                + "|All files |*.*";

            openDlg.Multiselect = true;

            openDlg.FileName = "";
            openDlg.CheckFileExists = true;
            openDlg.CheckPathExists = true;

            DialogResult result = openDlg.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            foreach (string fileName in openDlg.SafeFileNames)
            {
                VideosToBeConverted.Items.Add(fileName);
            }

            foreach (string fileName in openDlg.FileNames)
            {
                MediaFile newMediaFile = new MediaFile(fileName.Split('\\').Last(), fileName, false, "", "");

                videosUnderConsideration.Add(newMediaFile);
            }
        }

        private void VideosToBeConverted_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void VideosToBeConverted_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string fileName in files)
            {
                VideosToBeConverted.Items.Add(fileName.Split('\\').Last());
            }
        }

        private void VideoFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            videoFormat = (string)comboBox.SelectedItem;

            if (videoFormat == "")
            {
                AudioFormats.Enabled = true;
            }
            else
            {
                audioFormat = "";
                AudioFormats.SelectedIndex = 0;
                AudioFormats.Enabled = false;
            }
        }

        private void AudioFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            audioFormat = (string)comboBox.SelectedItem;

            if (audioFormat == "")
            {
                VideoFormats.Enabled = true;
            }
            else
            {
                videoFormat = "";
                VideoFormats.SelectedIndex = 0;
                VideoFormats.Enabled = false;
            }
        }

        private void DestinatonFolderChooseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openDlg = new FolderBrowserDialog();

            DialogResult result = openDlg.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            DestinationFolderLabel.Text = openDlg.SelectedPath;
        }

        private void addProgressBarToTheWindow()
        {
            FlowLayoutPanel f = new FlowLayoutPanel();
            f.Size = new Size(5400, 30);
            f.FlowDirection = FlowDirection.LeftToRight;
            f.WrapContents = true;

            f.HorizontalScroll.Visible = true;
            f.VerticalScroll.Maximum = 0;

            f.AutoScroll = true;

            ProgressBar p = new ProgressBar();
            p.Size = new Size(420, 24);
            p.Maximum = 100;
            p.Minimum = 0;
            //            p.Location = new Point(0, 0);
            p.Value = 60;
            p.Visible = true;

            //            p.Show();

            f.Controls.Add(p);

            Label l = new Label();

            l.Text = p.Value.ToString() + "%";// +"vbdfkjvdfkjlvdfvdfbdkj.avi";
            l.Visible = true;
            l.Size = new Size(300, 24);
            //  l.Location = new Point(120, 0);

            f.Controls.Add(l);


            f.Show();

            ProgressBars.Controls.Add(f);
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            List<string> selectedFilesForConversion = new List<string>();

            List<MediaFile> unSelectedFiles = new List<MediaFile>();

            List<MediaFile> selectedFiles = new List<MediaFile>();

            for (int i = 0; i < VideosToBeConverted.Items.Count; i++)
            {
                if (!VideosToBeConverted.SelectedItems.Contains(VideosToBeConverted.Items[i]))
                {
                    MediaFile newMediaFile = new MediaFile();
                    newMediaFile.Name = videosUnderConsideration[i].Name;
                    newMediaFile.IsToBeConverted = videosUnderConsideration[i].IsToBeConverted;
                    newMediaFile.FullPath = videosUnderConsideration[i].FullPath;
                    newMediaFile.DestinationFormat = videosUnderConsideration[i].DestinationFormat;
                    newMediaFile.DestinationLocation = videosUnderConsideration[i].DestinationLocation;

                    unSelectedFiles.Add(newMediaFile);
                }
                else
                {
                    MediaFile newMediaFile = new MediaFile();
                    newMediaFile.Name = videosUnderConsideration[i].Name;
                    newMediaFile.IsToBeConverted = videosUnderConsideration[i].IsToBeConverted;
                    newMediaFile.FullPath = videosUnderConsideration[i].FullPath;
                    newMediaFile.DestinationFormat = videosUnderConsideration[i].DestinationFormat;
                    newMediaFile.DestinationLocation = videosUnderConsideration[i].DestinationLocation;

                    newMediaFile.IsToBeConverted = true;

                    if (videoFormat != "")
                    {
                        newMediaFile.DestinationFormat = videoFormat;
                    }
                    else
                    {
                        newMediaFile.DestinationFormat = audioFormat;
                    }

                    newMediaFile.DestinationLocation = DestinationFolderLabel.Text;

                    selectedFiles.Add(newMediaFile);
                }
            }


            videosUnderConsideration.Clear();
            VideosToBeConverted.Items.Clear();

            for (int i = 0; i < unSelectedFiles.Count; i++)
            {
                videosUnderConsideration.Add(unSelectedFiles[i]);

                VideosToBeConverted.Items.Add(unSelectedFiles[i].Name);
            }

            foreach (MediaFile mediaFile in selectedFiles)
            {
                mediaFile.convert(ProgressBars);
            }

        }
    }
}
