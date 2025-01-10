using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3._2.Models
{
    public class Ecole
    {
        private List<Etudiant> _etudiants = new List<Etudiant>();
        private List<Enseignant> _enseignants = new List<Enseignant>();
        private List<Classe> _classes = new List<Classe>();

        public Ecole(List<Etudiant> etudiants, List<Enseignant> enseignants, List<Classe> classes)
        {
            _etudiants = etudiants;
            _enseignants = enseignants;
            _classes = classes;
        }

        public void AddEtudiant(Etudiant student)
        {
            _etudiants.Add(student);
        }
        public void RemoveEtudiant(Etudiant student)
        {
            _etudiants.Remove(student);
        }
        public void AddEnseignant(Enseignant teacher)
        {
            _enseignants.Add(teacher);
        }
        public void RemoveEnseignant(Enseignant teacher)
        {
            _enseignants.Remove(teacher);
        }
        public void AddClasse(Classe schoolclasse)
        {
            _classes.Add(schoolclasse);
        }
        public void RemoveClasse(Classe schoolclasse)
        {
            _classes.Remove(schoolclasse);
        }
        public List<Etudiant> GetEtudiants()
        {
            return _etudiants;
        }
        public List<Enseignant> GetEnseignants()
        {
            return _enseignants;
        }
        public List<Classe> GetClasses()
        {
            return _classes;
        }


    }
}
