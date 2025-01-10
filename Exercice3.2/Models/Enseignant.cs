using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3._2.Models
{
    public class Enseignant
    {
        private string _nom;
        private string _matiere;

        public Enseignant(string nom, string matiere)
        {
            _nom = nom;
            _matiere = matiere;
        }

        public string GetNom()
            { return _nom; }
        public string GetMatieree()
        { return _matiere; }
        public void SetNom(string nom)
        {
            _nom = nom;
        }
        public void SetMatiere(string matiere)
        {
            _matiere = matiere;
        }


    }
}
