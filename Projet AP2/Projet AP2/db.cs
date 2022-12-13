using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    public static class db
    {

        public static void fillWorkflow()
        {

            Globale.LesWorkflows.Clear();
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
                while(uneEtape == null)
                {
                    if (Globale.LesEtapes[y].getNum() == etpnum) uneEtape = Globale.LesEtapes[y];
                    else y++;
                }
                Workflow nvMed = new Workflow(med, etpnum, dcsid, datetime);
                if (Globale.LesWorkflows.Keys.Contains(nvMed.getReference()))
                {
                    Globale.LesWorkflows[nvMed.getReference()].setEtape(etpnum);
                    Globale.LesWorkflows[nvMed.getReference()].setDecision(dcsid);
                    Globale.LesWorkflows[nvMed.getReference()].addEtape(datetime, uneEtape);
                    
                } else
                {
                    Globale.LesWorkflows.Add(nvMed.getReference(), nvMed);
                    Globale.LesWorkflows[nvMed.getReference()].addEtape(datetime, uneEtape);
                }
            }
        }

        public static void fillEtapes()
        {
            Globale.LesEtapes.Clear();
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

                if(norme != "")
                {
                    Norme nvEtape = new Norme(etp_num, etplibelle, norme, datetime);
                    Globale.LesEtapes.Add(nvEtape);
                } else
                {
                    Etape nvEtape = new Etape(etp_num, etplibelle);

                Globale.LesEtapes.Add(nvEtape);
                }

                
            }
        }

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
                float prix = 0;

                Medicament leMedicament = new Medicament(dpt, nom, code_fam, compo, effet, contreIndi, prix);

                Globale.LesMedicaments.Add(dpt, leMedicament);
            }
        }

        public static Boolean addEtapeWorkflow(string depot, int numEtape, int decision, DateTime date)
        {
            SqlCommand maRequete = new SqlCommand("prc_ajoutEtapeWorkflow", Globale.cnx);
            // Il s’agit d’une procédure stockée:
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            // Ajouter les parameters à la procédure stockée
            SqlParameter paramIdDepot = new SqlParameter("@depot", System.Data.SqlDbType.NVarChar, 20);
            paramIdDepot.Value = depot;
            Debug.WriteLine(paramIdDepot.Value);
            SqlParameter paramNumEtape = new SqlParameter("@etpNum", System.Data.SqlDbType.Int, 2);
            paramNumEtape.Value = numEtape;

            SqlParameter paramNumDecision = new SqlParameter("@dcsNum", System.Data.SqlDbType.Int, 5);
            paramNumDecision.Value = decision;

            SqlParameter paramDate = new SqlParameter("@date", System.Data.SqlDbType.DateTime, 30);
            paramDate.Value = date;

            maRequete.Parameters.Add(paramIdDepot);
            maRequete.Parameters.Add(paramNumEtape);
            maRequete.Parameters.Add(paramNumDecision);
            maRequete.Parameters.Add(paramDate);

            MessageBox.Show(depot + " ; " + numEtape.ToString() + " ; " + decision.ToString() + " ; " + date.ToString());

            // exécuter la procedure stockée
            try
            {
                maRequete.ExecuteNonQuery();
                MessageBox.Show("Ca marche");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
