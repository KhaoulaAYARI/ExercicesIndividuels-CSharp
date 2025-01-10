namespace Exercice5.Models
{
    public class Compte
    {
        private string _nom;
        private string _numCompte;
        private double _solde;

        public Compte(string nom, string numCompte, double solde)
        {
            _nom = nom;
            _numCompte = numCompte;
            _solde = solde;
        }
        public string getNom()
        {
            return _nom;
        }
        public string getNumCompte()
        {
            return _numCompte;
        }
        public double getSolde()
        {
            return _solde;
        }
        public void setSolde(double solde)
        {
            _solde = solde;
        }
        public void setNom(string nom)
        {
            _nom = nom;
        }
        public void Deposer(double montant)
        {
            _solde += montant;
        }
        public void Retirer(double montant)
        {
            _solde -= montant;
        }
        public string GetCompteInfo()
        {
            return $"nom: {_nom} num de compte: {_numCompte} solde: {_solde}";
        }
    }
}