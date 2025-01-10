namespace Exercice2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Roni", 10000,
                new DateTime(1990,02,02));
            Console.WriteLine(e1.CalculerAnnee());
            Console.WriteLine("afficher e1");
            e1.AfficherEmployee();
        }
    }
}
