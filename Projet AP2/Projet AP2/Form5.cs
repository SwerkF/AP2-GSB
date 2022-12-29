using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_AP2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        //Remplie la liste des familles
        private void Form5_Load(object sender, EventArgs e)
        {
            db.listeFamille();
            db.listeMedicament();

            foreach (string key in Globale.lesFamilles.Keys)
            {
                Famille laFamille = Globale.lesFamilles[key];
                ListViewItem maLigne = new ListViewItem();
                maLigne.Text = laFamille.getCodeFamille();
                maLigne.SubItems.Add(laFamille.getLibelle());
                maLigne.SubItems.Add(laFamille.getNbMed().ToString());
                lv_famille.Items.Add(maLigne);
            }
        }

        //Remplie l'autre liste en fonction de la valeur sélectionnée dans la liste précédente
        private void lv_famille_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_medicaments.Items.Clear();
            ListView lv = (ListView)sender;
            if (lv.SelectedItems.Count > 0)
            {
                string fam = lv.SelectedItems[0].Text;
                Medicament leMedicament = null;
                foreach (string key in Globale.LesMedicaments.Keys)
                {
                    Medicament unMedicament = Globale.LesMedicaments[key];
                    if (unMedicament.getFamille() == fam)
                    {
                        leMedicament = unMedicament;
                        ListViewItem lvM = new ListViewItem();
                        lvM.Text = leMedicament.getDepot();
                        lvM.SubItems.Add(leMedicament.getNom());
                        lvM.SubItems.Add(leMedicament.getFamille());
                        lvM.SubItems.Add(leMedicament.getComposition());
                        lvM.SubItems.Add(leMedicament.getEffets());
                        lvM.SubItems.Add(leMedicament.getContreIndication());
                        lv_medicaments.Items.Add(lvM);
                    }

                }
            }
        }
    }
}
