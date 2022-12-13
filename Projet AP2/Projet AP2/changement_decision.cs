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

        string workflowStr = "";
        int etpNum = 0;
        int dcsNum = 0;
        DateTime date = DateTime.Now;
        
        private void loadAll()
        {
            lv_next_etape.Items.Clear();
            lv_workflow.Items.Clear();
            db.fillEtapes();
            db.fillWorkflow();
            db.listeMedicament();
            foreach (string key in Globale.LesMedicaments.Keys)
            {
                Medicament medicament = Globale.LesMedicaments[key];

                ListViewItem lv = new ListViewItem();
                lv.Text = medicament.getDepot();
                lv.SubItems.Add(medicament.getNom());

                Workflow workflow = null;


                foreach (string key2 in Globale.LesWorkflows.Keys)
                {
                    if (key2 == medicament.getDepot())
                    {
                        workflow = Globale.LesWorkflows[key2];
                    }
                }
                lv.SubItems.Add(workflow.getEtapes().Last().Value.getNum().ToString());
                lv.SubItems.Add(workflow.getEtapes().Last().Value.getLibelle());
                lv_workflow.Items.Add(lv);

            }
        }
        private void changement_decision_Load(object sender, EventArgs e)
        {
            loadAll();
        }

        private void lv_workflow_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_next_etape.Items.Clear();
            ListView lv2 = (ListView)sender;
            if (lv2.SelectedItems.Count > 0)
            {
                string reference = lv2.SelectedItems[0].Text;

                Workflow leWorkflow = null;
                string list = "";
                foreach (string key in Globale.LesWorkflows.Keys)
                {
                    
                    Workflow unWorkflow = Globale.LesWorkflows[key];
                    list = list + " " + key + " == " + reference + "\n";
                    if (unWorkflow.getReference() == reference)
                    {
                        leWorkflow = unWorkflow;
                    }
                }

                workflowStr = leWorkflow.getReference();
                int last = leWorkflow.getEtapes().Last().Value.getNum() + 1;
                if (leWorkflow.getDecision() == 2)
                {
                    MessageBox.Show("Impossible de mettre à jour ce médicament, il a été refusé.");
                    return;
                }
                Etape lEtape = null;
                foreach (Etape uneEtape in Globale.LesEtapes)
                {
                    if(uneEtape.getNum() == last)
                    {
                        lEtape = uneEtape;
                    }
                }

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
