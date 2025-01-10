using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2._2
{
    public class Employee
    {
        private string _nom;
        private double _salaire;
        private DateTime _dateEmbauche;

        public Employee(string nom, double salaire, DateTime dateEmbauche)
        {
            _nom = nom;
            _salaire = salaire;
            _dateEmbauche = dateEmbauche;
        }

        public string GetNom() { return _nom; }
        public double GetSalaire() { return _salaire; }
        public DateTime GetDateEmbauchee() { return _dateEmbauche; }

        public int CalculerAnnee()
        {
            return DateTime.Now.Year - _dateEmbauche.Year;
        }
        public void AfficherEmployee()
        {
            Console.WriteLine(_dateEmbauche+_nom+_salaire);
        }


    }
}
