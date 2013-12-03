using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace HumbleVideoConverterProcessor
{
    class MediaFile
    {
        private string _name;

        private string _fullPath;

        private bool _isToBeConverted;

        private string _destinationFormat;

        private string _destinationLocation;

        public MediaFile()
        {
            _name = "";
            _fullPath = "";
            _isToBeConverted = false;
            _destinationFormat = "";
            _destinationLocation = "";
        }

        public MediaFile(string name, string fullPath, bool isToBeConverted, string destinationFormat, string destinationLocation)
        {
            _name = name;
            _fullPath = fullPath;
            _isToBeConverted = isToBeConverted;
            _destinationFormat = destinationFormat;
            _destinationLocation = destinationLocation;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string FullPath
        {
            get
            {
                return _fullPath;
            }
            set
            {
                _fullPath = value;
            }
        }

        public bool IsToBeConverted
        {
            get
            {
                return _isToBeConverted;
            }
            set
            {
                _isToBeConverted = value;
            }
        }

        public string DestinationFormat
        {
            get
            {
                return _destinationFormat;
            }
            set
            {
                _destinationFormat = value;
            }
        }

        public string DestinationLocation
        {
            get
            {
                return _destinationLocation;
            }
            set
            {
                _destinationLocation = value;
            }
        }

        public bool convert(FlowLayoutPanel progressBar)
        {
            if (_isToBeConverted == true)
            {
                addProgressBarToTheWindow(progressBar);
                
                ProcessStartInfo info = new ProcessStartInfo(Constants.FFMPEG_PATH);
                //string fullPath = @_fullPath.Replace(@"\\", @"\");
                info.Arguments = "-y -i " + @"""" + _fullPath + @"""" + " -f " + _destinationFormat + " " + @"""" + _destinationLocation +"\\" +  _name.Split('.')[0] + "." + _destinationFormat + @"""";

                Process.Start(info);

                return true;
            }
            else
            {
                return false;
            }
        }

        private void addProgressBarToTheWindow(FlowLayoutPanel progressBar)
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
            p.Value = 60;
            p.Visible = true;

            f.Controls.Add(p);


            Label l = new Label();

            l.Text = _name + " " + p.Value.ToString() + "%";
            l.Visible = true;
            l.Size = new Size(300, 24);
            
            f.Controls.Add(l);
            f.Show();

            progressBar.Controls.Add(f);
        }

    }
}
