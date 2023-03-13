using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfism.desen_geometric
{
    public class Cerc:Figura
    {

        
        private Punct b;
        private Linie c;

        public Cerc()
        {

        }

        public Cerc(Punct b,Linie c)
        {
            this.b = b;
            this.c = c;
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
            string text = "--AFISARE CERC--\nCercul este format din\n";

            Punct p = b;
            Linie l = c;

            text+="punct: ("+p.X+","+p.Y+")\n"+"linie: punct 1 ("+l.A.X+","+l.A.Y+"), punct 2: ("+l.B.X+","+l.B.Y+")\n";

            return text;
        }

        public override void translateX(int x)
        {
            base.translateX(x);
        }

        public override void translateY(int y)
        {
            base.translateY(y);
        }

        public override void translateYX(int x, int y)
        {
            base.translateYX(x, y);
        }

        public override Figura duplicare()
        {
            return new Cerc(this.b,this.c);
        }

      

    }
}
