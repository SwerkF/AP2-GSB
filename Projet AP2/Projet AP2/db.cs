using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projet_AP2
{
    public static class db
    {

      
        public static void getAllFamilles()
        {
            Globale.lesFamilles.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_getAllFamille", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                string idClient = SqlExec["FAM_CODE"].ToString();
                string nomClient = SqlExec["FAM_LIBELLE"].ToString();

                Famille leClient = new Famille(idClient, nomClient);

                Globale.lesFamilles.Add(idClient, leClient);
            }
        }
    }
}
