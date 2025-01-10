using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3._2.Models
{
    public class Etudiant
    {
        private string _nom;
        private int _age;

        public Etudiant(string nom, int age)
        {
            _nom = nom;
            _age = age;
        }
        public string GetNom()
        { return _nom; }
        public int GetAge()
        { return _age; }
        public void SetNom(string nom)
        {
            _nom = nom;
        }
        public void SetAge(int age)
        {
            _age = age;
        }
    }
}
