using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projet_AP2
{
    internal class Globale
    {
        public static SqlConnection cnx;
        public static Dictionary<string, Famille> lesFamilles = new Dictionary<string, Famille>();   //Liste des familles
        public static Dictionary<string, Medicament> LesMedicaments = new Dictionary<string, Medicament>();      //Liste des médicaments
        public static Dictionary<string, Workflow> LesWorkflows = new Dictionary<string, Workflow>();      //Liste des Workflows
        public static List<Etape> LesEtapes = new List<Etape>();      //Liste des etapes
    }
}
