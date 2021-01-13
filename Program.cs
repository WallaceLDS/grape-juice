using System;

namespace grapeJuice
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem p1 = new Personagem(5,1,1,1);
            Personagem p2 = new Personagem(3,2,1,2);
            Console.WriteLine($"Vida do personagem 1= {p1.GEThp()}");
            Console.WriteLine($"Vida do personagem 2= {p2.GEThp()}");
            Console.WriteLine($"Personagem 2 atacando Personagem 1....");
            p1.SEThp(p2.GETatk() - p1.GETdef());
            Console.WriteLine($"Vida do personagem 1= {p1.GEThp()}");
            Console.WriteLine($"Vida do personagem 2= {p2.GEThp()}");
        }
    }
}
