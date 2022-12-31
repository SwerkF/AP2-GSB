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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void consultationWorkflowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void décisionPassageÉtapeSuivanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changement_decision form = new changement_decision();
            form.MdiParent = this;
            form.Show();
        }

        private void consultationWorkflowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultation_workflow form = new consultation_workflow();
            form.MdiParent = this;
            form.Show();
        }

        private void miseÀJourÉtapeNorméeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            maj_etp_norme form = new maj_etp_norme();
            form.MdiParent = this;
            form.Show();
        }
    }
}
