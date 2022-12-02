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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void décisionPassageÉtapeSuivanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 child = new Form3();
            child.MdiParent = this;
            child.Show();
        }

        private void ajoutNouveauMédicamentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 child = new Form4();
            child.MdiParent = this;
            child.Show();
        }

        private void consultationNombreMédicamentParFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 child = new Form5();
            child.MdiParent = this;
            child.Show();
        }
    }
}
