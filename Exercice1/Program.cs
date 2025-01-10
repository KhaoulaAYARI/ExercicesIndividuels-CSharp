using Exercice1.Models;

namespace Exercice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne("Alex",25);
            Personne p2 = new Personne("Emily", 18);
            Console.WriteLine($"{p1.getName()} a {p1.getAge()}");
            Console.WriteLine($"{p2.getName()} a {p2.getAge()}");
            p2.setName("Laila");
            p2.setAge(30);



        }
    }
}
