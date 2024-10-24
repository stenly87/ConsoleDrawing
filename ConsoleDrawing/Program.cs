using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ConsoleDrawing
{
    internal class Program
    {
        static int shift = 0;

        static void Main(string[] args)
        {
            Console.BufferHeight = 100;
            Graphics draw = Graphics.FromHwnd(Process.GetCurrentProcess().MainWindowHandle);
            Pen pen = new Pen(Color.White, 5);
            draw.Clear(Color.Black);

            draw.DrawEllipse(pen, 100, 100, 300, 300);

            draw.DrawEllipse(pen, 450, 100, 300, 300);

            draw.FillEllipse(Brushes.Black, 150, 250, 500, 500);
            draw.DrawEllipse(pen, 150, 250, 500, 500);

            for (int i = 100; i < 190; i += 10)
                draw.DrawBezier(pen, new Point { X = 200 + i, Y = 680 },
                    new Point { X = 220 + i, Y = 700 },
                    new Point { X = 200 + i, Y = 720 },
                    new Point { X = 220 + i, Y = 740 });
            for (int i = 190; i < 280; i += 10)
                draw.DrawBezier(pen, new Point { X = 220 + i, Y = 680 },
                    new Point { X = 200 + i, Y = 700 },
                    new Point { X = 220 + i, Y = 720 },
                    new Point { X = 200 + i, Y = 740 });

            draw.DrawEllipse(pen, 150, 150, 125, 125);
            draw.DrawEllipse(pen, 550, 150, 125, 125);

            draw.FillEllipse(Brushes.Gray, 200, 400, 125, 55);
            draw.FillEllipse(Brushes.Gray, 400, 400, 125, 55);
            draw.DrawEllipse(pen, 200, 400, 125, 55);
            draw.DrawEllipse(pen, 400, 400, 125, 55);

            draw.FillEllipse(Brushes.DarkGreen, 250, 410, 20, 40);
            draw.FillEllipse(Brushes.DarkGreen, 450, 410, 20, 40);

            draw.DrawPie(pen, 300, 450, 100, 100, -75, 75);
            pen.Color = Color.Red;
            draw.DrawArc(pen, 350, 400, 70, 250, 50, 100);

            Console.ReadLine();
        }

    }
}
