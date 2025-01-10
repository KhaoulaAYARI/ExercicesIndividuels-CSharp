using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1.Models
{
    public class Personne
    {
        private string _name;
        private int _age;

        
        public Personne(string name1, int age1)
        {
            _name = name1;
            _age = age1;
        }
        public string getName()
        {
            return _name;
        }
        public int getAge() 
        {
            return _age;
        }
        public void setName(string name1)
        {
            _name = name1;
        }
        public void setAge(int age) 
        {
            _age = age;
        }
    }
}
