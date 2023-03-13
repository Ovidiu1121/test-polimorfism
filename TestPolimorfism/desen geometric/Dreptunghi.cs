using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfism.desen_geometric
{
    public class Dreptunghi:Figura
    {

        private Linie linie1;
        private Linie linie2;

        public Dreptunghi()
        {

        }

        public Dreptunghi(Linie linie1, Linie linie2)
        {
            this.linie1=linie1;
            this.linie2=linie2;
        }

        public Linie Linie1
        {
            get { return this.linie1; }
            set { this.linie1 = value; }
        }

        public Linie Linie2
        {
            get { return this.linie2; }
            set { this.linie2 = value; }
        }

        public override string afisare()
        {
            string text = "--AFISARE DREPTUNGHI--\nDreptunghiul este format din\n";

            Linie l1 = linie1; 
            Linie l2 = linie2;

            text+="linie 1: punct 1 ("+l1.A.X+","+l1.A.Y+"), punct 2: ("+l1.B.X+","+l1.B.Y+")\n";
            text+="linie 2: punct 2 ("+l2.A.X+","+l2.A.Y+"), punct 2: ("+l2.B.X+","+l2.B.Y+")\n";

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
            return new Dreptunghi(this.linie1, this.linie2);
        }

        


    }
}
