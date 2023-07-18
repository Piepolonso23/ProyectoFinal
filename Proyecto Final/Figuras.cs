using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public abstract class Figura
    {
        protected int X, Y, width, height;
        protected Color color;
        public abstract void dibujar(Graphics g);
    }
    public class BorradorLapiz : Figura
    {
        public BorradorLapiz(int x, int y, int ancho, int alto)
        {
            X = x;
            Y = y;
            color = Color.DarkRed;
            width = ancho;
            height = alto;
        }

        public override void dibujar(Graphics g)
        {
            Brush b = new SolidBrush(color);
            g.FillEllipse(b, X, Y, width, height);
        }
    }

    public class Metal : Figura
    {
        public Metal(int x, int y, int ancho, int alto)
        {
            X = x;
            Y = y;
            color = Color.Black;
            width = ancho;
            height = alto;
        }

        public override void dibujar(Graphics g)
        {
            Brush b = new SolidBrush(Color.FromArgb(166, 179, 180));
            Pen p = new Pen(color, 2);
            g.FillRectangle(b, X, Y, width, height);
            g.DrawLine(p, X + width / 10, Y + height / 2, X + width / 10 + width / 3, Y + height / 2);
        }
    }

    public class Cabeza : Figura
    {
        List<Figura> figuras;
        public Cabeza(int x, int y, int ancho, int alto)
        {
            X = x;
            Y = y;
            width = ancho;
            height = alto;
            figuras = new List<Figura>();
            BorradorLapiz b = new BorradorLapiz(X, Y, width, height);
            figuras.Add(b);
            Metal m = new Metal(X, Y + height / 2, width, height / 2);
            figuras.Add(m);
        }

        public override void dibujar(Graphics g)
        {
            foreach (Figura f in figuras)
            {
                f.dibujar(g);
            }
        }
    }

    public class Cuerpo : Figura
    {
        public Cuerpo(int x, int y, int ancho, int alto)
        {
            X = x;
            Y = y;
            color = Color.Black;
            width = ancho;
            height = alto;
        }

        public override void dibujar(Graphics g)
        {
            Brush b = new SolidBrush(Color.FromArgb(242, 206, 0));
            g.FillRectangle(b, X, Y, width, height);
        }
    }

    public class Ojos : Figura
    {
        public Ojos(int x, int y, int ancho, int alto)
        {
            X = x;
            Y = y;
            width = ancho;
            height = alto;
        }

        public override void dibujar(Graphics g)
        {
            Brush b = new SolidBrush(Color.White);
            g.FillEllipse(b, X, Y, width / 2, height);
            g.FillEllipse(b, X + width / 2, Y, width / 2, height);
            b = new SolidBrush(Color.Black);
            g.FillEllipse(b, X + width / 8, Y + height / 4, 2 * width / 8, height / 2);
            g.FillEllipse(b, X + 5 * width / 8, Y + height / 4, 2 * width / 8, height / 2);
        }
    }

    public class BocaFeliz : Figura
    {
        public BocaFeliz(int x, int y, int ancho, int alto)
        {
            X = x;
            Y = y;
            width = ancho;
            height = alto;
        }

        public override void dibujar(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawArc(p, X, Y, width, height, 0, 180);
        }
    }

    public class Punta : Figura
    {
        public Punta(int x, int y, int ancho, int alto)
        {
            X = x;
            Y = y;
            color = Color.Black;
            width = ancho;
            height = alto;
        }

        public override void dibujar(Graphics g)
        {
            Point p1 = new Point(X, Y);
            Point p2 = new Point(X + width, Y);
            Point p3 = new Point(X + (width / 2), Y + height);
            Brush b = new SolidBrush(Color.FromArgb(242, 207, 157));
            g.FillPolygon(b, new PointF[] { p1, p2, p3 });
            Point p4 = new Point((X + X + (width / 2)) / 2, (Y + Y + height) / 2);
            Point p5 = new Point((X + width + X + (width / 2)) / 2, (Y + Y + height) / 2);
            Point p6 = new Point(X + (width / 2), Y + height);
            b = new SolidBrush(Color.Black);
            g.FillPolygon(b, new PointF[] { p4, p5, p6 });
        }
    }

    public class Lapiz : Figura
    {
        List<Figura> figuras;
        public Lapiz(int x, int y, int ancho, int alto)
        {
            X = x;
            Y = y;
            width = ancho;
            height = alto;
            figuras = new List<Figura>();
            Cabeza ca = new Cabeza(X, Y, width, height / 4);
            figuras.Add(ca);
            Cuerpo cu = new Cuerpo(X, Y + height / 4, width, 2 * height / 4);
            figuras.Add(cu);
            Ojos o = new Ojos(X, Y + height / 3, width, height / 5);
            figuras.Add(o);
            BocaFeliz b = new BocaFeliz(X, Y + height / 3 + height / 4, width, height / 8);
            figuras.Add(b);
            Punta p = new Punta(X, Y + 3 * height / 4, width, height / 4);
            figuras.Add(p);
        }

        public override void dibujar(Graphics g)
        {
            foreach (Figura f in figuras)
            {
                f.dibujar(g);
            }
        }
    }

    public class Goma : Figura
    {
        public Goma(int x, int y, int ancho, int alto)
        {
            X = x;
            Y = y;
            width = ancho;
            height = alto;
        }

        public override void dibujar(Graphics g)
        {
            Brush b = new SolidBrush(Color.FromArgb(242, 240, 227));
            g.FillRectangle(b, X, Y, width, height);
        }
    }

    public class Carton : Figura
    {
        public Carton(int x, int y, int ancho, int alto)
        {
            X = x;
            Y = y;
            width = ancho;
            height = alto;
        }

        public override void dibujar(Graphics g)
        {
            Brush b = new SolidBrush(Color.Orange);
            g.FillRectangle(b, X, Y, width, height);
        }
    }

    public class BocaTriste : Figura
    {
        public BocaTriste(int x, int y, int ancho, int alto)
        {
            X = x;
            Y = y;
            width = ancho;
            height = alto;
        }

        public override void dibujar(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawArc(p, X, Y, width, height, 0, -180);
        }
    }

    public class Borrador : Figura
    {
        List<Figura> figuras;
        public Borrador(int x, int y, int ancho, int alto)
        {
            X = x;
            Y = y;
            width = ancho;
            height = alto;
            figuras = new List<Figura>();
            Goma g = new Goma(X + width / 14, Y, 12 * width / 14, height / 4);
            figuras.Add(g);
            Carton c = new Carton(X, Y + height / 4, width, 3 * height / 4);
            figuras.Add(c);
            Ojos o = new Ojos(X + width / 5, Y + height / 4, 3 * width / 5, height / 4);
            figuras.Add(o);
            BocaTriste bt = new BocaTriste(X, Y + 3 * height / 4, width, height / 4);
            figuras.Add(bt);
        }

        public override void dibujar(Graphics g)
        {
            foreach (Figura f in figuras)
            {
                f.dibujar(g);
            }
        }
    }

    public class MensajePositivo : Figura
    {
        public MensajePositivo(int x, int y, int ancho, int alto)
        {
            X = x;
            Y = y;
            width = ancho;
            height = alto;
        }

        public override void dibujar(Graphics g)
        {
            Brush b = new SolidBrush(Color.FromArgb(200, 221, 239));
            g.FillEllipse(b, X + width / 8, Y + 3 * height / 4 + height / 6, width / 8, height / 8);
            g.FillEllipse(b, X + width / 5, Y + 3 * height / 4, width / 8, height / 8);
            g.FillEllipse(b, X + width / 3, Y, 2 * width / 3, 3 * height / 4);
            Font sf = new Font("Arial", width / 20);
            SolidBrush sb = new SolidBrush(Color.Black);
            g.DrawString("¡Felicidades!", sf, sb, X + width / 3 + width / 6, Y + height / 3);
        }
    }

    public class MensajeNegativo : Figura
    {
        public MensajeNegativo(int x, int y, int ancho, int alto)
        {
            X = x;
            Y = y;
            width = ancho;
            height = alto;
        }

        public override void dibujar(Graphics g)
        {
            Brush b = new SolidBrush(Color.FromArgb(200, 221, 239));
            g.FillEllipse(b, X + width / 8, Y + 3 * height / 4 + height / 6, width / 8, height / 8);
            g.FillEllipse(b, X + width / 5, Y + 3 * height / 4, width / 8, height / 8);
            g.FillEllipse(b, X + width / 3, Y, 2 * width / 3, 3 * height / 4);
            Font sf = new Font("Arial", width / 20);
            SolidBrush sb = new SolidBrush(Color.Black);
            g.DrawString("Desaprobado", sf, sb, X + width / 3 + width / 6, Y + height / 3);
        }
    }

    public class FiguraAprobado : Figura
    {
        List<Figura> figuras;
        public FiguraAprobado(int x, int y, int ancho, int alto)
        {
            X = x;
            Y = y;
            width = ancho;
            height = alto;
            figuras = new List<Figura>();
            Lapiz l = new Lapiz(X, Y + height / 2, width / 3, height / 2);
            figuras.Add(l);
            MensajePositivo mp = new MensajePositivo(X + width / 3, Y, 2 * width / 3, height / 2);
            figuras.Add(mp);
        }

        public override void dibujar(Graphics g)
        {
            foreach (Figura f in figuras)
            {
                f.dibujar(g);
            }
        }
    }

    public class FiguraDesaprobado : Figura
    {
        List<Figura> figuras;
        public FiguraDesaprobado(int x, int y, int ancho, int alto)
        {
            X = x;
            Y = y;
            width = ancho;
            height = alto;
            figuras = new List<Figura>();
            Borrador b = new Borrador(X, Y + height / 2, width / 3, height / 2);
            figuras.Add(b);
            MensajeNegativo mn = new MensajeNegativo(X + width / 3, Y, 2 * width / 3, height / 2);
            figuras.Add(mn);
        }

        public override void dibujar(Graphics g)
        {
            foreach (Figura f in figuras)
            {
                f.dibujar(g);
            }
        }
    }
}
