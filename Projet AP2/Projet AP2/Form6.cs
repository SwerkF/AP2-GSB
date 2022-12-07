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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            db.listeMedicament();
            foreach (string key in Globale.LesMedicaments.Keys)
            {
                Medicament leMedicament = Globale.LesMedicaments[key];
                ListViewItem maLigne = new ListViewItem();
                maLigne.Text = leMedicament.getDepot();
                maLigne.SubItems.Add(leMedicament.getNom());
                maLigne.SubItems.Add(leMedicament.getFamille());
                lv_med.Items.Add(maLigne);
            }
        }

        private void lv_med_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
