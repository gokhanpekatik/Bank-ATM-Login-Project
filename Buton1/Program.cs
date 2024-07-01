using System;
using System.Drawing;
using System.Windows.Forms;

namespace ElipsButonOrnegi
{
    public class ElipsButon : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Elips çizmek için Graphics nesnesi kullanılır
            Graphics g = e.Graphics;

            // Butonun boyutları
            int genislik = this.Width;
            int yukseklik = this.Height;

            // Elipsin köşelerini belirlemek için dikdörtgen
            Rectangle cerceve = new Rectangle(0, 0, genislik, yukseklik);

            // Elipsin rengi
            Color renk = this.BackColor;

            // Elips çizme
            g.FillEllipse(new SolidBrush(renk), cerceve);

            // Buton metnini çizme
            if (!string.IsNullOrEmpty(this.Text))
            {
                // Metnin konumunu ve rengini ayarlama
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    g.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), cerceve, sf);
                }
            }
        }
    }
}
