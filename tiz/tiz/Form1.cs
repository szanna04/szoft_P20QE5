using tiz.Models;

namespace tiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen pen = new Pen(Color.Yellow);
            Brush brush = new SolidBrush(Color.White);

            g.FillEllipse(brush, 0, 0, 100, 100);

            HajosContext context = new HajosContext(); //p�ld�nyos�tottam
            var stars = from x in context.StarData
                         select new {x.Hip, x.Magnitude, x.X, x.Y}; //anonim t�pus

            double nagy�t�s = Math.Min(ClientRectangle.Width, ClientRectangle.Height) / 2;
            int ox = ClientRectangle.Width/2, oy = ClientRectangle.Height/2;

            g.Clear(Color.Blue);

            foreach ( var start in stars)
            {
                if (Math.Sqrt(Math.Pow(start.X, 2) + Math.Pow(start.Y, 2)) > 1) continue;
                if (start.Magnitude > 6) continue;
                double size = 20 + Math.Pow(10, start.Magnitude / -2.5);
                double x = start.X * nagy�t�s + ox;
                double y = start.Y * nagy�t�s + oy;

                if (size<1) size= 1;

                g.FillEllipse(brush, (float)(x-size/2), (float)(y-size/2), (float)size, (float)size);
            }
            var lines = context.ConstellationLines.ToList();
            foreach ( var line in lines )
            {
                var star1 = (from x in stars
                            where x.Hip == line.Star1
                            select x).FirstOrDefault();

                var star2 = (from x in stars
                             where x.Hip == line.Star2
                             select x).FirstOrDefault();

                if (star1 == null || star2 == null) continue;

                double x1 = star1.X * nagy�t�s + ox;
                double y1 = star1.Y * nagy�t�s + oy;
                double x2 = star2.X * nagy�t�s + ox;
                double y2 = star2.X * nagy�t�s + oy;

                g.DrawLine(pen, (float)x1, (float)y1, (float)x2,  (float)y2);
            }
        }
    }
}