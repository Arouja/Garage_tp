using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class Moto:Automobile
    {
        private string cylindre;
        private int vitesseMax;

        public Moto()
        {
        }

        public Moto(string cylindre, int vitesseMax) : base()
        {
            this.cylindre = cylindre;
            this.vitesseMax = vitesseMax;
        }

        public  string Cylindre { get => cylindre; set => cylindre = value; }
        public int VitesseMax { get => vitesseMax; set => vitesseMax = value; }
    }
}
