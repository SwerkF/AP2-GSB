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
    public partial class consultation_workflow : Form
    {
        public consultation_workflow()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            db.fillEtapes();
            db.fillWorkflow();
            foreach (string key in Globale.LesWorkflows.Keys)
            {
                Workflow unWorkflow = Globale.LesWorkflows[key];
                ListViewItem lv = new ListViewItem();

                lv.Text = unWorkflow.getReference();
                lv.SubItems.Add(unWorkflow.getEtape().ToString());
                lv.SubItems.Add(unWorkflow.getEtapes().Last().Value.getNum().ToString()) ;
                lv.SubItems.Add(unWorkflow.getDate().ToString());

                lv_workflow.Items.Add(lv);

            }
        }

        private void lv_workflow_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_etape.Items.Clear();
            ListView lv2 = (ListView)sender;
            if(lv2.SelectedItems.Count > 0)
            {
                string reference = lv2.SelectedItems[0].Text;
                Workflow leWorkflow = null;
                foreach(string key in Globale.LesWorkflows.Keys)
                {
                    Workflow unWorkflow = Globale.LesWorkflows[key];
                    if(unWorkflow.getReference() == reference)
                    {
                        leWorkflow = unWorkflow;
                    }
                }

                foreach(DateTime key in leWorkflow.getEtapes().Keys)
                {
                    Etape uneEtape = leWorkflow.getEtapes()[key];
                    ListViewItem lv = new ListViewItem();
                    lv.Text = uneEtape.getNum().ToString();
                    lv.SubItems.Add(uneEtape.getLibelle().ToString());
                    lv.SubItems.Add(key.ToString());
                    Etape last = leWorkflow.getEtapes().Last().Value;
                    if(last != uneEtape)
                    {
                        lv.SubItems.Add("Validé");
                    } else
                    {
                        if(leWorkflow.getDecision() == 2)
                        {
                            lv.SubItems.Add("Non validé");
                        } else
                        {
                            lv.SubItems.Add("En cours...");
                        }
                    }
                   
                    if (uneEtape.GetType().Name.ToString() == "Norme")
                    {
                        lv.SubItems.Add((uneEtape as Norme).getNorme());
                        if ((uneEtape as Norme).getDateNorme().ToString() == "01-01-1990")
                        {
                            lv.SubItems.Add("vide");
                        }
                        else
                        {
                            lv.SubItems.Add((uneEtape as Norme).getDateNorme().ToString());
                        }
                    }
                    else
                    {
                        lv.SubItems.Add("vide");
                        lv.SubItems.Add("vide");
                    }

                    lv_etape.Items.Add(lv);
                }


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
