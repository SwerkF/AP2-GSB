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
    public partial class maj_etp_norme : Form
    {
        public maj_etp_norme()
        {
            InitializeComponent();
        }

        //Fonction pour charger la listview

        private void loadLV()
        {

            //On vide la listview et on remplis les variables globales LesEtapes et LesWorkflows

            lv_norme.Items.Clear();
            db.fillEtapes();
            db.fillWorkflow();

            // Pour chaque étape, on regarde si elle est normée
            foreach(Etape uneNorme in Globale.LesEtapes)
            {
                //Si l'étape est normé, on l'ajoute dans la listview
                if (uneNorme.GetType().Name.ToString() == "Norme")
                {
                    Norme laNorme = (uneNorme as Norme);
                    ListViewItem lv = new ListViewItem();
                    lv.Text = laNorme.getNum().ToString();
                    lv.SubItems.Add(laNorme.getLibelle());
                    lv.SubItems.Add(laNorme.getNorme());
                    lv.SubItems.Add(laNorme.getDateNorme().ToString());
                    lv_norme.Items.Add(lv);
                } 
            }
        }

        string etp = ""; //Numero de l'étape à mettre à jour
        

        //Chargement de la listview au lancement de la form
        private void maj_etp_norme_Load(object sender, EventArgs e)
        {
            loadLV();
        }

        //Mise à jour de l'etape normée
        private void btn_norme_Click(object sender, EventArgs e)
        {
            //Si la nouvelle norme est saisie et que le numero de l'étape n'est pas vide
            if(tb_norme.Text != "" && etp != "")
            {
                //Mise à jour de la norme
                db.updateNorme(int.Parse(etp), Globale.user, DateTime.Parse(dtp_norme.Value.ToString()), tb_norme.Text); 

                //Remise à 0 des variables et textbox
                tb_norme.Text = ""; 
                etp = "";

                //Rechargement de la listview
                loadLV();
            }
        }

        //Récupérer le numero de l'étape lorsqu'on clique sur un item de la listview
        private void lv_norme_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv_norme = (ListView)sender;
            if (lv_norme.SelectedItems.Count > 0)
            {
                etp = lv_norme.SelectedItems[0].Text;
                MessageBox.Show("Vous êtes sur le point de mettre à jour l'étape n°" + etp);

            }
        }
    }
}
