using System;
using System.Drawing;
using System.Windows.Forms;

public class EllipticalButton : Button
{
    protected override void OnPaint(PaintEventArgs pevent)
    {
        Graphics graphics = pevent.Graphics;
        Pen pen = new Pen(this.ForeColor);
        Brush brush = new SolidBrush(this.BackColor);

        // Elips çizimi
        graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        graphics.FillEllipse(brush, 0, 0, this.Width, this.Height);
        graphics.DrawEllipse(pen, 0, 0, this.Width - 1, this.Height - 1);

        // Metni ortala
        StringFormat sf = new StringFormat();
        sf.Alignment = StringAlignment.Center;
        sf.LineAlignment = StringAlignment.Center;
        graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.ClientRectangle, sf);
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        this.Region = new Region(new Rectangle(0, 0, this.Width, this.Height));
    }
}
