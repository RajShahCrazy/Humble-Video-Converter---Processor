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

    public partial class Form1 : Form
    {
        //private Form2 form_subtitle;
        //private ProcessingForm form_processing;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {

        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            //form_processing = new ProcessingForm();
            //form_processing.Activate();
            //form_processing.Show();

        }

        private void SubtitlesButton_Click(object sender, EventArgs e)
        {
            //form_subtitle = new Form2();
            //form_subtitle.Activate();
            //form_subtitle.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seriously? When were user manuals ever useful? Use G-O-O-G-L-E!!!");
        }

        private void processingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //form_processing = new ProcessingForm();
            //form_processing.Activate();
            //form_processing.Show();

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void AddFileFromFileExplorer_Click(object sender, EventArgs e)
        {

        }
    }
}
