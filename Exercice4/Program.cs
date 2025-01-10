namespace Exercice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1= new Employee("alex", "ingenieur", 4500);
            e1.augSalaire(2);

            Console.WriteLine(e1.getNom() + e1.getSalaire());
            Console.WriteLine("afficher enmpoyee:");
            e1.AfficherEmploye();
        }
    }
}
