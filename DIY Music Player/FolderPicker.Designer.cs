namespace DIY_Music_Player
{
    partial class FolderPicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderInput = new System.Windows.Forms.TextBox();
            this.PlaylistLoad = new System.Windows.Forms.Button();
            this.SubFolderBox = new System.Windows.Forms.CheckBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.HelpRequest += new System.EventHandler(this.FolderBrowser_HelpRequest);
            // 
            // FolderInput
            // 
            this.FolderInput.Location = new System.Drawing.Point(91, 88);
            this.FolderInput.Name = "FolderInput";
            this.FolderInput.Size = new System.Drawing.Size(100, 20);
            this.FolderInput.TabIndex = 0;
            this.FolderInput.Enter += new System.EventHandler(this.FolderInput_Enter);
            // 
            // PlaylistLoad
            // 
            this.PlaylistLoad.Location = new System.Drawing.Point(91, 191);
            this.PlaylistLoad.Name = "PlaylistLoad";
            this.PlaylistLoad.Size = new System.Drawing.Size(100, 23);
            this.PlaylistLoad.TabIndex = 1;
            this.PlaylistLoad.Text = "Load Playlist!";
            this.PlaylistLoad.UseVisualStyleBackColor = true;
            this.PlaylistLoad.Click += new System.EventHandler(this.PlaylistLoad_Click);
            // 
            // SubFolderBox
            // 
            this.SubFolderBox.AutoSize = true;
            this.SubFolderBox.Location = new System.Drawing.Point(91, 151);
            this.SubFolderBox.Name = "SubFolderBox";
            this.SubFolderBox.Size = new System.Drawing.Size(111, 17);
            this.SubFolderBox.TabIndex = 2;
            this.SubFolderBox.Text = "Read Subfolders?";
            this.SubFolderBox.UseVisualStyleBackColor = true;
            this.SubFolderBox.CheckedChanged += new System.EventHandler(this.SubFolderBox_CheckedChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(91, 115);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(100, 23);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // FolderPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.SubFolderBox);
            this.Controls.Add(this.PlaylistLoad);
            this.Controls.Add(this.FolderInput);
            this.Name = "FolderPicker";
            this.Text = "FolderPicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.TextBox FolderInput;
        private System.Windows.Forms.Button PlaylistLoad;
        private System.Windows.Forms.CheckBox SubFolderBox;
        private System.Windows.Forms.Button BrowseButton;
    }
}