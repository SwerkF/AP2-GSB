using Microsoft.Extensions.Caching.Distributed;
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
    public partial class changement_decision : Form
    {
        public changement_decision()
        {
            InitializeComponent();
        }

        //Variables
        string workflowStr = "";
        int etpNum = 0;
        int dcsNum = 0;
        DateTime date = DateTime.Now;
        
        //Permet de remplir la listview lv_workflow afin d'avoir la liste
        private void loadAll()
        {
            //On vide les 2 listview
            lv_next_etape.Items.Clear();
            lv_workflow.Items.Clear();

            //On rempli les variables globales
            db.fillEtapes();
            db.fillWorkflow();
            db.listeMedicament();

            //On ajoute chaque médicament dans la listview
            foreach (string key in Globale.LesMedicaments.Keys)
            {

                Medicament medicament = Globale.LesMedicaments[key];

                //On crée un nouvel objet pour la listview
                ListViewItem lv = new ListViewItem();
                lv.Text = medicament.getDepot();
                lv.SubItems.Add(medicament.getNom());

                Workflow workflow = null;

                //On récupère le workflow du médicament
                foreach (string key2 in Globale.LesWorkflows.Keys)
                {
                    if (key2 == medicament.getDepot())
                    {
                        workflow = Globale.LesWorkflows[key2];
                    }
                }

                //On ajoute la dernière étape du workflow du médicament
                lv.SubItems.Add(workflow.getEtapes().Last().Value.getNum().ToString());
                lv.SubItems.Add(workflow.getEtapes().Last().Value.getLibelle());

                //On ajout le workflow dans la listview
                lv_workflow.Items.Add(lv);

            }
        }
        private void changement_decision_Load(object sender, EventArgs e)
        {
            //Au chargement, on lance la fonction loadAll()
            loadAll();
        }

        //On peut choisir le workflow a mettre à jour
        private void lv_workflow_SelectedIndexChanged(object sender, EventArgs e)
        {
            //On vite la listview qui affiche la prochaine étape
            lv_next_etape.Items.Clear();

            //On choisi dans la listview 
            ListView lv2 = (ListView)sender;
            if (lv2.SelectedItems.Count > 0)
            {
                string reference = lv2.SelectedItems[0].Text;

                Workflow leWorkflow = null;
                //On cherche le workflow associé à cette référence
                foreach (string key in Globale.LesWorkflows.Keys)
                {
                    Workflow unWorkflow = Globale.LesWorkflows[key];
                    if (unWorkflow.getReference() == reference)
                    {
                        leWorkflow = unWorkflow;
                    }
                }

                workflowStr = leWorkflow.getReference();

                //Si la decision du workflow est 2, soit refusée, on ne peut pas le mettre à jour
                int last = leWorkflow.getEtapes().Last().Value.getNum() + 1;
                if (leWorkflow.getDecision() == 2)
                {
                    MessageBox.Show("Impossible de mettre à jour ce médicament, il a été refusé.");
                    return;
                }

                //On cherche l'étape qui est la dernière dans le workflow
                Etape lEtape = null;
                foreach (Etape uneEtape in Globale.LesEtapes)
                {
                    if(uneEtape.getNum() == last)
                    {
                        lEtape = uneEtape;
                    }
                }

                //On ajout à la listview lv_next_etape, la prochaine etape
                ListViewItem lv = new ListViewItem();
                lv.Text = lEtape.getNum().ToString();
                etpNum = leWorkflow.getEtapes().Last().Value.getNum();
                lv.SubItems.Add(lEtape.getLibelle());
                if (lEtape.GetType().Name == "Norme")
                {
                    lv.SubItems.Add((lEtape as Norme).getNorme());
                    lv.SubItems.Add((lEtape as Norme).getDateNorme().ToString());
                } else
                {
                    lv.SubItems.Add("Aucune");
                    lv.SubItems.Add("Aucune");
                }

                lv_next_etape.Items.Add(lv);
            }
        }

        //Accepter ou refuser une étape. Si elle est accepté, on mets 3, sinon on mets 2
        private void btn_valider_Click(object sender, EventArgs e)
        {
            db.addEtapeWorkflow(workflowStr, etpNum, 1003, DateTime.Parse(dtp_etape.Value.ToString())) ;
            loadAll();
        }

        private void btn_refuser_Click(object sender, EventArgs e)
        {
            db.addEtapeWorkflow(workflowStr, etpNum, 2, DateTime.Parse(dtp_etape.Value.ToString()));
            loadAll();
        }
    }
}
