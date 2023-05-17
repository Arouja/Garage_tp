using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Automobile
    {
        private int annee;
        private string immatriculation;

        public Automobile()
        {
        }

        public Automobile(int annee, string immatriculation)
        {
            Annee = annee;
            Immatriculation = immatriculation;
            
        }

        public int Annee { get => annee; set => annee = value; }
        public string Immatriculation { get => immatriculation; set => immatriculation = value; }
        //public string Immatriculation {get;set;} same que l'autre

        public override string ToString()
        {
            return immatriculation+annee.ToString();
        }

    }
}
