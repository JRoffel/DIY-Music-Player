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
    public partial class FolderPicker : Form
    {
        public FolderPicker()
        {
            InitializeComponent();
        }

        private void FolderBrowser_HelpRequest(object sender, EventArgs e)
        {
        }

        private void FolderInput_Enter(object sender, EventArgs e)
        {
        }

        private void SubFolderBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void PlaylistLoad_Click(object sender, EventArgs e)
        {
            PlayerUtilities.InitPlayer(FolderInput.Text, SubFolderBox.Checked);
            this.Close();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowser.ShowDialog();
            FolderInput.Text = FolderBrowser.SelectedPath;
        }
    }
}
