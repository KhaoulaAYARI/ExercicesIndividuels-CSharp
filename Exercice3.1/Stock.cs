using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3._1
{
    public class Stock
    {
        private List<Produit> _produits= new List<Produit>();
        public Stock()
        {
            
        }
        public void AddProduit(Produit produit)
        {
            _produits.Add(produit);
        }
        public void CheckStock()
        {
            foreach (Produit produit in _produits) 
            {
                produit.GetNom();
                produit.GetType();
            }
        }

    }
}
