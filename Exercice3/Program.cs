using System.Diagnostics;

namespace Exercice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livre livre1 = new Livre("la vie est belle", "MonsieurX", "ISBN12587456");
            Livre livre2 = new Livre("la vie est belle", "MonsieurY", "ISBN12587456");
            Livre livre3 = new Livre("la vie est belle", "Monsieurz", "ISBN12587456");

            Livre.AddLivre(livre1);
            Livre.AddLivre(livre2);
            Livre.AddLivre(livre3);

            List<Livre> livres = Livre.GetLivres();
            Console.WriteLine("la liste des livres: ");
            foreach (Livre l in livres )
            {
                Console.WriteLine(l.GetTitre() );
            }


        }
    }
}
