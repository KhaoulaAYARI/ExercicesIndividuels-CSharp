using Exercice2.Models;

namespace Exercice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chien c1 = new Chien("Rex", "A");
            Chien c2 = new Chien("Fox", "B");

            c1.setRace("X");
            c2.setRace("Y");
            Console.WriteLine($"les nouvelles races sont : {c1.GetRace()} et {c2.GetRace()} ");
        }
    }
}
