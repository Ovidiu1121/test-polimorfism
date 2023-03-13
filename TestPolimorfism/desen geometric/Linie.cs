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
            string text = "--AFISARE LINIE--\nLinia este formata din\n";

            Punct p1 = a;
            Punct p2 = b;

            text+="punct 1: ("+p1.X+","+p1.Y+")"+"\npunct 2: ("+p2.X+","+p2.Y+")\n";

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
          
            return new Linie(this.a,this.b);
        }

        

    }
}
