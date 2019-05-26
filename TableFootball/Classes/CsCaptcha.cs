using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace captchaCode
{
    class CsCaptcha
    {
        private static string code;
        private static Random rand = new Random();
        public static Image CreateImage()
        {
            code = GetRandomText();
            Bitmap bitmap = new Bitmap(200, 50, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Yellow);
            Rectangle rect = new Rectangle(0, 0, 200, 50);
            SolidBrush b = new SolidBrush(Color.White);
            SolidBrush White = new SolidBrush(Color.Black);
            int counter = 0;
            g.DrawRectangle(pen, rect);
            g.FillRectangle(b, rect);
            for (int i = 0; i < code.Length; i++)
            {
                g.DrawString(code[i].ToString(), new Font("Georgia", 10 + rand.Next(14, 18)), White, new PointF(10 + counter, 10));
                counter += 20;
            }
            DrawRandomLines(g);
            g.Dispose();
            return bitmap;
        }
        public static bool validate(string input)
        {
            if (code.Equals(input))
            {
                return true;
            }
            return false;
        }

        private static string GetRandomText()
        {
            StringBuilder randomText = new StringBuilder();
                string alphabets = "abc1234567890";
                Random r = new Random();
                for (int j = 0; j <= 5; j++)
                {
                    randomText.Append(alphabets[r.Next(alphabets.Length)]);
                }
                code = randomText.ToString();
            return code;
        }

        private static Point[] GetRandomPoints()
        {
            Point[] points = { new Point(rand.Next(10, 150), rand.Next(10, 150)), new Point(rand.Next(10, 100), rand.Next(10, 100)) };
            return points;
        }

        private static void DrawRandomLines(Graphics g)
        {
            SolidBrush green = new SolidBrush(Color.Green);
            //For Creating Lines on The Captcha 
            for (int i = 0; i < 20; i++)
            {
                g.DrawLines(new Pen(green, 2), GetRandomPoints());
            }

        }
    }
}
