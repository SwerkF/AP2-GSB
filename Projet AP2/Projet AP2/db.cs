using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    }
}
