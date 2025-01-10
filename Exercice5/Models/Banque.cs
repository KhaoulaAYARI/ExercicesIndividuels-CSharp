using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5.Models
{
    public class Banque
    {
        private List<Compte> _comptes = new List<Compte>();
        //En initialisant la liste dans la classe Banque, tu t'assures que chaque instance de Banque a sa propre liste prête à l'emploi.

        public Banque()
        {
            
        }
        public void AddCompte(Compte compte)
        {
            _comptes.Add(compte);
        }
        public void RemoveCompte(Compte compte)
        {
            _comptes.Remove(compte);
        }
        public void DeposerArgent(Compte compte, double montant )
        {
            compte.Deposer(montant);
        }
        public void RetirerArgent(Compte compte, double montant)
        {
            compte.Retirer(montant);
        }
        public List<Compte> getComptes()
        {
            return _comptes;
        }



    }
}
