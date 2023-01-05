using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_AP2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            db.listeClient();
        }

        //Vérification lors de l'action agissant sur le bouton
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (tb_cdefamille.Text != "" && tb_composition.Text != "" && tb_contreIndi.Text != "" && tb_dp.Text != "" && tb_effets.Text != "" && tb_nom.Text != "")
            {
                if (Globale.LesMedicaments.ContainsKey(tb_dp.Text))
                {
                    MessageBox.Show("Ce dépot légale est déjà attribué à un autre medicament", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string dpt = tb_dp.Text.Trim();
                    if (db.getInsertMed(dpt, tb_nom.Text, tb_cdefamille.Text, tb_composition.Text, tb_effets.Text, tb_contreIndi.Text))
                    {
                        MessageBox.Show("Le médicament a bien été ajouté");
                    }
                    else
                    {
                        MessageBox.Show("Ajout impossible");
                    }
                }
            }
            else
            {
                MessageBox.Show("Erreur, il faut renseigner tous les champs");
            }
        }

        private void tb_dp_TextChanged(object sender, EventArgs e)
        {
            if (tb_cdefamille.Text != "" && tb_composition.Text != "" && tb_contreIndi.Text != "" && tb_dp.Text != "" && tb_effets.Text != "" && tb_nom.Text != "")
            {
                btn_ajouter.Enabled = true;
            }
            else
            {
                btn_ajouter.Enabled = false;
            }
        }

        private void tb_nom_TextChanged(object sender, EventArgs e)
        {
            if (tb_cdefamille.Text != "" && tb_composition.Text != "" && tb_contreIndi.Text != "" && tb_dp.Text != "" && tb_effets.Text != "" && tb_nom.Text != "")
            {
                btn_ajouter.Enabled = true;
            }
            else
            {
                btn_ajouter.Enabled = false;
            }
        }

        private void tb_cdefamille_TextChanged(object sender, EventArgs e)
        {
            if (tb_cdefamille.Text != "" && tb_composition.Text != "" && tb_contreIndi.Text != "" && tb_dp.Text != "" && tb_effets.Text != "" && tb_nom.Text != "")
            {
                btn_ajouter.Enabled = true;
            }
            else
            {
                btn_ajouter.Enabled = false;
            }
        }

        private void tb_composition_TextChanged(object sender, EventArgs e)
        {
            if (tb_cdefamille.Text != "" && tb_composition.Text != "" && tb_contreIndi.Text != "" && tb_dp.Text != "" && tb_effets.Text != "" && tb_nom.Text != "")
            {
                btn_ajouter.Enabled = true;
            }
            else
            {
                btn_ajouter.Enabled = false;
            }
        }

        private void tb_effets_TextChanged(object sender, EventArgs e)
        {
            if (tb_cdefamille.Text != "" && tb_composition.Text != "" && tb_contreIndi.Text != "" && tb_dp.Text != "" && tb_effets.Text != "" && tb_nom.Text != "")
            {
                btn_ajouter.Enabled = true;
            }
            else
            {
                btn_ajouter.Enabled = false;
            }
        }

        private void tb_contreIndi_TextChanged(object sender, EventArgs e)
        {
            if (tb_cdefamille.Text != "" && tb_composition.Text != "" && tb_contreIndi.Text != "" && tb_dp.Text != "" && tb_effets.Text != "" && tb_nom.Text != "")
            {
                btn_ajouter.Enabled = true;
            }
            else
            {
                btn_ajouter.Enabled = false;
            }
        }
    }
}
