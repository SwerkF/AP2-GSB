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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            
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
