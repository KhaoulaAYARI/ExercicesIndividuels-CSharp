using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3._3.Models
{
    public class Chanson
    {
        private string _titre;
        private string _artiste;

        public Chanson(string titre, string artiste)
        {
            _titre = titre;
            _artiste = artiste;
        }
        public string GetTitre()
            { return _titre; }
    }
}
