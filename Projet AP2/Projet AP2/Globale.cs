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
        public static Dictionary<string, Famille> lesFamilles;   //Liste des familles
        public static Dictionary<string, Medicament> LesMedicaments = new Dictionary<string, Medicament>();      //Liste des médicaments
    }
}
