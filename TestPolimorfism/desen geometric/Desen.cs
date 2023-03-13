using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfism.desen_geometric
{
    internal class Desen:Figura
    {
        private List<Figura> lista;

        public Desen()
        {

        }

        public Desen(List<Figura> f)
        {
            this.lista = f;
        }

        public override string afisare()
        {
            string text = "";
            Console.WriteLine("----FIGURI----\n\n");
            foreach(Figura f in lista)
            {

                Console.WriteLine(f.afisare());
            }

            return text;
        }

        public override void translateX(int x)
        {
            foreach (Figura f in lista)
            {
                f.translateX(x);
            }
        }

        public override void translateY(int y)
        {
            foreach (Figura f in lista)
            {
                f.translateY(y);
            }
        }

        public override void translateYX(int x, int y)
        {
            foreach (Figura f in lista)
            {
                f.translateYX(x, y);
            }
        }

        public override Figura duplicare()
        {

            List<Figura> figuri = new List<Figura>();

            foreach(Figura f in lista)
            {
                figuri.Add(f.duplicare());
            }

            Desen desen =new Desen(figuri);

            return desen;
        }


    }
}
