namespace DIY_Music_Player
{
    partial class MediaPlayerWindow
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
            this.PauseButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.RandomBox = new System.Windows.Forms.CheckBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.RepeatBox = new System.Windows.Forms.CheckBox();
            this.CurrentlyPlaying = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(384, 270);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(75, 23);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.Text = "Pause!";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(274, 270);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "Play!";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // RandomBox
            // 
            this.RandomBox.AutoSize = true;
            this.RandomBox.Location = new System.Drawing.Point(274, 223);
            this.RandomBox.Name = "RandomBox";
            this.RandomBox.Size = new System.Drawing.Size(72, 17);
            this.RandomBox.TabIndex = 3;
            this.RandomBox.Text = "Random?";
            this.RandomBox.UseVisualStyleBackColor = true;
            this.RandomBox.CheckedChanged += new System.EventHandler(this.RandomBox_CheckedChanged);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(274, 322);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next!";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(384, 322);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 5;
            this.PreviousButton.Text = "Previous!";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // RepeatBox
            // 
            this.RepeatBox.AutoSize = true;
            this.RepeatBox.Location = new System.Drawing.Point(392, 223);
            this.RepeatBox.Name = "RepeatBox";
            this.RepeatBox.Size = new System.Drawing.Size(67, 17);
            this.RepeatBox.TabIndex = 6;
            this.RepeatBox.Text = "Repeat?";
            this.RepeatBox.UseVisualStyleBackColor = true;
            this.RepeatBox.CheckedChanged += new System.EventHandler(this.RepeatBox_CheckedChanged);
            // 
            // CurrentlyPlaying
            // 
            this.CurrentlyPlaying.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentlyPlaying.AutoSize = true;
            this.CurrentlyPlaying.Location = new System.Drawing.Point(306, 362);
            this.CurrentlyPlaying.Name = "CurrentlyPlaying";
            this.CurrentlyPlaying.Size = new System.Drawing.Size(128, 13);
            this.CurrentlyPlaying.TabIndex = 7;
            this.CurrentlyPlaying.Text = "Currently Playing: Nothing";
            this.CurrentlyPlaying.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CurrentlyPlaying.Click += new System.EventHandler(this.CurrentlyPlaying_Click);
            // 
            // MediaPlayerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CurrentlyPlaying);
            this.Controls.Add(this.RepeatBox);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.RandomBox);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.PauseButton);
            this.Name = "MediaPlayerWindow";
            this.Text = "X Media Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.CheckBox RandomBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.CheckBox RepeatBox;
        public System.Windows.Forms.Label CurrentlyPlaying;
    }
}