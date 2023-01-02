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
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //Page ajout nouveau médicament
        private void ajoutNouveauMédicamentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 child = new Form4();
            child.MdiParent = this;
            child.Show();
        }

        //Page consultation nombre médicament
        private void consultationNombreMédicamentParFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 child = new Form5();
            child.MdiParent = this;
            child.Show();
        }

        //Page consultation médicament en cours de validation
        private void consultationMédicamentEnCoursDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 child = new Form6();
            child.MdiParent = this;
            child.Show();
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
