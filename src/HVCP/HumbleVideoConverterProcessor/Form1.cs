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
        private Form2 form_subtitle;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {

        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {

        }

        private void SubtitlesButton_Click(object sender, EventArgs e)
        {
            form_subtitle = new Form2();
            form_subtitle.Activate();
            form_subtitle.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
