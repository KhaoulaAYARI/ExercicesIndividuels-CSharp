using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    public class Employee
    {
        private string _nom;
        private string _poste;
        private double _salaire;

        public Employee(string nom, string poste, double salaire)
        {
            _nom = nom;
            _poste = poste;
            _salaire = salaire;
        }
        public string getNom() 
        {
            return _nom;    
        }
        public void setNom(string nom)
        {
             _nom=nom;
        }
        public double getSalaire()
        {
            return _salaire;
        }
        public void augSalaire(double pourcentage)
        {
            _salaire += _salaire * pourcentage;
        }
        public void AfficherEmploye()
        {
            Console.WriteLine("Nom: "+ _nom);
            Console.WriteLine("Nom: " + _salaire);


        }


    }
}
