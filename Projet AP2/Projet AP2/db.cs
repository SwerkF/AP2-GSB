using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projet_AP2
{
    public static class db
    {
        public static Boolean getInsertMed(string dpt, string nom, string fam, string compo, string effets, string contreIndi, float prix)
        {
            SqlCommand maRequete = new SqlCommand("prc_getInsertMed", Globale.cnx);
            // Il s’agit d’une procédure stockée:
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // Ajouter les parameters à la procédure stockée
            SqlParameter paramDpt = new SqlParameter("@MED_DEPOTLEGAL", System.Data.SqlDbType.NVarChar, 50);
            paramDpt.Value = dpt;
            SqlParameter paramNomMed = new SqlParameter("@MED_NOMCOMMERCIAL", System.Data.SqlDbType.NVarChar, 50);
            paramNomMed.Value = nom;
            SqlParameter paramFam = new SqlParameter("@FAM_CODE", System.Data.SqlDbType.NVarChar, 50);
            paramFam.Value = fam;
            SqlParameter paramCompo = new SqlParameter("@MED_COMPOSITION", System.Data.SqlDbType.NVarChar, 50);
            paramCompo.Value = compo;
            SqlParameter paramEffets = new SqlParameter("@MED_EFFETS", System.Data.SqlDbType.NVarChar, 50);
            paramEffets.Value = effets;
            SqlParameter paramContreIndi = new SqlParameter("@MED_CONTREINDIC", System.Data.SqlDbType.NVarChar, 50);
            paramContreIndi.Value = contreIndi;
            SqlParameter paramPrix = new SqlParameter("@MED_PRIXECHANTILLON", System.Data.SqlDbType.Float);
            paramPrix.Value = prix;
            maRequete.Parameters.Add(paramDpt);
            maRequete.Parameters.Add(paramNomMed);
            maRequete.Parameters.Add(paramFam);
            maRequete.Parameters.Add(paramCompo);
            maRequete.Parameters.Add(paramEffets);
            maRequete.Parameters.Add(paramContreIndi);
            maRequete.Parameters.Add(paramPrix);

            // exécuter la procedure stockée
            try
            {
                maRequete.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void listeClient()
        {

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_liste_medicament", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des medicaments avec ajout dans la collection
            while (SqlExec.Read())
            {
                string dpt = SqlExec["MED_DEPOTLEGAL"].ToString();
                string nom = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                string fam = SqlExec["FAM_CODE"].ToString();
                string compo = SqlExec["MED_COMPOSITION"].ToString();
                string effets = SqlExec["MED_EFFETS"].ToString();
                string contreIndi = SqlExec["MED_CONTREINDIC"].ToString();
           //     float prix = Convert.ToSingle(SqlExec["MED_PRIXECHANTILLON"].ToString());

                Medicament leMedicament = new Medicament(dpt, nom, fam, compo, effets, contreIndi, 0);

                Globale.LesMedicaments.Add(dpt, leMedicament);
            }
        }
        }
}
