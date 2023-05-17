using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
   // Voiture v = new Voiture();
    public partial class Nouvelle_voiture : Form
        
    {
        public Voiture voiture { get; set; }
        public Nouvelle_voiture(Voiture v)
        {
            InitializeComponent();
            voiture = v;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            voiture.Annee = int.Parse( textBox1.Text);
            voiture.Immatriculation = textBox2.Text;
            voiture.Couleur = textBox3.Text;
            voiture.Marque = textBox4.Text;
            voiture.TypeV = textBox5.Text;

        }
    }
}
