using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfism.desen_geometric
{
    public class Figura
    {
        public virtual string afisare()
        {
            return "";
        }

        public virtual void translateX(int x)
        {
            Console.WriteLine("SUNT IN TRANSLATE X DIN BAZA");
        }

        public virtual void translateY(int y)
        {
            Console.WriteLine("SUNT IN TRANSLATE Y DIN BAZA");
        }

        public virtual void translateYX(int x, int y)
        {
            Console.WriteLine("SUNT IN TRANSLATE X SI Y DIN BAZA");
        }

        public virtual Figura duplicare(Figura a)
        {
            Console.WriteLine("SUNT IN DUPLICARE DIN BAZA");
            
            return a;
        }

    }
}
