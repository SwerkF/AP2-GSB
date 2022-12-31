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
            //Au chargement de la form, on remplis les variables globales
            db.fillEtapes();
            db.fillWorkflow();

            //On rempli la listview lv_workflow avec des workflows
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

        //Pour avoir les étapes d'un workflow, on peut en choisir un
        private void lv_workflow_SelectedIndexChanged(object sender, EventArgs e)
        {
            //On vide la listview des etapes
            lv_etape.Items.Clear();

            //On récupère l'élement choisi en l'associant à une référence
            ListView lv2 = (ListView)sender;
            if(lv2.SelectedItems.Count > 0)
            {
                string reference = lv2.SelectedItems[0].Text;
                Workflow leWorkflow = null;

                //On cherche ensuite un workflow ayant cette référence
                foreach(string key in Globale.LesWorkflows.Keys)
                {
                    Workflow unWorkflow = Globale.LesWorkflows[key];
                    if(unWorkflow.getReference() == reference)
                    {
                        leWorkflow = unWorkflow;
                    }
                }

                //Ensuite, on récupère toutes les étapes d'un Workflow 
                foreach(DateTime key in leWorkflow.getEtapes().Keys)
                {
                    Etape uneEtape = leWorkflow.getEtapes()[key]; // Une étape

                    //On crée un nouveau objet pour la listview
                    ListViewItem lv = new ListViewItem();
                    lv.Text = uneEtape.getNum().ToString();
                    lv.SubItems.Add(uneEtape.getLibelle().ToString());
                    lv.SubItems.Add(key.ToString());

                    //On récupère la dernière étape du workflow
                    Etape last = leWorkflow.getEtapes().Last().Value;

                    //Si l'étape actuelle n'est pas la dernière, on admets qu'elle l'est.
                    if(last != uneEtape)
                    {
                        lv.SubItems.Add("Validé");
                    } else
                    {
                        //Sinon si la décision est 2, c'est à dire qu'elle n'est pas validé, sinon elle est en cours de validation
                        if(leWorkflow.getDecision() == 2)
                        {
                            lv.SubItems.Add("Non validé");
                        } else
                        {
                            lv.SubItems.Add("En cours...");
                        }
                    }
                   
                    //Ensuite on regarde si l'étape est normée
                    if (uneEtape.GetType().Name.ToString() == "Norme")
                    {
                        lv.SubItems.Add((uneEtape as Norme).getNorme());
                        //Si elle n'est pas normée, on mets vide
                        if ((uneEtape as Norme).getDateNorme().ToString() == "01-01-1990")
                        {
                            lv.SubItems.Add("vide");
                        }
                        //Si elle l'est, o nrajoute le string
                        else
                        {
                            lv.SubItems.Add((uneEtape as Norme).getDateNorme().ToString());
                        }
                    }
                    else
                    {
                        //Sinon on mets les 2 a vide pour remplir la listview
                        lv.SubItems.Add("vide");
                        lv.SubItems.Add("vide");
                    }
                    //On ajout l'etape à la listview
                    lv_etape.Items.Add(lv);
                }


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
