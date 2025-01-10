using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3._2.Models
{
    public class Classe
    {
        private string _nomClasse;
        private Enseignant _enseignant;
        private List<Etudiant> _etudiant = new List<Etudiant>();

        public Classe(string nomClasse, Enseignant enseignant, List<Etudiant> etudiant)
        {
            _nomClasse = nomClasse;
            _enseignant = enseignant;
            _etudiant = etudiant;
        }

        public string GetNomClasse()
        { return _nomClasse; }
        public Enseignant GetEnseignant()
        { return _enseignant; }
        public List<Etudiant> GetEtudiant()
        { return _etudiant; }

        public void SetNomClasse(string nom)
        {
            _nomClasse = nom;
        }
        public void SetEnseignant(Enseignant enseignant)
        {
            _enseignant = enseignant;
        }
        public void AddEtudiant(Etudiant e)
        {
            _etudiant.Add(e);
        }
        public void RemoveEtudiant(Etudiant e)
        {
            _etudiant.Remove(e);
        }

    }
}
