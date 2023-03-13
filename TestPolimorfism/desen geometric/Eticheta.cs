using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfism.desen_geometric
{
    public class Eticheta:Figura
    {

        private Dreptunghi a;
        private string text;

        public Eticheta()
        {

        }

        public Eticheta(Dreptunghi a,string text)
        {
            this.a = a;
            this.text = text;
        }

        public Eticheta(string prop)
        {
            string[] a = prop.Split(",");

            this.a= new Dreptunghi(new Punct(int.Parse(a[17]), int.Parse(a[18])), new Punct(int.Parse(a[19]), int.Parse(a[20])));
            this.text=a[21];
        }

        public Dreptunghi A
        {
            get { return this.a; }
            set { this.a = value; }
        }

        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        public override string afisare()
        {
            string t = "afisare eticheta\n";

            t+=this.a+" "+this.text;

            return t;

        }

        public override void translateX(int x)
        {
            this.a.A.X = x;
            this.a.B.X = x;
        }

        public override void translateY(int y)
        {
            this.a.A.Y = y;
            this.a.B.Y = y;
        }

        public override void translateYX(int x, int y)
        {
            this.a.A.X = x;
            this.a.A.Y = y;
            this.a.B.X = x;
            this.a.B.Y = y;
        }

        public override Figura duplicare(Figura a)
        {
            Eticheta eticheta = a as Eticheta;

            return new Eticheta(eticheta.a, eticheta.text);
        }


    }
}
