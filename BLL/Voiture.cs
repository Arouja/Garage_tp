using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Voiture : Automobile
    {
        private string couleur;
        private string marque;
        private string typeV;

        public string Couleur { get => couleur; set => couleur = value; }
        public string Marque { get => marque; set => marque = value; }
        public string TypeV { get => typeV; set => typeV = value; }

        public Voiture()
        {
        }

        public Voiture(int an, string imm,string couleur, string marque, string typeV):base(an,imm)
        {

            this.couleur = couleur;
            this.marque = marque;
            this.typeV = typeV;
        }
        public override string ToString()
        {
            return base.ToString()+ this.Marque+" "+this.Couleur+ " "+this.TypeV;
        }

    }
}
