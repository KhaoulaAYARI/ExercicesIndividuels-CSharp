using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3._3.Models
{
    public class BiblioMusicale
    {
        private List<Chanson> _chansons=new List<Chanson>();

        public BiblioMusicale()
        {
            
        }
        public void AddChonson(Chanson song)
        {
            _chansons.Add(song);
        }
        public List<Chanson> GetChansons() { return _chansons; }
        public void LireChanson()
        { 
            Random rnd = new Random();
            int indiceChanson = rnd.Next(0, _chansons.Count());
            Chanson[] tabChanson = _chansons.ToArray();
            for (int i = 0; i < tabChanson.Length; i++)
            {
                if (i == indiceChanson)
                {
                    Console.WriteLine(tabChanson[i].GetTitre());
                }
            }
        }
    }
}
