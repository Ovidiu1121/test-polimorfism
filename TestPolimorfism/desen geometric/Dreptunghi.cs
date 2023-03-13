using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfism.desen_geometric
{
    public class Dreptunghi:Figura
    {

        private Punct a;
        private Punct b;

        public Dreptunghi()
        {

        }

        public Dreptunghi(Punct a, Punct b)
        {
            this.a=a;
            this.b=b;
        }

        public Dreptunghi(string prop)
        {
            string[] a = prop.Split(",");

            this.a=new Punct(double.Parse(a[13]), double.Parse(a[14]));
            this.b=new Punct(double.Parse(a[15]), double.Parse(a[16]));
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

        public override string afisare()
        {
            string text = "Afisare dreptunghi\n";

            text+=this.a+"+"+this.b;

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
            Dreptunghi dreptunghi = f as Dreptunghi;
            return new Dreptunghi(dreptunghi.a, dreptunghi.b);
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
