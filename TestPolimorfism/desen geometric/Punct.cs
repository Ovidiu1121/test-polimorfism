using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPolimorfism.desen_geometric;

namespace TestPolimorfism
{
    public class Punct:Figura
    {

        private double x;
        private double y;

        public Punct()
        {

        }

        public Punct(double x,double y)
        {
            this.x = x;
            this.y = y;
        }

        public Punct(string prop)
        {
            string[] a = prop.Split(",");

            this.x = double.Parse(a[0]);
            this.y = double.Parse(a[1]);

        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public Double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public override string afisare()
        {
            string text = "Afisare punctului\n";

            text+="x="+this.x+" y"+this.y;

            return text;
        }

        public override void translateX(int x)
        {
            this.x+=x;
        }

        public override void translateY(int y)
        {
          this.y+=y;
        }

        public override void translateYX(int x, int y)
        {
            this.x=x;
            this.y=y;
        }

        public override Figura duplicare(Figura a)
        {
            Punct punct = a as Punct;
            return new Punct(punct.x, punct.y);
        }


    }
}
