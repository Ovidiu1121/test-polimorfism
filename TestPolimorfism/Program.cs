

using TestPolimorfism;
using TestPolimorfism.desen_geometric;

Eticheta a = new Eticheta("titlu");

Console.WriteLine(a.afisare());

Punct b = new Punct(2,5);
Console.WriteLine(b.afisare());

Linie c = new Linie(b,new Punct(12,6));
Console.WriteLine(c.afisare());

Dreptunghi d = new Dreptunghi(c, new Linie(new Punct(11, 9), new Punct(0, 8)));
Console.WriteLine(d.afisare());

Cerc e = new Cerc(b, c);
Console.WriteLine(e.afisare());

List<Figura> lista=new List<Figura>();
lista.Add(a);
lista.Add(b);
lista.Add(c);
lista.Add(d);
lista.Add(e);

Desen desen = new Desen(lista);

Console.WriteLine(desen.afisare());

desen.translateX(2);


Console.WriteLine(desen.afisare());










