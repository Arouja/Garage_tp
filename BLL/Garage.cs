using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Garage: Igarage
    {
        protected int adresse { get; set; }
        private List<Automobile> auto;

        public Garage(int adresse)
        {
            this.adresse = adresse;
            auto = new List<Automobile>();


        }

        public Garage()
        {
            auto = new List<Automobile>();
        }

        protected List<Automobile> Autos { get => auto; set => auto = value; }


        public string AddAuto(Automobile au)
        {
            try { 
            auto.Add(au);
            //return "la voiture" + au + "added successfully";
            return String.Empty;
            }
            catch(Exception ex)
            {
              return  ex.Message;
            }
        }

        public string UpdateAuto(Automobile au)
        {
            throw new NotImplementedException();
        }

        public int GetIndexAuto(Automobile a1)
        {
            for (int i=0; i< auto.Count; i++)
            {
                if(auto[i] == a1)
                    return i;
            }
            return -1;
        }

        public string DeleteAuto(string immatriculation)
        {
            Automobile au = new Automobile();
            if (au.Immatriculation == immatriculation)
                auto.Remove(au);
                return "Done";
        }

        public Automobile GetAuto(string immatriculation)
        {
            foreach(var item in auto)
            {
                if(item.Immatriculation == immatriculation)
                    return item;
            }
            return null;
            //throw new NotImplementedException();
        }

        public List<Automobile> AfficherAutomobiles(SubType sousType)
        {
            List<Automobile> temp = new List<Automobile>();
            switch (sousType)
            {
                case SubType.Voiture:
                    foreach (var item in auto)
                    {
                        if (item is Voiture)
                            temp.Add(item);

                    }
                    break;
                case SubType.Moto:
                    break;
                default:
                    break;
            }

            return temp;
        }
    }
}
