using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class Form1 : Form
    {
        private List<Automobile> auto;
        public Garage garage = new Garage();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(btnrv.Checked)
            {
                Voiture v = new Voiture();
                Nouvelle_voiture nv = new Nouvelle_voiture(v);
                if(nv.ShowDialog()== DialogResult.OK)
                {
                    garage.AddAuto(v);
                }
                auto = garage.AfficherAutomobiles(SubType.Voiture);
                remplitListe();
            }
            else if (btnrm.Checked)
            {
                Moto m = new Moto();
                Voiture v = new Voiture();

                Nouvelle_voiture nm = new Nouvelle_voiture(v);
                if(nm.ShowDialog()== DialogResult.OK)
                {
                    garage.AddAuto(m);
                }
                auto = garage.AfficherAutomobiles(SubType.Moto);
                remplitListe();

            }
        }
        private void remplitListe()
        {
            liste.Items.Clear();
            foreach(Automobile a in auto)
            {
                liste.Items.Add(a);
            }
        }

      
        private void btndetails_Click(object sender, EventArgs e)
        {
            int i = liste.SelectedIndex;
            if (i != -1)
            {
                if (btnrv.Checked)
                {
                    Voiture v = auto[i] as Voiture;
                    voiture_info vi = new voiture_info(v);
                    vi.Show();
                }
                if (btnrm.Checked)
                {
                    Moto m = auto[i] as Moto;
                    moto_info vi = new moto_info(m);
                    vi.Show();
                }
            }
        }
        public void remplirChamps()
        {
            Automobile au = liste.SelectedItem as Automobile;
            label1.Text = au.Immatriculation;
            label2.Text = au.Annee.ToString();
            label3.Text = btnrm.Checked ? "Moto" : "Voiture";
        }

        private void liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirChamps();
        }
    }
}
