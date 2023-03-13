using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfism.desen_geometric
{
    public class Eticheta:Dreptunghi
    {
       
        private string text;

        public Eticheta()
        {

        }

        public Eticheta(Linie linie1,Linie linie2 ,string textEticheta):base(linie1, linie2)
        {
            this.text = textEticheta;
        }

        public Eticheta(string text)
        {
            this.text=text;
        }

        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        public override string afisare()
        {
            string t = "--AFISARE ETICHETA--\n";

            t+=this.text+"\n";

            return t;

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
            return new Eticheta(this.text);
        }


    }
}
