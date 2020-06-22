namespace ImageProcession
{
    partial class Form1
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
            this._sourcePictureBox = new System.Windows.Forms.PictureBox();
            this._browseFileButton = new System.Windows.Forms.Button();
            this._startButton = new System.Windows.Forms.Button();
            this._resultPictureBox = new System.Windows.Forms.PictureBox();
            this._contrastTrackBar = new System.Windows.Forms.TrackBar();
            this._contrastLabel = new System.Windows.Forms.Label();
            this._checkGradient = new System.Windows.Forms.CheckBox();
            this._redTrackBar = new System.Windows.Forms.TrackBar();
            this._greenTrackBar = new System.Windows.Forms.TrackBar();
            this._blueTrackBar = new System.Windows.Forms.TrackBar();
            this._checkContrast = new System.Windows.Forms.CheckBox();
            this._gradientSettings = new System.Windows.Forms.Label();
            this._redTextBox = new System.Windows.Forms.TextBox();
            this._greenTextBox = new System.Windows.Forms.TextBox();
            this._blueTextBox = new System.Windows.Forms.TextBox();
            this._contrastTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._sourcePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._resultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._contrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._blueTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // _sourcePictureBox
            // 
            this._sourcePictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this._sourcePictureBox.Location = new System.Drawing.Point(13, 13);
            this._sourcePictureBox.Name = "_sourcePictureBox";
            this._sourcePictureBox.Size = new System.Drawing.Size(388, 529);
            this._sourcePictureBox.TabIndex = 0;
            this._sourcePictureBox.TabStop = false;
            // 
            // _browseFileButton
            // 
            this._browseFileButton.Location = new System.Drawing.Point(12, 548);
            this._browseFileButton.Name = "_browseFileButton";
            this._browseFileButton.Size = new System.Drawing.Size(75, 23);
            this._browseFileButton.TabIndex = 2;
            this._browseFileButton.Text = "Browse...";
            this._browseFileButton.UseVisualStyleBackColor = true;
            this._browseFileButton.Click += new System.EventHandler(this.BrowseFileButtonClick);
            // 
            // _startButton
            // 
            this._startButton.Location = new System.Drawing.Point(767, 548);
            this._startButton.Name = "_startButton";
            this._startButton.Size = new System.Drawing.Size(75, 23);
            this._startButton.TabIndex = 3;
            this._startButton.Text = "Start";
            this._startButton.UseVisualStyleBackColor = true;
            this._startButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // _resultPictureBox
            // 
            this._resultPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this._resultPictureBox.Location = new System.Drawing.Point(771, 13);
            this._resultPictureBox.Name = "_resultPictureBox";
            this._resultPictureBox.Size = new System.Drawing.Size(388, 529);
            this._resultPictureBox.TabIndex = 4;
            this._resultPictureBox.TabStop = false;
            // 
            // _contrastTrackBar
            // 
            this._contrastTrackBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this._contrastTrackBar.Location = new System.Drawing.Point(407, 135);
            this._contrastTrackBar.Name = "_contrastTrackBar";
            this._contrastTrackBar.Size = new System.Drawing.Size(358, 45);
            this._contrastTrackBar.TabIndex = 5;
            this._contrastTrackBar.Scroll += new System.EventHandler(this.ContrastTrackBarScroll);
            // 
            // _contrastLabel
            // 
            this._contrastLabel.AutoSize = true;
            this._contrastLabel.Location = new System.Drawing.Point(407, 93);
            this._contrastLabel.Name = "_contrastLabel";
            this._contrastLabel.Size = new System.Drawing.Size(85, 13);
            this._contrastLabel.TabIndex = 7;
            this._contrastLabel.Text = "Contrast settings";
            // 
            // _checkGradient
            // 
            this._checkGradient.Location = new System.Drawing.Point(407, 39);
            this._checkGradient.Name = "_checkGradient";
            this._checkGradient.Size = new System.Drawing.Size(358, 20);
            this._checkGradient.TabIndex = 9;
            this._checkGradient.Text = "Use gradient";
            this._checkGradient.UseVisualStyleBackColor = true;
            // 
            // _redTrackBar
            // 
            this._redTrackBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this._redTrackBar.Location = new System.Drawing.Point(407, 264);
            this._redTrackBar.Name = "_redTrackBar";
            this._redTrackBar.Size = new System.Drawing.Size(358, 45);
            this._redTrackBar.TabIndex = 10;
            this._redTrackBar.Scroll += new System.EventHandler(this.RedTrackBarScroll);
            // 
            // _greenTrackBar
            // 
            this._greenTrackBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this._greenTrackBar.Location = new System.Drawing.Point(407, 341);
            this._greenTrackBar.Name = "_greenTrackBar";
            this._greenTrackBar.Size = new System.Drawing.Size(358, 45);
            this._greenTrackBar.TabIndex = 11;
            this._greenTrackBar.Scroll += new System.EventHandler(this.GreenTrackBarScroll);
            // 
            // _blueTrackBar
            // 
            this._blueTrackBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this._blueTrackBar.Location = new System.Drawing.Point(407, 418);
            this._blueTrackBar.Name = "_blueTrackBar";
            this._blueTrackBar.Size = new System.Drawing.Size(358, 45);
            this._blueTrackBar.TabIndex = 12;
            this._blueTrackBar.Scroll += new System.EventHandler(this.BlueTrackBarScroll);
            // 
            // _checkContrast
            // 
            this._checkContrast.Location = new System.Drawing.Point(407, 13);
            this._checkContrast.Name = "_checkContrast";
            this._checkContrast.Size = new System.Drawing.Size(358, 20);
            this._checkContrast.TabIndex = 13;
            this._checkContrast.Text = "Use contrast";
            this._checkContrast.UseVisualStyleBackColor = true;
            // 
            // _gradientSettings
            // 
            this._gradientSettings.AutoSize = true;
            this._gradientSettings.Location = new System.Drawing.Point(407, 221);
            this._gradientSettings.Name = "_gradientSettings";
            this._gradientSettings.Size = new System.Drawing.Size(86, 13);
            this._gradientSettings.TabIndex = 14;
            this._gradientSettings.Text = "Gradient settings";
            // 
            // _redTextBox
            // 
            this._redTextBox.Location = new System.Drawing.Point(408, 238);
            this._redTextBox.Name = "_redTextBox";
            this._redTextBox.Size = new System.Drawing.Size(100, 20);
            this._redTextBox.TabIndex = 15;
            this._redTextBox.Text = "Red : 0";
            // 
            // _greenTextBox
            // 
            this._greenTextBox.Location = new System.Drawing.Point(407, 315);
            this._greenTextBox.Name = "_greenTextBox";
            this._greenTextBox.Size = new System.Drawing.Size(100, 20);
            this._greenTextBox.TabIndex = 16;
            this._greenTextBox.Text = "Green : 0";
            // 
            // _blueTextBox
            // 
            this._blueTextBox.Location = new System.Drawing.Point(410, 392);
            this._blueTextBox.Name = "_blueTextBox";
            this._blueTextBox.Size = new System.Drawing.Size(100, 20);
            this._blueTextBox.TabIndex = 17;
            this._blueTextBox.Text = "Blue : 0";
            // 
            // _contrastTextBox
            // 
            this._contrastTextBox.Location = new System.Drawing.Point(407, 109);
            this._contrastTextBox.Name = "_contrastTextBox";
            this._contrastTextBox.Size = new System.Drawing.Size(100, 20);
            this._contrastTextBox.TabIndex = 18;
            this._contrastTextBox.Text = "Contrast : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 612);
            this.Controls.Add(this._contrastTextBox);
            this.Controls.Add(this._blueTextBox);
            this.Controls.Add(this._greenTextBox);
            this.Controls.Add(this._redTextBox);
            this.Controls.Add(this._gradientSettings);
            this.Controls.Add(this._checkContrast);
            this.Controls.Add(this._blueTrackBar);
            this.Controls.Add(this._greenTrackBar);
            this.Controls.Add(this._redTrackBar);
            this.Controls.Add(this._checkGradient);
            this.Controls.Add(this._contrastLabel);
            this.Controls.Add(this._contrastTrackBar);
            this.Controls.Add(this._resultPictureBox);
            this.Controls.Add(this._startButton);
            this.Controls.Add(this._browseFileButton);
            this.Controls.Add(this._sourcePictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._sourcePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._resultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._contrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._blueTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _sourcePictureBox;
        private System.Windows.Forms.Button _browseFileButton;
        private System.Windows.Forms.Button _startButton;
        private System.Windows.Forms.PictureBox _resultPictureBox;
        private System.Windows.Forms.TrackBar _contrastTrackBar;
        private System.Windows.Forms.Label _contrastLabel;
        private System.Windows.Forms.CheckBox _checkGradient;
        private System.Windows.Forms.TrackBar _redTrackBar;
        private System.Windows.Forms.TrackBar _greenTrackBar;
        private System.Windows.Forms.TrackBar _blueTrackBar;
        private System.Windows.Forms.CheckBox _checkContrast;
        private System.Windows.Forms.Label _gradientSettings;
        private System.Windows.Forms.TextBox _redTextBox;
        private System.Windows.Forms.TextBox _greenTextBox;
        private System.Windows.Forms.TextBox _blueTextBox;
        private System.Windows.Forms.TextBox _contrastTextBox;
    }
}

