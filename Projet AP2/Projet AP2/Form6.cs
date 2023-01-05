using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_AP2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        //Remplie la liste des médicaments
        private void Form6_Load(object sender, EventArgs e)
        {
            db.listeMedicament();

            db.fillEtapes();
            db.fillWorkflow();

            foreach (string key in Globale.LesMedicaments.Keys)
            {
                Medicament leMedicament = Globale.LesMedicaments[key];
                ListViewItem maLigne = new ListViewItem();
                maLigne.Text = leMedicament.getDepot();
                maLigne.SubItems.Add(leMedicament.getNom());
                maLigne.SubItems.Add(leMedicament.getFamille());
                lv_med.Items.Add(maLigne);
            }
        }

        //Remplie l'autre liste en fonction de la valeur sélectionnée dans la liste précédente
        private void lv_med_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_etapes.Items.Clear();
            ListView lv = (ListView)sender;
            if(lv.SelectedItems.Count > 0)
            {
                string dpt = lv.SelectedItems[0].Text;
                Workflow leWorkflow = null;
                foreach(string key in Globale.LesWorkflows.Keys)
                {
                    Workflow unWorkflow = Globale.LesWorkflows[key];
                    if(unWorkflow.getReference() == dpt)
                    {
                        leWorkflow = unWorkflow;
                    }
                }
                foreach(DateTime key in leWorkflow.getEtapes().Keys)
                {
                    Etape uneEtape = leWorkflow.getEtapes()[key];
                    ListViewItem lv_e = new ListViewItem();
                    lv_e.Text = leWorkflow.getReference();
                    lv_e.SubItems.Add(uneEtape.getNum().ToString());
                    Etape last = leWorkflow.getEtapes().Last().Value;
                    if (last != uneEtape)
                    {
                        lv_e.SubItems.Add("Validé");
                    }
                    else
                    {
                        if (leWorkflow.getDecision() == 2)
                        {
                            lv_e.SubItems.Add("Non validé");
                        }
                        else
                        {
                            lv_e.SubItems.Add("En cours...");
                        }
                    }
                    lv_e.SubItems.Add(key.ToString());

                    lv_etapes.Items.Add(lv_e);
                }
            }
        }

        private void lv_etapes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
