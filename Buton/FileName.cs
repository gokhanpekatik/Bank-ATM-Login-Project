using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buton
{
    internal class FileName
    {
        public Form1()
        {
            InitializeComponent();

            EllipticalButton ellipticalButton = new EllipticalButton();
            ellipticalButton.Size = new Size(100, 50);
            ellipticalButton.Location = new Point(50, 50);
            ellipticalButton.Text = "Elips Buton";
            this.Controls.Add(ellipticalButton);
        }


    }
}
