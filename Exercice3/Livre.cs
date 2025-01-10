using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    public class Livre
    {
        private string _titre;
        private string _auteur;
        private string _isbn;
        private static List<Livre> _livres= new List<Livre>();

        public Livre(string titre, string auteur, string isbn)
        {
            _titre = titre;
            _auteur = auteur;
            _isbn = isbn;
        }
        public string GetTitre()
        {
            return _titre;
        }
        public void SetTitre(string titre)
        {
            _titre = titre;
        }

        public static void AddLivre(Livre livre)
        {
            _livres.Add(livre);
        }
        public static void RemoveLivre(Livre livre)
        {
            _livres.Remove(livre);
        }
        public static List<Livre> GetLivres()
        {
            return _livres;
        }

    }
}
