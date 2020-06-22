using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ImageProcession
{
    public class ProcessingImage
    {
        public static Bitmap ImageContrast(Bitmap sourceBitmap, int threshold)
        {
            var sourceData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            var pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            var contrastLevel = Math.Pow((100.0 + threshold) / 100.0, 2);

            for (var k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                var blue = ((pixelBuffer[k] / 255.0 - 0.5) *
                    contrastLevel + 0.5) * 255.0;

                var green = ((pixelBuffer[k + 1] / 255.0 - 0.5) *
                    contrastLevel + 0.5) * 255.0;

                var red = ((pixelBuffer[k + 2] / 255.0 - 0.5) *
                    contrastLevel + 0.5) * 255.0;

                if (blue > 255) blue = 255;

                else if (blue < 0) blue = 0;

                if (green > 255) green = 255;

                else if (green < 0) green = 0;

                if (red > 255) red = 255;

                else if (red < 0) red = 0;

                pixelBuffer[k] = (byte) blue;
                pixelBuffer[k + 1] = (byte) green;
                pixelBuffer[k + 2] = (byte) red;
            }

            var resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            var resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                    resultBitmap.Width, resultBitmap.Height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);
            return resultBitmap;
        }

        public static Bitmap ImageGradient(Image bitmap, int red, int green, int blue)
        {
            var bmpGradient = new Bitmap(bitmap);
            var graphics = Graphics.FromImage(bmpGradient);
            var brush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(0, bitmap.Height),
                Color.FromArgb(100, red, green, blue),
                Color.FromArgb(100, red, green, blue));
            graphics.FillRectangle(brush, 0, 0, bitmap.Width, bitmap.Height);
            return bmpGradient;
        }
    }
}