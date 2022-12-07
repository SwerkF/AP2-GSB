using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_AP2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            db.listeFamille();
            foreach(string key in Globale.lesFamilles.Keys)
            {
                Famille laFamille = Globale.lesFamilles[key];
                ListViewItem maLigne = new ListViewItem();
                maLigne.Text = laFamille.getCodeFamille();
                maLigne.SubItems.Add(laFamille.getLibelle());
                maLigne.SubItems.Add(laFamille.getNbMed().ToString());
                lv_famille.Items.Add(maLigne);
            }
        }
    }
}
