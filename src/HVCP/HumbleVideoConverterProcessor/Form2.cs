﻿using System;
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
            string path = srtFileName;
            int count = 0;
            string value = "";

            try
            {
                for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
                {
                    count++;
                    value = count + Environment.NewLine;

                    for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
                    {
                        if (col == 0)
                            value = value + dataGridView1.Rows[rows].Cells[col].Value.ToString();
                        if (col == 1)
                            value = value + " --> " + dataGridView1.Rows[rows].Cells[col].Value.ToString() + Environment.NewLine;
                        if (col == 2)
                        {
                            value = value + dataGridView1.Rows[rows].Cells[col].Value.ToString() + Environment.NewLine + Environment.NewLine;
                            if (count == 1)
                                System.IO.File.WriteAllText(path, value);
                            else
                                File.AppendAllText(path, value);
                        }
                    }
                }
            }
            catch (Exception er) 
            {
                MessageBox.Show("Error: srt file writing fail: " + er.ToString());
 
            }


            MessageBox.Show(srtFileName + " srt file writing completed");

            
        }

        private void fineToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            
            if(File.Exists(srtFileName))
            {
                MessageBox.Show(srtFileName + " already exists. Open and read the srt file");
                try
                {
                    srtFileReader = new System.IO.StreamReader(srtFileName);
                }
                catch
                {
                    MessageBox.Show("Error:"+ srtFileName + " cannot be open");
                }

                //read srt file
                String line = String.Empty;
                String strNum = String.Empty;
                String strStartTime = String.Empty;
                String strEndTime = String.Empty;
                String strText = String.Empty;

                int state = 0; //0: number, 1: time, 2: text, 3: blank space
                int number = 0;
                while ((line = srtFileReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    if (state == 0)
                    {
                        if (line.Equals(String.Empty)) continue; //skip the blank space
                        try
                        {
                            number = Convert.ToInt32(line);
                        }
                        catch
                        {
                            MessageBox.Show("Error: srt file is wrong format (Number): " + line);
                        }
                        state = 1;
                        continue;
                    }
                    if (state == 1)
                    {
                        string[] words = line.Split(' ');
                        if (words.Length != 3)
                        {
                            MessageBox.Show("Error: srt file is wrong format (Time): " + line);
                        }
                        strStartTime = words[0];
                        strEndTime = words[2];
                        state = 2;
                        continue;
                    }
                    if (state == 2)
                    {
                        if (line.Equals(String.Empty))
                        {
                            Console.WriteLine("write the subtitle numebr " + number + "\n");
                            strText = strText.Remove(strText.Length - 2); // delete the last "\r\n"
                            dataGridView1.Rows.Add(strStartTime, strEndTime, strText);
                            strStartTime = String.Empty;
                            strEndTime = String.Empty;
                            strText = String.Empty;
                            state = 0;
                            continue;
                        }
                        else if(line.Length > 0)
                        {
                            strText += line;
                            strText += "\r\n";
                            continue;
                        }
                    }

                    //string[] words = line.Split(' ');
                    //foreach(string word in words) {
                    //    Console.WriteLine(word);
                    //}
                    

                }
                //write the last subtitle to the datagrid
                if (state == 2)
                {
                    Console.WriteLine("write the subtitle numebr " + number + "\n");
                    strText = strText.Remove(strText.Length - 2); // delete the last "\r\n"
                    dataGridView1.Rows.Add(strStartTime, strEndTime, strText);
                }
                //sort the datagrid
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);

                srtFileReader.Close();

                // Suspend the screen.
                //Console.ReadLine();

            } else {
                MessageBox.Show(srtFileName + " does not exists. The srt file will be created");
                try
                {
                    //File.Create(srtFileName); //the file will be crated when writing
                }
                catch
                {
                    //MessageBox.Show("Error:" + srtFileName + " cannot be created");
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
            if (txb_sh.Text.Length == 1)
                txb_sh.Text = "0" + txb_sh.Text;
            if (txb_sm.Text.Length == 1)
                txb_sm.Text = "0" + txb_sm.Text;
            if (txb_ss.Text.Length == 1)
                txb_ss.Text = "0" + txb_ss.Text;
            if (txb_sms.Text.Length < 3)
                txb_sms.Text = "0" + txb_sms.Text;
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
            if (txb_eh.Text.Length == 1)
                txb_eh.Text = "0" + txb_eh.Text;
            if (txb_em.Text.Length == 1)
                txb_em.Text = "0" + txb_em.Text;
            if (txb_es.Text.Length == 1)
                txb_es.Text = "0" + txb_es.Text;
            if (txb_ems.Text.Length == 1)
                txb_ems.Text = "0" + txb_ems.Text;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string start_time = txb_sh.Text +":" + txb_sm.Text + ":" + txb_ss.Text + "," + txb_sms.Text;
            string end_time = txb_eh.Text +":" + txb_em.Text + ":" + txb_es.Text + "," + txb_ems.Text;
            dataGridView1.Rows.Add(start_time,end_time,txb_text.Text);
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void txb_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




