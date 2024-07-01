using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Buton2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set background and foreground  
            dynamicButton.BackColor = Color.Red;
            dynamicButton.ForeColor = Color.Blue;

            // Assign an image to the button.  
            dynamicButton.Image = Image.FromFile(@"C:\Images\Dock.jpg");
            // Align the image and text on the button.  
            dynamicButton.ImageAlign = ContentAlignment.MiddleRight;
            dynamicButton.TextAlign = ContentAlignment.MiddleLeft;
            // Give the button a flat appearance.  
            dynamicButton.FlatStyle = FlatStyle.Flat;

            dynamicButton.Text = "I am Dynamic Button";
            dynamicButton.TextAlign = ContentAlignment.MiddleLeft;
            dynamicButton.Font = new Font("Georgia", 16);

            ControlPaint.DrawButton(System.Drawing.Graphics.FromHwnd(button1.Handle), 0, 0, button1.Width, button1.Height, ButtonState.Pushed);
        }
    }
}
