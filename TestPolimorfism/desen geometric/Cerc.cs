using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfism.desen_geometric
{
    public class Cerc:Figura
    {

        private Punct a;
        private Punct b;
        private Linie c;

        public Cerc()
        {

        }

        public Cerc(Punct a,Punct b,Linie c):base()
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Cerc(string prop)
        {
            string[] a = prop.Split(",");

            this.a=new Punct(double.Parse(a[5]), double.Parse(a[6]));
            this.b=new Punct(double.Parse(a[7]), double.Parse(a[8]));
            this.c=new Linie(new Punct(double.Parse(a[9]), double.Parse(a[10])),new Punct(double.Parse(a[11]), double.Parse(a[12])));
        }

        public Punct A
        {
            get { return this.a; }
            set { this.a = value; }
        }

        public Punct B
        {
            get { return this.b; }
            set { this.b = value; }
        }

        public Linie C
        {
            get { return this.c; }
            set { this.c = value; }
        }

        public override string afisare()
        {
            string text = "Afisare cerc\n";

            text+=this.a+"+"+this.b+"\n";
            text+=this.c;

            return text;
        }

        public override void translateX(int x)
        {
            this.a.X=x;
            this.b.X=x;
        }

        public override void translateY(int y)
        {
            this.a.Y=y;
            this.b.Y=y;
        }

        public override Figura duplicare(Figura f)
        {
            Cerc cerc = f as Cerc;
            return new Cerc(cerc.a,cerc.b,cerc.c);
        }

        public override void translateYX(int x, int y)
        {
            this.a.X=x;
            this.a.Y=y;
            this.b.X=x;
            this.b.Y=y;
        }

    }
}
