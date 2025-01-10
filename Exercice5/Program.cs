using Exercice5.Models;

namespace Exercice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banque banque1 = new Banque();

            Compte compte1= new Compte("Mira", "BE123654", 5000);
            Compte compte2 = new Compte("Alex", "BE123654", 5000);
            Compte compte3 = new Compte("Sonia", "BE123654", 5000);
            Compte compte4 = new Compte("Julie", "BE123654", 5000);

            banque1.AddCompte(compte1);
            banque1.AddCompte(compte2);
            banque1.AddCompte(compte3);
            banque1.AddCompte(compte4);

            List<Compte> compteList = banque1.getComptes();
            foreach (Compte c in compteList)
            {
                Console.WriteLine(c.GetCompteInfo());
            }






        }
    }
}
