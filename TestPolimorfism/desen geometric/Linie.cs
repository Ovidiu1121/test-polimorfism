using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfism.desen_geometric
{
    public class Linie:Figura
    {

        private Punct a;

        private Punct b;

        public Linie()
        {

        }

        public Linie(Punct a,Punct b)
        {
            this.a=a;
            this.b=b;
        }
        
        public Linie(string prop)
        {
            string[] a = prop.Split(",");

            this.a=new Punct(double.Parse(a[2]), double.Parse(a[3]));
            this.b=new Punct(double.Parse(a[4]), double.Parse(a[5])); 
        }

        public Punct A
        {
            get { return this.a ; }
            set { this.a = value ; }
        }

        public Punct B
        {
            get { return this.b ; }
            set { this.b = value ; }
        }

        public override string afisare()
        {
            string text = "Afisare linie\n";

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
            Linie linie = f as Linie;
            return new Linie(linie.a,linie.b);
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
