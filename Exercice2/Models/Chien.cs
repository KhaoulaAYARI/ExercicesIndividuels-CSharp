using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2.Models
{
    public class Chien
    {
        private string _nom;
        private string _race;

        public Chien( string nom, string race)
        {
            this._nom = nom;
            this._race = race;
        }
        public string GetNom() 
        {
            return _nom;
        }
        public string GetRace()
        {
            return _race;
        }
        public void setNom(string nom) 
        {
            _nom = nom;
        }
        public void setRace(string race)
        {
            _race = race;
        }

    }
}
