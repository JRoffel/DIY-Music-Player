using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIY_Music_Player
{
    public partial class MediaPlayerWindow : Form
    {
        public string folder = "D:/Music/Playlist";
        public MediaPlayerWindow()
        {
            InitializeComponent();
            //var videoPlayer = new VideoPlayer();
            //videoPlayer.ShowDialog(this);
            var folderPicker = new FolderPicker();
            folderPicker.ShowDialog(this);
            PlayerUtilities.CreateWindowReference(this);
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            PlayerUtilities.PauseCurrentSong();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        { 
            PlayerUtilities.PlayCurrentSong();
            UpdatePlayLabel();
        }

        private void RandomBox_CheckedChanged(object sender, EventArgs e)
        {
            PlayerUtilities.SetRandom(RandomBox.Checked);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            PlayerUtilities.GetNextSong();
            UpdatePlayLabel();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            PlayerUtilities.GetPreviousSong();
            UpdatePlayLabel();
        }

        private void RepeatBox_CheckedChanged(object sender, EventArgs e)
        {
            PlayerUtilities.SetRepeat(RepeatBox.Checked);
        }

        private void CurrentlyPlaying_Click(object sender, EventArgs e)
        {
        }

        public void UpdatePlayLabel()
        {
            string labelText = PlayerUtilities.GenerateLabelText();
            CurrentlyPlaying.Text = labelText;
        }

        private void AlwaysTop_CheckedChanged(object sender, EventArgs e)
        {
           this.TopMost = AlwaysTop.Checked;
        }
    }
}