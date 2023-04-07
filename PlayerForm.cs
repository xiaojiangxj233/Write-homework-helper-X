using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace Write_homework_helper_X
{
    public partial class PlayerForm : Form
    {
        public PlayerForm()
        {
            InitializeComponent();
        }

        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;


        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 Files (*.mp3)|*.mp3";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                audioFile = new AudioFileReader(openFileDialog.FileName);
                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Play();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.Play();
            }
            button1.Hide();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.Pause();
            }
            button1.Show();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                audioFile.Position = 0;
            }
        }
    }
}
