using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcession
{
    public partial class Form1 : Form
    {
        private const string RedText = "Red : ";
        private const string GreenText = "Green : ";
        private const string BlueText = "Blue : ";
        private const string ContrastText = "Contrast : ";

        public Form1()
        {
            InitializeComponent();
            _redTextBox.Text = RedText + _redTrackBar.Value;
            _greenTextBox.Text = GreenText + _greenTrackBar.Value;
            _blueTextBox.Text = BlueText + _blueTrackBar.Value;
            _contrastTextBox.Text = ContrastText + _contrastTrackBar.Value;
        }

        private void BrowseFileButtonClick(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = @"Images (*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _sourcePictureBox.Load(openFileDialog.FileName);
                    _sourcePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    _resultPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private Task ProcessAsync(int contrast, int r, int g, int b)
        {
            var needContrast = _checkContrast.Checked;
            var needGradient = _checkGradient.Checked;

            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker) (() =>
                {
                    contrast = _contrastTrackBar.Value;
                    r = _redTrackBar.Value;
                    g = _greenTrackBar.Value;
                    b = _blueTrackBar.Value;
                }));
            }
            else
            {
                contrast = _contrastTrackBar.Value;
                r = _redTrackBar.Value;
                g = _greenTrackBar.Value;
                b = _blueTrackBar.Value;
            }

            var sourceImg = _sourcePictureBox.Image;

            if (needContrast) sourceImg = ProcessingImage.ImageContrast((Bitmap) sourceImg, contrast);
            if (needGradient) sourceImg = ProcessingImage.ImageGradient(sourceImg, r, g, b);

            _resultPictureBox.Image = sourceImg;

            return Task.CompletedTask;
        }

        private async void StartButtonClick(object sender, EventArgs e)
        {
            var contrastBar = _contrastTrackBar.Value;
            var red = _redTrackBar.Value;
            var green = _greenTrackBar.Value;
            var blue = _blueTrackBar.Value;

            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker) (() =>
                {
                    contrastBar = _contrastTrackBar.Value;
                    red = _redTrackBar.Value;
                    green = _greenTrackBar.Value;
                    blue = _blueTrackBar.Value;
                }));
            }
            else
            {
                contrastBar = _contrastTrackBar.Value;
                red = _redTrackBar.Value;
                green = _greenTrackBar.Value;
                blue = _blueTrackBar.Value;
            }

            try
            {
                await Task.Run(() => ProcessAsync(contrastBar, red, green, blue));
            }
            catch
            {
                // ignored
            }
        }

        private void ContrastTrackBarScroll(object sender, EventArgs e)
        {
            _contrastTrackBar.Maximum = 100;
            _contrastTrackBar.Minimum = -100;
            _contrastTrackBar.TickFrequency = 20;
            _contrastTextBox.Text = ContrastText + _contrastTrackBar.Value;
        }

        private void RedTrackBarScroll(object sender, EventArgs e)
        {
            _redTrackBar.Maximum = 255;
            _redTrackBar.Minimum = 0;
            _redTrackBar.TickFrequency = 10;
            _redTextBox.Text = RedText + _redTrackBar.Value;
        }

        private void GreenTrackBarScroll(object sender, EventArgs e)
        {
            _greenTrackBar.Maximum = 255;
            _greenTrackBar.Minimum = 0;
            _greenTrackBar.TickFrequency = 10;
            _greenTextBox.Text = GreenText + _greenTrackBar.Value;
        }

        private void BlueTrackBarScroll(object sender, EventArgs e)
        {
            _blueTrackBar.Maximum = 255;
            _blueTrackBar.Minimum = 0;
            _blueTrackBar.TickFrequency = 10;
            _blueTextBox.Text = BlueText + _blueTrackBar.Value;
        }
    }
}