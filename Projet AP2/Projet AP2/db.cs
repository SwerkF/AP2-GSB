using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

namespace Projet_AP2
{
    public static class db
    {
        //Procédure insertion nouveau médicament
        public static Boolean getInsertMed(string dpt, string nom, string fam, string compo, string effets, string contreIndi)
        {
            SqlCommand maRequete = new SqlCommand("prc_getInsertMed", Globale.cnx);
            // Il s’agit d’une procédure stockée:
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // Ajouter les parameters à la procédure stockée
            SqlParameter paramDpt = new SqlParameter("@dpt", System.Data.SqlDbType.NVarChar, 50);
            paramDpt.Value = dpt;
            SqlParameter paramNomMed = new SqlParameter("@nomMed", System.Data.SqlDbType.NVarChar, 50);
            paramNomMed.Value = nom;
            SqlParameter paramFam = new SqlParameter("@fam", System.Data.SqlDbType.NVarChar, 50);
            paramFam.Value = fam;
            SqlParameter paramCompo = new SqlParameter("@compo", System.Data.SqlDbType.NVarChar, 50);
            paramCompo.Value = compo;
            SqlParameter paramEffets = new SqlParameter("@effets", System.Data.SqlDbType.NVarChar, 50);
            paramEffets.Value = effets;
            SqlParameter paramContreIndi = new SqlParameter("@contreIndi", System.Data.SqlDbType.NVarChar, 50);
            paramContreIndi.Value = contreIndi;
            maRequete.Parameters.Add(paramDpt);
            maRequete.Parameters.Add(paramNomMed);
            maRequete.Parameters.Add(paramFam);
            maRequete.Parameters.Add(paramCompo);
            maRequete.Parameters.Add(paramEffets);
            maRequete.Parameters.Add(paramContreIndi);

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

        //Procédure liste client
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

                Medicament leMedicament = new Medicament(dpt, nom, fam, compo, effets, contreIndi);

                Globale.LesMedicaments.Add(dpt, leMedicament);
            }
        }

        //Procédure liste famille
        public static void listeFamille()
        {
            Globale.lesFamilles.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_liste_fam", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des familles avec ajout dans la collection
            while (SqlExec.Read())
            {
                string codeFam = SqlExec["FAM_CODE"].ToString();
                string libelle = SqlExec["FAM_LIBELLE"].ToString();
                int nbMed = int.Parse(SqlExec["nbMed"].ToString());

                Famille laFamille = new Famille(codeFam, libelle, nbMed);

                Globale.lesFamilles.Add(codeFam, laFamille);
            }
        }

        //Procédure liste médicament
        public static void listeMedicament()
        {
            Globale.LesMedicaments.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_liste_medicamentNonAutorise", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des familles avec ajout dans la collection
            while (SqlExec.Read())
            {
                string dpt = SqlExec["MED_DEPOTLEGAL"].ToString();
                string nom = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                string code_fam = SqlExec["FAM_CODE"].ToString();
                string compo = SqlExec["MED_COMPOSITION"].ToString();
                string effet = SqlExec["MED_EFFETS"].ToString();
                string contreIndi = SqlExec["MED_CONTREINDIC"].ToString();

                Medicament leMedicament = new Medicament(dpt, nom, code_fam, compo, effet, contreIndi);

                Globale.LesMedicaments.Add(dpt, leMedicament);
            }
        }

        //Procédure liste workflow
        public static void fillWorkflow()
        {
            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_getWorkflow", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();
            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                string med = SqlExec["WRK_MED_DEPOT"].ToString();
                int etpnum = int.Parse(SqlExec["WRK_ETP_NUM"].ToString());
                int dcsid = int.Parse(SqlExec["WRK_DCS_ID"].ToString());
                DateTime datetime = DateTime.Parse(SqlExec["WRK_DATE"].ToString());
                Etape uneEtape = null;
                int y = 0;
                while (uneEtape == null)
                {
                    if (Globale.LesEtapes[y].getNum() == etpnum) uneEtape = Globale.LesEtapes[y];
                    else y++;
                }
                Workflow nvMed = new Workflow(med, etpnum, dcsid, datetime);
                if (Globale.LesWorkflows.Keys.Contains(nvMed.getReference()))
                {
                    Globale.LesWorkflows[nvMed.getReference()].setEtape(etpnum);
                    Globale.LesWorkflows[nvMed.getReference()].addEtape(datetime, uneEtape);

                }
                else
                {
                    Globale.LesWorkflows.Add(nvMed.getReference(), nvMed);
                    Globale.LesWorkflows[nvMed.getReference()].addEtape(datetime, uneEtape);
                }
            }
        }

        //Procédure liste étape
        public static void fillEtapes()
        {
            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_getEtapes", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();
            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                int etp_num = int.Parse(SqlExec["ETP_NUM"].ToString());
                string etplibelle = SqlExec["ETP_LIBELLE"].ToString();
                string norme = SqlExec["NORME"].ToString();
                DateTime datetime = DateTime.Parse("01-01-1990");
                if (SqlExec["NORME_DATE"].ToString() != "")
                {
                    datetime = DateTime.Parse(SqlExec["NORME_DATE"].ToString());
                }
                if (norme != "")
                {
                    Norme nvEtape = new Norme(etp_num, etplibelle, norme, datetime);
                    Globale.LesEtapes.Add(nvEtape);
                }
                else
                {
                    Etape nvEtape = new Etape(etp_num, etplibelle);
                    Globale.LesEtapes.Add(nvEtape);
                }
            }
        }
    }
}
