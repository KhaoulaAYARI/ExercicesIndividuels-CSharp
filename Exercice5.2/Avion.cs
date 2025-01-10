using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5._2
{
    public class Avion
    {
        private string _numVol;
        private string _destination;
        private DateTime _heureDepart;
        private int _tempsRetard;

        public Avion(string numVol, string destination, DateTime heureDepart, int tempsRetard)
        {
            _numVol = numVol;
            _destination = destination;
            _heureDepart = heureDepart;
            _tempsRetard = tempsRetard;
        }
        public string getVol() { return _numVol; }
        public string getDestination() { return _destination; }
        public DateTime getHeureDepart() { return _heureDepart; }
        public int getTpsRetard() { return _tempsRetard; }
        public void Retarder (int minutes)
        {
            _tempsRetard += minutes;
        }


    }
}
