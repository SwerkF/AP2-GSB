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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            db.getAllFamilles();

            foreach(string keys in Globale.lesFamilles.Keys)
            {
                MessageBox.Show(Globale.lesFamilles[keys].getCode());
            }
        }
    }
}
